namespace darkroom
{
    partial class frmDarkroom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectPhotos = new Button();
            btnConvert = new Button();
            ofdOriginalPhotos = new OpenFileDialog();
            lvSelectedPhotos = new ListView();
            lblSelectedFiles = new Label();
            btnClear = new Button();
            btnExit = new Button();
            lblConvertTo = new Label();
            cmbExtension = new ComboBox();
            SuspendLayout();
            // 
            // btnSelectPhotos
            // 
            btnSelectPhotos.Location = new Point(12, 273);
            btnSelectPhotos.Name = "btnSelectPhotos";
            btnSelectPhotos.Size = new Size(120, 25);
            btnSelectPhotos.TabIndex = 1;
            btnSelectPhotos.Text = "Select &Photos";
            btnSelectPhotos.UseVisualStyleBackColor = true;
            btnSelectPhotos.Click += btnAddFiles_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(167, 333);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(120, 25);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "&Develop!";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // ofdOriginalPhotos
            // 
            ofdOriginalPhotos.Multiselect = true;
            ofdOriginalPhotos.Title = "\"Browse Photos\"";
            // 
            // lvSelectedPhotos
            // 
            lvSelectedPhotos.Alignment = ListViewAlignment.Left;
            lvSelectedPhotos.Location = new Point(12, 27);
            lvSelectedPhotos.Name = "lvSelectedPhotos";
            lvSelectedPhotos.Size = new Size(275, 240);
            lvSelectedPhotos.TabIndex = 4;
            lvSelectedPhotos.UseCompatibleStateImageBehavior = false;
            lvSelectedPhotos.View = View.List;
            // 
            // lblSelectedFiles
            // 
            lblSelectedFiles.AutoSize = true;
            lblSelectedFiles.ForeColor = Color.Black;
            lblSelectedFiles.Location = new Point(12, 9);
            lblSelectedFiles.Name = "lblSelectedFiles";
            lblSelectedFiles.Size = new Size(77, 15);
            lblSelectedFiles.TabIndex = 5;
            lblSelectedFiles.Text = "Selected Files";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(167, 273);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 25);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(167, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 25);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblConvertTo
            // 
            lblConvertTo.AutoSize = true;
            lblConvertTo.Location = new Point(95, 307);
            lblConvertTo.Name = "lblConvertTo";
            lblConvertTo.Size = new Size(66, 15);
            lblConvertTo.TabIndex = 8;
            lblConvertTo.Text = "Convert to:";
            lblConvertTo.Click += lblConvertTo_Click;
            // 
            // cmbExtension
            // 
            cmbExtension.AutoCompleteMode = AutoCompleteMode.Append;
            cmbExtension.ForeColor = SystemColors.GrayText;
            cmbExtension.FormattingEnabled = true;
            cmbExtension.Items.AddRange(new object[] { "JPG", "PNG" });
            cmbExtension.Location = new Point(167, 304);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(120, 23);
            cmbExtension.TabIndex = 9;
            cmbExtension.Text = "File Format";
            // 
            // frmDarkroom
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            CancelButton = btnExit;
            ClientSize = new Size(302, 450);
            Controls.Add(cmbExtension);
            Controls.Add(lblConvertTo);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblSelectedFiles);
            Controls.Add(lvSelectedPhotos);
            Controls.Add(btnConvert);
            Controls.Add(btnSelectPhotos);
            Name = "frmDarkroom";
            Text = "darkroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectPhotos;
        private Button btnConvert;
        private OpenFileDialog ofdOriginalPhotos;
        private ListView lvSelectedPhotos;
        private Label lblSelectedFiles;
        private Button btnClear;
        private Button btnExit;
        private Label lblConvertTo;
        private ComboBox cmbExtension;
    }
}