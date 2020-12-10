using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select the song
            OpenFileDialog ofd = new OpenFileDialog();

            //code to select multiple files 
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save the name of the track in the file array 
                paths = ofd.FileNames; //save the path of the track in the array
                for (Int64 i = 0; 1 < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //display songs in the list box 
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            //code toi close the app
            this.Close();
        }
    }
}
