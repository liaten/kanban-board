using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace kanbanboard.Classes
{
    public static class Extensions
    {
        private static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }
            return list;
        }
        public static List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        public static void InitRoboto(this Control control)
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.Roboto.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Roboto;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            List<Control> allControls = GetAllControls(control);
            allControls.ForEach(k => k.Font = new System.Drawing.Font(pfc.Families[0], k.Font.Size));
        }

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
