using ImageMagick;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms.Design; // used dotnet add package Magick.NET-Q16-AnyCPU --version 13.5.0
using System.IO;
using System.Text;
using System.Collections.Generic;
using static System.Windows.Forms.DataFormats;

namespace darkroom // :3
{
    public partial class frmDarkroom : Form
    {
        private string[] selectedFiles; // used to store filenames for converter
        private List<string> checkedFiles = new List<string>(); // used to store filenames after they are filtered for the correct file extensions
        private List<string> rejectedFiles = new List<string>(); // used to store filenames after they are filtered for the incorrect file extensions
        string outputFilePath; // used to store the location of converted files, iterated through later
        private string[] fileExtensions = { // used for checking file extension
            ".bmp",
            ".jpg",
            ".gif",
            ".jpeg",
            ".png",
            ".tiff",
            ".webp",
            ".ico",
            ".pdf",
            ".psd",
            ".svg",
            ".heic",
            ".pict",
            ".pcd",
            ".pfm",
            ".pbm",
            ".pgm",
            ".ppm",
            ".pam",
            ".exr",
            ".hdr",
            ".tga",
            ".xbm",
            ".xpm"};
        string outputFormat; // used to store the selected output format from the combo box
        string outputFormatEdited; // used to store outputFormat without the period in front of it so it can be parsed and used as a MagickFormat later
        string input; // used in converting the first character of a string to uppercase
        public frmDarkroom()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do not need does nothing!!!!!!
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            if (ofdOriginalPhotos.ShowDialog() == DialogResult.OK) // set multi-select to true in properties since Designer was used
            {
                selectedFiles = ofdOriginalPhotos.FileNames; // retrieves the selected filenames
                foreach (string file in selectedFiles)
                {
                    string extension = Path.GetExtension(file); // stores the extension of each selected file
                    if (fileExtensions.Contains(extension)) // stores accepted files in checkedFiles list
                    {
                        checkedFiles.Add(file);
                    }
                    else // stores rejected files in rejectedFiles list
                    {
                        rejectedFiles.Add(file);
                    }
                }
                foreach (string file in checkedFiles)
                {
                    lvSelectedPhotos.Items.Add(file); // adds file paths to the list in the window

                }
                string message = "darkroom was unable to open the following files: \n";
                if (rejectedFiles.Any()) // prints rejected files in a message box if there are any
                {
                    foreach (string file in rejectedFiles)
                    {
                        message += file + "\n";
                    }
                    MessageBox.Show(message, "Unable to open files.");
                    rejectedFiles.Clear(); // empties rejectedFiles in case the user adds more files again
                }

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (checkedFiles.Any()) // makes sure there are files in checkedFiles
            {
                outputFormat = cmbExtension.Text; // sets outputFormat equal to the selected file extension
                string input = outputFormat.Substring(1); // trims period
                outputFormatEdited = FirstCharToUpper(input); // makes first letter uppercase
                if (!fileExtensions.Contains(outputFormat))  // message box if user types in a format that is UNACCEPTABLE🔥🔥🔥
                {
                    MessageBox.Show("Invalid output format selected.");
                }
                else
                {
                    MagickFormat format = ParseMagickFormat(outputFormatEdited); // uses method to parse file extension as a format
                    Convert(format);
                    ProcessStartInfo psiConvertedFiles = new ProcessStartInfo // process that can open outputFilePath in file explorer
                    {
                        Arguments = "/select, \"" + outputFilePath + "\"",
                        FileName = "explorer.exe"
                    };
                    Process.Start(psiConvertedFiles); // starts process that opens file explorer to the location where the photos were saved
                }

                /*
                if (cmbExtension.Text == "JPG")
                {
                    foreach (string file in checkedFiles)
                    {
                        convertToJPG(file);
                    }
                }
                else if (cmbExtension.Text == "PNG")
                {
                    foreach (string file in checkedFiles)
                    {
                        convertToPNG(file);
                    }
                }
                else
                {
                    foreach (string file in checkedFiles)
                    {
                        convertToJPG(file);
                    }
                }
                */
            }
            else
            {
                MessageBox.Show("No files were selected.");
            }
        }

        private void Convert(MagickFormat format)
        {
            foreach (string file in checkedFiles)
            {
                try
                {
                    ConvertImage(file, format, outputFormat);
                }
                catch (ImageMagick.MagickCorruptImageErrorException)
                {
                    MessageBox.Show("The image " + file + " could not be converted correctly.", "MagickCorruptImageErrorException");
                }
                catch (ImageMagick.MagickDelegateErrorException)
                {
                    MessageBox.Show("The image " + file + " could not be converted.", "MagickDelegateErrorException");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void ConvertImage(string file, MagickFormat format, string outputFormat)
        {
            MagickImage image = new MagickImage(file);
            image.Format = format;
            outputFilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + "darkroom" + outputFormat);
            image.Write(outputFilePath);           
        }

        private static ImageMagick.MagickFormat ParseMagickFormat(string outputFormatTrimmed)
        {
            return (MagickFormat)Enum.Parse(typeof(MagickFormat), outputFormatTrimmed, true);
        }

        public string FirstCharToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return $"{char.ToUpper(input[0])}{input[1..]}";
        }

        /*
        private void convertToBMP(string file)
        {
            MagickImage image = new MagickImage();
            image.Format = MagickFormat.Bmp;
            outputFilePath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".darkroom.jpg");
            image.Write(outputFilePath);
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
        */

        private void btnExit_Click(object sender, EventArgs e) // escape key was also set to do this in properties
        {
            this.Close();
        }

        private void lblConvertTo_Click(object sender, EventArgs e)
        {
            // do not need!!!!
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Clear(selectedFiles); // clears selectedFiles array
                checkedFiles.Clear(); // clears checkedFiles list
                                      // do not need to clear rejectedFiles because it already clears itself in earlier event handler!!!!
                lvSelectedPhotos.Items.Clear(); // clears items in ListView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing to clear!");
            }
        }
    }
}