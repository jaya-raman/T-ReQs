using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_ReQs
{
    public partial class ResultView : Form
    {
        public ResultView()
        {
            InitializeComponent();
        }

        private void clipBoardBtn_Click(object sender, EventArgs e)
        {
            if (secondaryTxt.SelectedText != "")
                Clipboard.SetDataObject(secondaryTxt.SelectedText);
            else
                Clipboard.SetDataObject(secondaryTxt.Text);

        }

        private void downLoadBtn_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";          

            var result = dialog.ShowDialog(); //shows save file dialog
            if (result == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                var source = new Uri(textBox3.Text);
                webClient.DownloadFileAsync(source, dialog.FileName);
            }

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }

        private void ResultView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
