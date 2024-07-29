using System;
using System.Drawing.Drawing2D;
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref msg);
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

        private void BuidBtn_Click(object sender, EventArgs e)
        {
            string
                FileName = File_Box.Text,
                InjectProcess = SelectedProcess.Text;

            bool obfuscate = ObfuscateChk.Checked;

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
                    string result = Include.Runtime.RuntimeMain(FileName, saveFileDialog.FileName,InjectProcess, obfuscate);

                    MessageBox.Show(result, "~Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            int CornerRadius = 40;
            GraphicsPath path = CreateRoundedRectanglePath(this.Width, this.Height, CornerRadius);
            this.Region = new Region(path);
        }

        private GraphicsPath CreateRoundedRectanglePath(int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Add rounded corners to the path
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(width - radius, 0, radius, radius, 270, 90);
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            path.AddArc(0, height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
