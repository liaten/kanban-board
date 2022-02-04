using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kanbanboard.Classes
{
    public static class Extensions
    {
        public static void ToCenter(this Control control, Control where)
        {
            control.Left = (where.Width - control.Width) / 2;
            control.Top = (where.Height - control.Height) / 2;
        }

        public static void RemoveNullsFromData(this List<string> data) => data.RemoveAll(x => x is null);

        /// <summary> Из string в enum </summary>
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        /// <summary> Первый символ принимаемой строки переводится в верхний регистр </summary>
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($@"{nameof(input)}", nameof(input));
                default: return input[0].ToString().ToUpper() + input.Substring(1);
            }
        }

        /// <summary> Проверка на то, находится ли контрол на самом верху иерархии </summary>
        public static bool IsControlAtFront(this Control control)
        {
            while (control.Parent != null)
            {
                if (control.Parent.Controls.GetChildIndex(control) == 0)
                {
                    control = control.Parent;
                    if (control.Parent == null)
                        return true;
                }
                else return false;
            }
            return false;
        }

        /// <summary> Валидация email </summary>
        public static bool ValidEmail(this string email) => new Regex(@"^(\w|\d|\.|_|-)+@(\w|\d){1,}\.[\w]{1,}\.?[\w]*$", RegexOptions.IgnoreCase).IsMatch(email);
    }
}
