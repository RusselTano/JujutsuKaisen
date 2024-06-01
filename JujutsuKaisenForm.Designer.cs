namespace JujutsuKaisen
{
    partial class JujutsuKaisenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JujutsuKaisenForm));
            this.styleGroupBox = new System.Windows.Forms.GroupBox();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.dixRadioButton = new System.Windows.Forms.RadioButton();
            this.douzeRadioButton = new System.Windows.Forms.RadioButton();
            this.quatorzeRadioButton = new System.Windows.Forms.RadioButton();
            this.huitRadioButton = new System.Windows.Forms.RadioButton();
            this.jujutsuKaisenGroupBox = new System.Windows.Forms.GroupBox();
            this.infoJujutsuKaisenLabel = new System.Windows.Forms.Label();
            this.sukunaTimer = new System.Windows.Forms.Timer(this.components);
            this.dessinPictureBox = new System.Windows.Forms.PictureBox();
            this.sukunaPictureBox = new System.Windows.Forms.PictureBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.styleGroupBox.SuspendLayout();
            this.jujutsuKaisenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // styleGroupBox
            // 
            this.styleGroupBox.Controls.Add(this.italicCheckBox);
            this.styleGroupBox.Controls.Add(this.boldCheckBox);
            this.styleGroupBox.Controls.Add(this.fontComboBox);
            this.styleGroupBox.Controls.Add(this.dixRadioButton);
            this.styleGroupBox.Controls.Add(this.douzeRadioButton);
            this.styleGroupBox.Controls.Add(this.quatorzeRadioButton);
            this.styleGroupBox.Controls.Add(this.huitRadioButton);
            this.styleGroupBox.Location = new System.Drawing.Point(21, 37);
            this.styleGroupBox.Name = "styleGroupBox";
            this.styleGroupBox.Size = new System.Drawing.Size(463, 138);
            this.styleGroupBox.TabIndex = 0;
            this.styleGroupBox.TabStop = false;
            this.styleGroupBox.Text = "Style";
            // 
            // fontComboBox
            // 
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(21, 37);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(247, 24);
            this.fontComboBox.TabIndex = 6;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // dixRadioButton
            // 
            this.dixRadioButton.AutoSize = true;
            this.dixRadioButton.Location = new System.Drawing.Point(85, 89);
            this.dixRadioButton.Name = "dixRadioButton";
            this.dixRadioButton.Size = new System.Drawing.Size(42, 20);
            this.dixRadioButton.TabIndex = 5;
            this.dixRadioButton.Text = "10";
            this.dixRadioButton.UseVisualStyleBackColor = true;
            this.dixRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckedChanged);
            // 
            // douzeRadioButton
            // 
            this.douzeRadioButton.AutoSize = true;
            this.douzeRadioButton.Location = new System.Drawing.Point(152, 89);
            this.douzeRadioButton.Name = "douzeRadioButton";
            this.douzeRadioButton.Size = new System.Drawing.Size(42, 20);
            this.douzeRadioButton.TabIndex = 4;
            this.douzeRadioButton.Text = "12";
            this.douzeRadioButton.UseVisualStyleBackColor = true;
            this.douzeRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckedChanged);
            // 
            // quatorzeRadioButton
            // 
            this.quatorzeRadioButton.AutoSize = true;
            this.quatorzeRadioButton.Location = new System.Drawing.Point(226, 89);
            this.quatorzeRadioButton.Name = "quatorzeRadioButton";
            this.quatorzeRadioButton.Size = new System.Drawing.Size(42, 20);
            this.quatorzeRadioButton.TabIndex = 3;
            this.quatorzeRadioButton.Text = "14";
            this.quatorzeRadioButton.UseVisualStyleBackColor = true;
            this.quatorzeRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckedChanged);
            // 
            // huitRadioButton
            // 
            this.huitRadioButton.AutoSize = true;
            this.huitRadioButton.Location = new System.Drawing.Point(21, 89);
            this.huitRadioButton.Name = "huitRadioButton";
            this.huitRadioButton.Size = new System.Drawing.Size(35, 20);
            this.huitRadioButton.TabIndex = 2;
            this.huitRadioButton.Text = "8";
            this.huitRadioButton.UseVisualStyleBackColor = true;
            this.huitRadioButton.CheckedChanged += new System.EventHandler(this.SizeRadioButton_CheckedChanged);
            // 
            // jujutsuKaisenGroupBox
            // 
            this.jujutsuKaisenGroupBox.Controls.Add(this.infoJujutsuKaisenLabel);
            this.jujutsuKaisenGroupBox.Location = new System.Drawing.Point(504, 37);
            this.jujutsuKaisenGroupBox.Name = "jujutsuKaisenGroupBox";
            this.jujutsuKaisenGroupBox.Size = new System.Drawing.Size(373, 310);
            this.jujutsuKaisenGroupBox.TabIndex = 1;
            this.jujutsuKaisenGroupBox.TabStop = false;
            this.jujutsuKaisenGroupBox.Text = "Jujutsu Kaisen";
            // 
            // infoJujutsuKaisenLabel
            // 
            this.infoJujutsuKaisenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoJujutsuKaisenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoJujutsuKaisenLabel.Location = new System.Drawing.Point(23, 37);
            this.infoJujutsuKaisenLabel.Name = "infoJujutsuKaisenLabel";
            this.infoJujutsuKaisenLabel.Size = new System.Drawing.Size(323, 248);
            this.infoJujutsuKaisenLabel.TabIndex = 0;
            this.infoJujutsuKaisenLabel.Text = "shonen manga\r\nGege Akutami\r\nWeekly Shonen Jump\r\nMars 2018\r\nShueisha\r\nMappa";
            // 
            // sukunaTimer
            // 
            this.sukunaTimer.Enabled = true;
            this.sukunaTimer.Tick += new System.EventHandler(this.sukunaTimer_Tick);
            // 
            // dessinPictureBox
            // 
            this.dessinPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dessinPictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.dessinPictureBox.Location = new System.Drawing.Point(3, 368);
            this.dessinPictureBox.Name = "dessinPictureBox";
            this.dessinPictureBox.Size = new System.Drawing.Size(923, 235);
            this.dessinPictureBox.TabIndex = 2;
            this.dessinPictureBox.TabStop = false;
            this.dessinPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dessinPictureBox_Paint);
            // 
            // sukunaPictureBox
            // 
            this.sukunaPictureBox.BackColor = System.Drawing.Color.White;
            this.sukunaPictureBox.Image = global::JujutsuKaisen.Properties.Resources.Sukuna;
            this.sukunaPictureBox.Location = new System.Drawing.Point(3, 624);
            this.sukunaPictureBox.Name = "sukunaPictureBox";
            this.sukunaPictureBox.Size = new System.Drawing.Size(145, 151);
            this.sukunaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sukunaPictureBox.TabIndex = 1;
            this.sukunaPictureBox.TabStop = false;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.italicCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("italicCheckBox.Image")));
            this.italicCheckBox.Location = new System.Drawing.Point(370, 37);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(78, 76);
            this.italicCheckBox.TabIndex = 3;
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.StyleCheckBox_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.boldCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("boldCheckBox.Image")));
            this.boldCheckBox.Location = new System.Drawing.Point(286, 37);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(78, 76);
            this.boldCheckBox.TabIndex = 2;
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.StyleCheckBox_CheckedChanged);
            // 
            // JujutsuKaisenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 776);
            this.Controls.Add(this.dessinPictureBox);
            this.Controls.Add(this.sukunaPictureBox);
            this.Controls.Add(this.jujutsuKaisenGroupBox);
            this.Controls.Add(this.styleGroupBox);
            this.Name = "JujutsuKaisenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Styles de polices, dessins et animations";
            this.Load += new System.EventHandler(this.JujutsuKaisenForm_Load);
            this.styleGroupBox.ResumeLayout(false);
            this.styleGroupBox.PerformLayout();
            this.jujutsuKaisenGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dessinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukunaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox styleGroupBox;
        private System.Windows.Forms.GroupBox jujutsuKaisenGroupBox;
        private System.Windows.Forms.Label infoJujutsuKaisenLabel;
        private System.Windows.Forms.RadioButton dixRadioButton;
        private System.Windows.Forms.RadioButton douzeRadioButton;
        private System.Windows.Forms.RadioButton quatorzeRadioButton;
        private System.Windows.Forms.RadioButton huitRadioButton;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.PictureBox sukunaPictureBox;
        private System.Windows.Forms.Timer sukunaTimer;
        private System.Windows.Forms.PictureBox dessinPictureBox;
    }
}

