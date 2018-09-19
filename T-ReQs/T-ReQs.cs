using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
//using System.Linq.Enumerable;

namespace T_ReQs
{
    public partial class Form1 : Form
    {
        private string FiletobeCompared = "";
        string[] availableFile;
        decimal preferredDist = 0.0M;
        // the path to dynamicaly load the documents in the history section
        string uploadsPath = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName).FullName, @"Uploads");
        // the path to  dynamicaly load all the available set of base documents for comparsion
        string dataPath = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName).FullName, @"Data");
        
        public string PrimaryPath { get; set; }
        public string SecondaryPath { get; set; }
        public string DownloadPath { get; set; }

        public Form1()
        {
            InitializeComponent();
            initializeList();
            btn_Upload.Enabled = false;
            compareSimilarity.Enabled = false;
            customizeGrid();
        }
        private void initializeList()
        {
            //list the available Files
            DirectoryInfo dinfo = new DirectoryInfo(dataPath);
            FileInfo[] files = dinfo.GetFiles();
            foreach (FileInfo file in files)
                availableFiles.Items.Add(file.Name);

            // list the uploaded files
            DirectoryInfo dinfo1 = new DirectoryInfo(uploadsPath);
            FileInfo[] files1 = dinfo1.GetFiles();
            foreach (FileInfo file1 in files1)
                uploadedList.Items.Add(file1.Name);
            btn_Load.Enabled = false;
            ResultsPage.Enabled = false;
        }

        private void customizeGrid()
        {
            //customization of the Data grid in recommendations view
            DataGridViewButtonColumn viewButton = (DataGridViewButtonColumn)recommendedFiles.Columns["ViewDocument"];
            viewButton.FlatStyle = FlatStyle.Popup;
            viewButton.DefaultCellStyle.ForeColor = Color.Black;
            viewButton.DefaultCellStyle.BackColor = Color.LightGray;
            DataGridViewButtonColumn downloadButton = (DataGridViewButtonColumn)recommendedFiles.Columns["DownloadDocument"];
            downloadButton.FlatStyle = FlatStyle.Popup;
            downloadButton.DefaultCellStyle.ForeColor = Color.Black;
            downloadButton.DefaultCellStyle.BackColor = Color.LightGray;            
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            //Browse a new document for upload
            OpenFileDialog browseRequirement = new OpenFileDialog();
            if (browseRequirement.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = browseRequirement.FileName;
                btn_Upload.Enabled = true;
            }
        }
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            //Add the browsed document to upload path so that it becmes vailable in history
            string sourceFile = filePath.Text;
            string fileName = Path.GetFileName(sourceFile);
            string destinationFile = Path.Combine(uploadsPath, fileName);
            System.IO.File.Copy(sourceFile, destinationFile, true);
            FileInfo uploadedFile = new FileInfo(sourceFile);
            uploadedList.Items.Add(fileName);
        }

        private void sortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sort available documents by data and file name
            DirectoryInfo dinfo = new DirectoryInfo(dataPath);
            if (sortOptions.SelectedItem.ToString() == "Name")
            {
                               FileInfo[] files = dinfo.GetFiles().OrderBy(f => f.FullName).ToArray();
                availableFiles.Items.Clear();
                foreach (FileInfo file in files)
                    availableFiles.Items.Add(file.Name);
            }
            else if (sortOptions.SelectedItem.ToString() == "Date")
            {
                FileInfo[] files = dinfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();
                availableFiles.Items.Clear();
                foreach (FileInfo file in files)
                    availableFiles.Items.Add(file.Name);
            }
        }

        private void availableFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            allowPreferenceView();
        }
        private void uploadedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            allowPreferenceView();
        }
        public void allowPreferenceView()
        {
            // allow reference view only if file selections are made
            if ((availableFiles.SelectedIndex != -1) && (uploadedList.SelectedIndex != -1))
                btn_Load.Enabled = true;
            else
                btn_Load.Enabled = false;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            MainView.SelectedIndex = 1;
        }
        private void similarityMeasure_Scroll(object sender, EventArgs e)
        {
            // allow recommendation view only if similarity threshold and similarity method is specified
            enableRecommendtionsView();
            preferredDist = (decimal)similarityMeasure.Value / 10;
            preferredDistance.Text = preferredDist.ToString();
        }
        private void enableRecommendtionsView()
        {
            if ((cosineSimilarity.Checked || JaccardSimilarity.Checked || sorensenDistance.Checked) && similarityMeasure.Value != 0)
                compareSimilarity.Enabled = true;
        }
        private void compareSimilarity_Click(object sender, EventArgs e)
        {
            availableFile = new string[availableFiles.CheckedItems.Count];
            //Create the documnenst to be compared as lists
            Dictionary<string, double> distValues = new Dictionary<string, double>();
            FiletobeCompared = Path.Combine(uploadsPath, uploadedList.SelectedItem.ToString());
            string FileToCompare = File.ReadAllText(FiletobeCompared);
            List<String> document1 = new List<string>(FileToCompare.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
           
            for (int i = 0; i < availableFiles.CheckedItems.Count; i++)
            {
                //MessageBox.Show(file.ToString());
                string filePath = Path.Combine(dataPath, availableFiles.CheckedItems[i].ToString());
                String baseDocument = File.ReadAllText(filePath, Encoding.ASCII);                
                List<String> document2 = new List<string>(baseDocument.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
                //Call the Similarity Calculation function as preferred by user
                double distValue = calculateSimilarity(document1, document2);
                distValues.Add(availableFiles.CheckedItems[i].ToString(), distValue);
            }
            
            findRecommendations(distValues);
            displayGraph();
        }
        private double calculateSimilarity(List<string> document1, List<string> document2)
        {
            // call the class corresponsding to the similarity function chosen by the user
            double distance = 0.0;
            if (cosineSimilarity.Checked)
                distance = CosineSimilarity.cosineDistance(document1, document2);
            else if (JaccardSimilarity.Checked)
                distance = otherDistances.calculateJaccard(document1, document2);
            else if (sorensenDistance.Checked)
                distance = otherDistances.calculateSorensenDice(document1, document2);
            
            else
                throw new Exception("Any one distance measure has to be selected");

            return distance;
        }
        public void findRecommendations(Dictionary<string, double> distValues)
        {
            int totalNoOfResults = 0;
            MainView.SelectedIndex = 2;
            // Remove previosuly appended documents if any
            recommendedFiles.Rows.Clear();
            recommendedFiles.Refresh();
            scoreGraph.Series["Series1"].Points.Clear();
            //sort the distance measures
            List <KeyValuePair<string, double>> myList = distValues.ToList();

            myList.Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair1.Value.CompareTo(pair2.Value);
                }
            );


            KeyValuePair<string, double> last = myList.Last();
            //display the most optimal value
            optimalFileName.Text = last.Key.ToString();
            scoreValue.Text = "Score:" + Math.Round((decimal)last.Value, 1).ToString();

            foreach (KeyValuePair<string, double> entry in myList)
            {
                if (Math.Round((decimal)entry.Value, 2) >= preferredDist)
                {
                    string score = "Score:" + Math.Round((decimal)entry.Value,3).ToString();
                    recommendedFiles.Rows.Add(score,entry.Key);
                    scoreGraph.Series["Series1"].Points.AddXY(entry.Key, entry.Value);
                    totalNoOfResults++;
                }
            }
            totalResults.Text = totalNoOfResults.ToString();
            
        }
        public void displayGraph()
        {

        }
        private void cosineSimilarity_CheckedChanged(object sender, EventArgs e)
        {
            enableRecommendtionsView();
        }

        private void JaccardSimilarity_CheckedChanged(object sender, EventArgs e)
        {
            enableRecommendtionsView();
        }

        private void sorensenDistance_CheckedChanged(object sender, EventArgs e)
        {
            enableRecommendtionsView();
        }

        private void View_Click(object sender, EventArgs e)
        {
            // Display the documents on selction of View 
            ResultsPage.Enabled = true;
            MainView.SelectedIndex = 3;
            string selectedFile = Path.Combine(dataPath, optimalFileName.Text);
            displayDetails(false,FiletobeCompared, selectedFile, uploadedList.SelectedItem.ToString(), optimalFileName.Text);
        }


        public void displayDetails(bool popup,string primary, string secondary, string primaryFileName, string secondaryFileName)
        {
            string content = File.ReadAllText(@primary);
            PrimaryPath = content;

            string filePath = dataPath;
           
            string doc1content = File.ReadAllText(@secondary);
            SecondaryPath = doc1content;
            
            if (popup)
            {
                ResultView childForm = new ResultView();
                childForm.primaryTxt.Text = PrimaryPath;
                childForm.primaryTxt.Select(0, 0);
                childForm.secondaryTxt.Text = SecondaryPath;
                childForm.textBox3.Text = secondary;
                childForm.SelectedFile.Text = primaryFileName;
                childForm.ComparedFile.Text = secondaryFileName;
                childForm.Show();
            }
            else
            {
                primaryTxt.Text = PrimaryPath;
                primaryTxt.Select(0, 0);
                secondaryTxt.Text = SecondaryPath;
                textBox3.Text = secondary;
                SelectedFile.Text = primaryFileName;
                ComparedFile.Text = secondaryFileName;                

            }
        }

        private void recommendedFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Functionality when recomended files are selected
            if (e.ColumnIndex == recommendedFiles.Columns["ViewDocument"].Index && e.RowIndex >= 0)
            {
                string selectedFileName = recommendedFiles.Rows[e.RowIndex].Cells[1].Value.ToString();
                string selectedFile = Path.Combine(dataPath, selectedFileName);                
               // MessageBox.Show(compareFile);    
               displayDetails(true,FiletobeCompared, selectedFile, uploadedList.SelectedItem.ToString(),selectedFileName);
            }
            if (e.ColumnIndex == recommendedFiles.Columns["DownloadDocument"].Index && e.RowIndex >= 0)
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                var source = new Uri(Path.Combine(dataPath, recommendedFiles.Rows[e.RowIndex].Cells[1].Value.ToString()));

                var result = dialog.ShowDialog(); //shows save file dialog
                if (result == DialogResult.OK)
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(source, dialog.FileName);
                }
            }


        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var source = new Uri(Path.Combine(dataPath, optimalFileName.Text.ToString()));

            var result = dialog.ShowDialog(); //shows save file dialog
            if (result == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadFileAsync(source, dialog.FileName);
            }
        }

        private void clipBoardBtn_Click(object sender, EventArgs e)
        {
            // Copy to clipboard function
            if (secondaryTxt.SelectedText != "")
                  Clipboard.SetDataObject(secondaryTxt.SelectedText);
            else
                Clipboard.SetDataObject(secondaryTxt.Text);

        }

        private void downLoadBtn_Click(object sender, EventArgs e)
        {
            // Download function
            var dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var source = new Uri(textBox3.Text);

            var result = dialog.ShowDialog(); //shows save file dialog
            if (result == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadFileAsync(source, dialog.FileName);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scoreGraph_Click(object sender, EventArgs e)
        {

        }

        private void RecommendationsPage_Click(object sender, EventArgs e)
        {

        }

        private void fileSelectionPage_Click(object sender, EventArgs e)
        {

        }
    }
}
