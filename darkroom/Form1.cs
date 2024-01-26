using ImageMagick; // used dotnet add package Magick.NET-Q16-AnyCPU --version 13.5.0

namespace darkroom
{
    public partial class frmDarkroom : Form
    {
        private string[] selectedFiles; // used to store filenames for converter
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
            if (ofdOriginalPhotos.ShowDialog() == DialogResult.OK) // set multi-select to true in properties since Designer was used
            {
                selectedFiles = ofdOriginalPhotos.FileNames; // retrieves the selected filenames
                //foreach(string file in selectedFiles) // testing to make sure files are being grabbed and stored in the array
                //{
                //    MessageBox.Show(file); // shows a message box for every single file selected!!!
                //}
                foreach(string file in selectedFiles)
                {
                    lvSelectedPhotos.Items.Add(file);
                }
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // converts files stored from adding files to the selected file type
            if (selectedFiles != null)
            {
                foreach(string file in selectedFiles)
                {

                }
            }
        }
    }
}