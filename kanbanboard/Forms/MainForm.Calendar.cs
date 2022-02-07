using kanbanboard.Classes;
using kanbanboard.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace kanbanboard.Forms
{
    public partial class MainForm
    {
        // Обработчик календаря
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            LabelHead.Text = "Календарь";
            CalendarPanel.BringToFront();

            StripPanel.Location = CalendarButton.Location;
            StripPanel.Size = new Size(StripPanel.Size.Width, CalendarButton.Size.Height);

            HideOrShowProjectListBox(true);
        }
        private async void CalendarDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            await Firebase.SetDeadline(CalendarDateTimePicker.Value, ListBoxOfProjectNames.SelectedItem.ToString());
            await ShowDeadline();
        }

        private async Task ShowDeadline()
        {
            var date = await Firebase.GetDeadline(ListBoxOfProjectNames.SelectedItem.ToString());

            CalendarDeadlineLabel.Text = $"Дедлайн проекта: {date}";
            CalendarDateTimePicker.Value = DateTime.Parse(date);
            CalendarDeadlineLabel.ForeColor = CalendarDateTimePicker.Value >= DateTime.Now ? Color.LimeGreen : Color.Red;
        }

        private Task ShowEmployees()
        {
            var employees = new List<string>() { };

            foreach (var ticket in TableLayoutPanel.Controls.OfType<TicketPanel>().ToList())
                employees.AddRange(ticket.People.Text.Split(',', ' ', '.'));

            employees.AddRange(from item in LoginForm._users where item.Value.Projects.Contains(ListBoxOfProjectNames.SelectedItem.ToString()) select item.Key);

            EmployeesListBox.Items.Clear();
            EmployeesListBox.Items.AddRange(employees.Distinct().ToArray());

            return Task.CompletedTask;
        }
    }
}
