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
            cmbExportType = new ComboBox();
            ofdOriginalPhotos = new OpenFileDialog();
            lvSelectedPhotos = new ListView();
            SuspendLayout();
            // 
            // btnSelectPhotos
            // 
            btnSelectPhotos.Location = new Point(12, 12);
            btnSelectPhotos.Name = "btnSelectPhotos";
            btnSelectPhotos.Size = new Size(120, 25);
            btnSelectPhotos.TabIndex = 1;
            btnSelectPhotos.Text = "Select &Photos";
            btnSelectPhotos.UseVisualStyleBackColor = true;
            btnSelectPhotos.Click += btnAddFiles_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(264, 12);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(120, 25);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "&Develop!";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // cmbExportType
            // 
            cmbExportType.FormattingEnabled = true;
            cmbExportType.Location = new Point(138, 12);
            cmbExportType.Name = "cmbExportType";
            cmbExportType.Size = new Size(120, 23);
            cmbExportType.TabIndex = 2;
            cmbExportType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ofdOriginalPhotos
            // 
            ofdOriginalPhotos.FileName = "openFileDialog1";
            ofdOriginalPhotos.Multiselect = true;
            ofdOriginalPhotos.Title = "\"Browse Photos\"";
            // 
            // lvSelectedPhotos
            // 
            lvSelectedPhotos.Location = new Point(11, 43);
            lvSelectedPhotos.Name = "lvSelectedPhotos";
            lvSelectedPhotos.Size = new Size(121, 97);
            lvSelectedPhotos.TabIndex = 4;
            lvSelectedPhotos.UseCompatibleStateImageBehavior = false;
            lvSelectedPhotos.UseWaitCursor = true;
            // 
            // frmDarkroom
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(lvSelectedPhotos);
            Controls.Add(cmbExportType);
            Controls.Add(btnConvert);
            Controls.Add(btnSelectPhotos);
            Name = "frmDarkroom";
            Text = "darkroom";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectPhotos;
        private Button btnConvert;
        private ComboBox cmbExportType;
        private OpenFileDialog ofdOriginalPhotos;
        private ListView lvSelectedPhotos;
    }
}