using kanbanboard.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace kanbanboard
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Application.OpenForms.OfType<LoginForm>().Any()) Application.Run(new LoginForm());
        }
    }
}
