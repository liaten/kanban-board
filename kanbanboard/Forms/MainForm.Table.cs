using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using kanbanboard.Classes;
using kanbanboard.Controls;

namespace kanbanboard.Forms
{
    public partial class MainForm
    {
        // Процедура загрузки в базу
        private void Upload(string project)
        {
            if (TableLayoutPanel.Controls.Count == 0) return;

            var allData = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();

            var columnDate = new Dictionary<string, List<Dictionary<string, string>>>();

            for (var column = 0; column < TableLayoutPanel.ColumnStyles.Count; column++)
            {
                var ticket = new List<Dictionary<string, string>>();

                for (var row = 1; row < TableLayoutPanel.RowStyles.Count; row++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, row) != null)
                        ticket.Add(new Dictionary<string, string>
                        {
                            {"Title", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).Title.Text},
                            {"Ticket", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).Ticket.Text},
                            {"People", ((TicketPanel)TableLayoutPanel.GetControlFromPosition(column, row)).People.Text}
                        });
                }

                if ((TitlePanel)TableLayoutPanel.GetControlFromPosition(column, 0) != null)
                    columnDate.Add($"{column + 1}-" + ((TitlePanel)TableLayoutPanel.GetControlFromPosition(column, 0)).TitleColumnLabel.Text, ticket);
            }
            allData.Add(project, columnDate);

            // Вызов процедуры загрузки данных в базу
            Firebase.UploadData(allData);
        }

        private void LoadPanel_Paint(object sender, PaintEventArgs e)
        {
            var rnd = new Random();
            LoadLabel.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        // Загрузить данные в tablelayoutpanel
        private void TableFromFirebase(string selectedProject)
        {
            LoadPanel.BringToFront();

            TableLayoutPanel.RowStyles.Clear();
            TableLayoutPanel.ColumnCount = 0;
            TableLayoutPanel.RowCount = 1;
            TableLayoutPanel.ColumnStyles.Clear();
            TableLayoutPanel.Controls.Clear();

            foreach (var projects in _user.GetProjectsData().Where(item => item.Key == selectedProject))
            {
                int column = 0, row = 1;
                foreach (var titles in projects.Value)
                {
                    // Заголовок
                    AddTitleToPanel(titles.Key.Substring(2).FirstCharToUpper(), column);

                    foreach (var tasks in titles.Value)
                    {
                        var ticket = new TicketPanel();
                        try {  
                            ticket.Title.Text = tasks["Title"] ?? ""; 
                            ticket.Ticket.Text = tasks["Ticket"] ?? ""; 
                            ticket.People.Text = tasks["People"] ?? "";
                        }
                        catch { }

                        AddControlToPanel(ticket.Title.Text, ticket.Ticket.Text, ticket.People.Text, column, row++);
                    }
                    column++;
                    row = 1;
                }
            }

            ResizeTable();

            if (BasicContentPanel.Controls.GetChildIndex(PanelWithTable) == 1) PanelWithTable.BringToFront();
            else if (BasicContentPanel.Controls.GetChildIndex(MessengerPanel) == 1) MessengerPanel.BringToFront();
        }

        // События на кнопки
        private void SetEventsOnTicket(TicketPanel ticketPanel)
        {
            // Событие по клику на каждый тикет. Открывает панель для выполнения изменений выбранного тикета
            ticketPanel.Click += (_, _) =>
            {
                // Показ панели. Возврат к тикетам. Масштабируемость
                if (!Application.OpenForms.OfType<TicketsChangeForm>().Any()) new TicketsChangeForm(this, ticketPanel).Show();
            };

            // перемещение тикетов влево, вправо и 
            ticketPanel.LeftButton.Click += (_, _) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(ticketPanel).Column - 1;
                if (column < 0) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(ticketPanel, column, i);
                    ResizeTable();
                    return;
                }
            };

            // Перемещение вправо
            ticketPanel.RightButton.Click += (_, _) =>
            {
                var column = TableLayoutPanel.GetPositionFromControl(ticketPanel).Column + 1;
                if (column > TableLayoutPanel.ColumnCount) return;

                for (var i = 1; i < TableLayoutPanel.RowCount; i++)
                {
                    if (TableLayoutPanel.GetControlFromPosition(column, i) != null) continue;
                    AddControlToPanel(ticketPanel, column, i);
                    ResizeTable();
                    return;
                }
            };

            // Удаление тикета
            ticketPanel.DelButton.Click += (_, _) => TableLayoutPanel.Controls.Remove(ticketPanel);
        }

        // Добавление заголовков
        private void AddTitleToPanel(string textOfLabel, int column)
        {
            var titlePanel = new TitlePanel { Name = $"title{column}{0}" };
            titlePanel.TitleColumnLabel.Text = textOfLabel;

            TableLayoutPanel.SuspendLayout();

            if (TableLayoutPanel.ColumnStyles.Count <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            TableLayoutPanel.Controls.Add(titlePanel, column, 0);
            TableLayoutPanel.ResumeLayout();

            // Добавляем события на кнопки, если пользователь соответствующей роли
            if (_user.Role is Roles.Admin || _user.Role is Roles.Manager)
            {
                // Изменить заголовок
                titlePanel.TitleColumnLabel.Click += (_, _) =>
                {
                    if (!Application.OpenForms.OfType<ChangeForm>().Any())
                        new ChangeForm(this, titlePanel).Show();
                };

                // Добавляем события на кнопки
                titlePanel.PlusButton.Click += (_, _) =>
                {
                    for (var row = 1; row <= TableLayoutPanel.RowStyles.Count; row++)
                    {
                        if (!(TableLayoutPanel.GetControlFromPosition(column, row) is null)) continue;
                        AddControlToPanel("Заголовок", "Описание", "Разработчики", column, row);
                        break;
                    }
                };

                // Удалить колонку
                titlePanel.DelColumnButton.Click += (_, _) =>
                {
                    for (var i = 1; i < TableLayoutPanel.ColumnStyles.Count; i++)
                    {
                        var control = TableLayoutPanel.GetControlFromPosition(TableLayoutPanel.GetPositionFromControl(titlePanel).Column, i);
                        TableLayoutPanel.Controls.Remove(control);
                    }

                    var col = TableLayoutPanel.GetPositionFromControl(titlePanel).Column;
                    if (col != 0)
                    {
                        TableLayoutPanel.Controls.Remove(titlePanel);

                        for (; col < TableLayoutPanel.ColumnStyles.Count; col++)
                        {
                            for (var row = 0; row < TableLayoutPanel.RowStyles.Count; row++)
                            {
                                if (TableLayoutPanel.GetControlFromPosition(col, row) == null) continue;
                                AddControlToPanel(TableLayoutPanel.GetControlFromPosition(col, row), col - 1, row);
                            }
                        }

                        if (TableLayoutPanel.ColumnStyles.Count == TableLayoutPanel.ColumnCount)
                            TableLayoutPanel.ColumnStyles.RemoveAt(TableLayoutPanel.ColumnCount - 1);
                        TableLayoutPanel.ColumnCount--;
                        ResizeTable();
                    }
                    else
                    {
                        TableLayoutPanel.Controls.Clear();
                        TableLayoutPanel.RowCount = 1;
                        TableLayoutPanel.RowStyles.Clear();
                        TableLayoutPanel.ColumnCount = 0;
                        TableLayoutPanel.ColumnStyles.Clear();
                    }
                };

                // Изменить заголовок
                titlePanel.Click += (_, _) =>
                {
                    if (!Application.OpenForms.OfType<ChangeForm>().Any())
                        new ChangeForm(this, titlePanel).Show();
                };
            }
            else
            {
                titlePanel.PlusButton.Visible = false;
                titlePanel.DelColumnButton.Visible = false;
            }
        }

        // Добавить колонку
        private void AddTitleButton_Click(object sender, EventArgs e)
        {
            var column = 0;

            for (var findColumn = 0; findColumn < TableLayoutPanel.ColumnStyles.Count; findColumn++)
            {
                if (!(TableLayoutPanel.GetControlFromPosition(findColumn, 0) is null)) continue;
                column = TableLayoutPanel.ColumnStyles.Count;
                break;
            }

            if (TableLayoutPanel.ColumnStyles.Count >= 1 && column == 0) column = TableLayoutPanel.ColumnStyles.Count;

            AddControlToPanel("Заголовок", "Описание", "Разработчики", column, 1);
            AddTitleToPanel("Это тайтл", column);
        }

        // Добавить контрол (в основном тикет) в таблицу
        private void AddControlToPanel(Control control, int column, int row)
        {
            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row)
            {
                TableLayoutPanel.RowCount++;
                TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            }

            if (TableLayoutPanel.ColumnStyles.Count <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(control, column, row);
            TableLayoutPanel.ResumeLayout();

            ResizeTable();
        }

        // Добавить тикет в таблицу
        private void AddControlToPanel(string title, string ticket, string people, int column, int row)
        {
            var control = new TicketPanel();
            control.Title.Text = title;
            control.Ticket.Text = ticket;
            control.People.Text = people;

            // Добавляем события на кнопки, если пользователь соответствующей роли
            if (_user.Role is Roles.Admin || _user.Role is Roles.Manager) SetEventsOnTicket(control);
            else
            {
                control.DelButton.Visible = false;
                control.LeftButton.Visible = false;
                control.RightButton.Visible = false;
            }

            // Инициализация имени панели тикета
            control.Name = $"ticket{column}{row}";

            // Нужно ли добавлять доп. строки и/или колонки
            if (TableLayoutPanel.RowStyles.Count <= row)
            {
                if (row <= 1)
                {
                    TableLayoutPanel.RowCount++;
                    TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
                    TableLayoutPanel.RowCount++;
                    TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
                }
                else
                {
                    TableLayoutPanel.RowCount++;
                    TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
                }
            }

            if (TableLayoutPanel.ColumnStyles.Count <= column)
            {
                TableLayoutPanel.ColumnCount++;
                TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
            }

            TableLayoutPanel.SuspendLayout();
            TableLayoutPanel.Controls.Add(control, column, row);
            TableLayoutPanel.ResumeLayout();

            ResizeTable();
        }

        // Масштабируемость канбан доски
        private void ResizeTable()
        {
            try
            {
                foreach (ColumnStyle column in TableLayoutPanel.ColumnStyles) {
                    column.SizeType = SizeType.Percent;
                    column.Width = 25;
                }

                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => x.Width = TableLayoutPanel.Width / TableLayoutPanel.ColumnCount);

                TableLayoutPanel.RowStyles[0].SizeType = SizeType.Absolute;
                TableLayoutPanel.RowStyles[0].Height = 25;
                
                foreach (var row in TableLayoutPanel.RowStyles.Cast<RowStyle>().ToList().Skip(1)) {
                    row.SizeType = SizeType.Absolute;
                    row.Height = 150;
                }

                TableLayoutPanel.Controls.OfType<TicketPanel>().ToList().ForEach(x => {
                    if (TableLayoutPanel.GetCellPosition(x).Row != 0)
                        x.Height = TableLayoutPanel.Height / TableLayoutPanel.RowCount;
                });

                if (WindowState == FormWindowState.Maximized)
                    TableLayoutPanel.Refresh();
            }

            catch { }
        }

        // Доп. ручное сохранение таблицы
        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            if (ListBoxOfProjectNames.SelectedItem != null)
                Upload(ListBoxOfProjectNames.SelectedItem.ToString());
        }

        // Удалить выбранный проект
        private async void TrashButton_Click(object sender, EventArgs e)
        {
            if (await _user.DeleteProject(ListBoxOfProjectNames.SelectedItem?.ToString()) == "OK")
                SetUserProjectNames();
        }
    }
}
