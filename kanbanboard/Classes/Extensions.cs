using System;
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

        public static string FirstCharToUpper(this string input)
        {
            switch (input) 
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)}", nameof(input));
                default: return input[0].ToString().ToUpper() + input.Substring(1);
            }
        }

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

        public static bool ValidEmail(this string email) => new Regex(@"^(\w|\d|\.|_|-)+@(\w|\d){1,}\.[\w]{1,}\.?[\w]*$", RegexOptions.IgnoreCase).IsMatch(email);
    }
}
