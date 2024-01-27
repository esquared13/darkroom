using ImageMagick;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms.Design; // used dotnet add package Magick.NET-Q16-AnyCPU --version 13.5.0

namespace darkroom
{
    public partial class frmDarkroom : Form
    {
        private string[] selectedFiles; // used to store filenames for converter
        string outputFilePath; // used to store the location of converted files, iterated through later
        // string outputFilePath = @"C:\.jpg"; // test output

        public frmDarkroom()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change a variable that holds what type the file is being converted to
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            // need to add checks for file extension
            // make it so that the file dialog opens in the user's photos folder initially or maybe onedrive photos
            if (ofdOriginalPhotos.ShowDialog() == DialogResult.OK) // set multi-select to true in properties since Designer was used
            {
                selectedFiles = ofdOriginalPhotos.FileNames; // retrieves the selected filenames
                //foreach(string file in selectedFiles) // testing to make sure files are being grabbed and stored in the array
                //{
                //    MessageBox.Show(file); // shows a message box for every single file selected!!!
                //}
                foreach (string file in selectedFiles)
                {
                    lvSelectedPhotos.Items.Add(file);
                }
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // converts files stored from adding files to the selected file type
            // copy to clipboard and message box that says it was copied to clipboard
            // add switch statements for each file ext. in combo box
            
            // validate that combo box is not null
            if (selectedFiles != null)
            {
                if (cmbExtension.Text == "JPG")
                {
                    foreach (string file in selectedFiles)
                    {
                        convertToJPG(file);
                    }
                }
                else if (cmbExtension.Text == "PNG")
                {
                    foreach (string file in selectedFiles)
                    {
                        convertToPNG(file);
                    }
                }
                // default case is jpg

                MessageBox.Show("Files converted successfully.");
               
                ProcessStartInfo psiConvertedFiles = new ProcessStartInfo // process that can open outputFilePath in file explorer
                {
                    Arguments = "/select, \"" + outputFilePath + "\"",
                    FileName = "explorer.exe"
                };
                Process.Start(psiConvertedFiles); // starts process that opens file explorer to the location where the photos were saved
            }
        }

        private void convertToJPG(string file) // convert to jpg
        {
            MagickImage image = new MagickImage(file);
            image.Format = MagickFormat.Jpg;
            outputFilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".darkroom.jpg"); // names converted photos
            image.Write(outputFilePath);
        }

        private void convertToPNG(string file) // convert to png
        {
            MagickImage image = new MagickImage(file);
            image.Format = MagickFormat.Png;
            outputFilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".darkroom.png");
            image.Write(outputFilePath);
        }

        private void btnExit_Click(object sender, EventArgs e) // escape key was also set to do this in properties
        {
            this.Close();
        }

        private void lblConvertTo_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(selectedFiles); // clears selectedFiles array
            lvSelectedPhotos.Items.Clear(); // clears items in ListView
        }
    }
}