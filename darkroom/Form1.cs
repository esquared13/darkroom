namespace darkroom
{
    public partial class frmDarkroom : Form
    {
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
            openFileDialog1.ShowDialog();
            // select files
            // store files
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // converts files stored from adding files to the selected file type
        }
    }
}