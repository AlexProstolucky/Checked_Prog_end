using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process programProcess = new Process();
            string path = "notepad.exe";
            programProcess.StartInfo = new ProcessStartInfo(path);
            try
            {
                programProcess.Start();
                programProcess.WaitForExit();
                if (programProcess.HasExited)
                {
                    MessageBox.Show("The program is finished", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the program: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}