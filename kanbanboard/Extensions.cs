using System.Windows.Forms;

namespace kanbanboard
{
    public static class Extensions
    {
        public static void ToCenter(this Control control, Control where)
        {
            control.Left = (where.Width - control.Width) / 2;
            control.Top = (where.Height - control.Height) / 2;
        }
    }
}
