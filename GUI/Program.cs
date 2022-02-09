using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        class MainForm : Form
        {
            Button button = new Button();
            public MainForm() {
                this.Width = 320;
                this.Height = 200;
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MessageBox.Show("Przykładowy tekst.");
                Application.Run(new MainForm());
            }
        }
    }
}
