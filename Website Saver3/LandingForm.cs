using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Website_Saver3
{
    public partial class LandingForm : Form
    {

        public static string url = "";
        public static string directory = "";

        public LandingForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            url = URLInputBox.Text;
            directory = DownloadToInputBox.Text;
            LoadingForm loadingform = new LoadingForm();
            loadingform.Show();
        }

        private void URLInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DownloadToInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
