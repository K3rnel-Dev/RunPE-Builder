namespace RunPEBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BorderSetter = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.File_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SelectedProcess = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BuidBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AutoRun_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ObfuscateChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "RunPE Builder V.2 ";
            // 
            // AnimateWindow
            // 
            this.AnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.AnimateWindow.TargetForm = this;
            // 
            // BorderSetter
            // 
            this.BorderSetter.AnimateWindow = true;
            this.BorderSetter.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.BorderSetter.ContainerControl = this;
            this.BorderSetter.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.BorderSetter.DockIndicatorTransparencyValue = 0.6D;
            this.BorderSetter.ResizeForm = false;
            this.BorderSetter.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.BorderSetter.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(436, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // File_Box
            // 
            this.File_Box.Animated = true;
            this.File_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.File_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.File_Box.DefaultText = "";
            this.File_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.File_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.File_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.File_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.File_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.File_Box.FocusedState.BorderColor = System.Drawing.Color.Chocolate;
            this.File_Box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.File_Box.HoverState.BorderColor = System.Drawing.Color.Chocolate;
            this.File_Box.Location = new System.Drawing.Point(28, 84);
            this.File_Box.Margin = new System.Windows.Forms.Padding(4);
            this.File_Box.Name = "File_Box";
            this.File_Box.PasswordChar = '\0';
            this.File_Box.PlaceholderText = "";
            this.File_Box.SelectedText = "";
            this.File_Box.Size = new System.Drawing.Size(374, 37);
            this.File_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.File_Box.TabIndex = 13;
            this.File_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(384, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.guna2GroupBox1.Controls.Add(this.SelectedProcess);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.SelectFileBtn);
            this.guna2GroupBox1.Controls.Add(this.BuidBtn);
            this.guna2GroupBox1.Controls.Add(this.AutoRun_Chk);
            this.guna2GroupBox1.Controls.Add(this.ObfuscateChk);
            this.guna2GroupBox1.Controls.Add(this.File_Box);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(27, 69);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(481, 310);
            this.guna2GroupBox1.TabIndex = 16;
            this.guna2GroupBox1.Text = "Main Form";
            // 
            // SelectedProcess
            // 
            this.SelectedProcess.BackColor = System.Drawing.Color.Transparent;
            this.SelectedProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.SelectedProcess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectedProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.SelectedProcess.FocusedColor = System.Drawing.Color.Chocolate;
            this.SelectedProcess.FocusedState.BorderColor = System.Drawing.Color.Chocolate;
            this.SelectedProcess.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.SelectedProcess.HoverState.BorderColor = System.Drawing.Color.Chocolate;
            this.SelectedProcess.ItemHeight = 30;
            this.SelectedProcess.Items.AddRange(new object[] {
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\RegSvcs.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\csc.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\RegAsm.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\CasPol.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\dfsvc.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\InstallUtil.exe",
            "C:\\\\Windows\\\\Microsoft.NET\\\\Framework\\\\v4.0.30319\\\\jsc.exe"});
            this.SelectedProcess.Location = new System.Drawing.Point(28, 167);
            this.SelectedProcess.Name = "SelectedProcess";
            this.SelectedProcess.Size = new System.Drawing.Size(432, 36);
            this.SelectedProcess.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SelectedProcess.TabIndex = 21;
            this.SelectedProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Process-To-Inject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Target-File";
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Animated = true;
            this.SelectFileBtn.AnimatedGIF = true;
            this.SelectFileBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.SelectFileBtn.BorderThickness = 1;
            this.SelectFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectFileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectFileBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.SelectFileBtn.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileBtn.ForeColor = System.Drawing.Color.White;
            this.SelectFileBtn.Image = global::RunPEBuilder.Properties.Resources._2;
            this.SelectFileBtn.Location = new System.Drawing.Point(409, 84);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SelectFileBtn.Size = new System.Drawing.Size(51, 37);
            this.SelectFileBtn.TabIndex = 18;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // BuidBtn
            // 
            this.BuidBtn.Animated = true;
            this.BuidBtn.AnimatedGIF = true;
            this.BuidBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.BuidBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.BuidBtn.BorderThickness = 1;
            this.BuidBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuidBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuidBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuidBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuidBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.BuidBtn.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuidBtn.ForeColor = System.Drawing.Color.White;
            this.BuidBtn.HoverState.BorderColor = System.Drawing.Color.Chocolate;
            this.BuidBtn.Image = global::RunPEBuilder.Properties.Resources._3;
            this.BuidBtn.ImageOffset = new System.Drawing.Point(-9, 0);
            this.BuidBtn.ImageSize = new System.Drawing.Size(27, 27);
            this.BuidBtn.Location = new System.Drawing.Point(144, 231);
            this.BuidBtn.Name = "BuidBtn";
            this.BuidBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuidBtn.Size = new System.Drawing.Size(316, 52);
            this.BuidBtn.TabIndex = 17;
            this.BuidBtn.Text = "BUILD";
            this.BuidBtn.Click += new System.EventHandler(this.BuidBtn_Click);
            // 
            // AutoRun_Chk
            // 
            this.AutoRun_Chk.Animated = true;
            this.AutoRun_Chk.AutoSize = true;
            this.AutoRun_Chk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoRun_Chk.CheckedState.BorderRadius = 0;
            this.AutoRun_Chk.CheckedState.BorderThickness = 0;
            this.AutoRun_Chk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoRun_Chk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoRun_Chk.Location = new System.Drawing.Point(19, 231);
            this.AutoRun_Chk.Name = "AutoRun_Chk";
            this.AutoRun_Chk.Size = new System.Drawing.Size(99, 25);
            this.AutoRun_Chk.TabIndex = 16;
            this.AutoRun_Chk.Text = "AutoRun";
            this.AutoRun_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoRun_Chk.UncheckedState.BorderRadius = 0;
            this.AutoRun_Chk.UncheckedState.BorderThickness = 0;
            this.AutoRun_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ObfuscateChk
            // 
            this.ObfuscateChk.Animated = true;
            this.ObfuscateChk.AutoSize = true;
            this.ObfuscateChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ObfuscateChk.CheckedState.BorderRadius = 0;
            this.ObfuscateChk.CheckedState.BorderThickness = 0;
            this.ObfuscateChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ObfuscateChk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ObfuscateChk.Location = new System.Drawing.Point(19, 262);
            this.ObfuscateChk.Name = "ObfuscateChk";
            this.ObfuscateChk.Size = new System.Drawing.Size(110, 25);
            this.ObfuscateChk.TabIndex = 15;
            this.ObfuscateChk.Text = "Obfuscate";
            this.ObfuscateChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ObfuscateChk.UncheckedState.BorderRadius = 0;
            this.ObfuscateChk.UncheckedState.BorderThickness = 0;
            this.ObfuscateChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RunPEBuilder.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(93)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(85, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "BY K3RNEL-DEV";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(534, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunPEBuilder - [ by k3rnel-dev ] ";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderSetter;
        private Guna.UI2.WinForms.Guna2TextBox File_Box;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button SelectFileBtn;
        private Guna.UI2.WinForms.Guna2Button BuidBtn;
        private Guna.UI2.WinForms.Guna2CheckBox AutoRun_Chk;
        private Guna.UI2.WinForms.Guna2CheckBox ObfuscateChk;
        private Guna.UI2.WinForms.Guna2ComboBox SelectedProcess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

