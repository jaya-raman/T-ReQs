namespace T_ReQs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainView = new System.Windows.Forms.TabControl();
            this.fileSelectionPage = new System.Windows.Forms.TabPage();
            this.btn_Load = new System.Windows.Forms.Button();
            this.uploadedList = new System.Windows.Forms.ListBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.sortOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.availableFiles = new System.Windows.Forms.CheckedListBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.preferencesPage = new System.Windows.Forms.TabPage();
            this.similarityMeasure = new System.Windows.Forms.TrackBar();
            this.sorensenDistance = new System.Windows.Forms.RadioButton();
            this.JaccardSimilarity = new System.Windows.Forms.RadioButton();
            this.cosineSimilarity = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.preferredDistance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compareSimilarity = new System.Windows.Forms.Button();
            this.RecommendationsPage = new System.Windows.Forms.TabPage();
            this.scoreGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scoreValue = new System.Windows.Forms.Label();
            this.scoreImg = new System.Windows.Forms.PictureBox();
            this.recommendedFiles = new System.Windows.Forms.DataGridView();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDocument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DownloadDocument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.optimalFileName = new System.Windows.Forms.TextBox();
            this.totalResults = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultsPage = new System.Windows.Forms.TabPage();
            this.ComparedFile = new System.Windows.Forms.Label();
            this.SelectedFile = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.downLoadBtn = new System.Windows.Forms.Button();
            this.clipBoardBtn = new System.Windows.Forms.Button();
            this.secondaryTxt = new System.Windows.Forms.TextBox();
            this.primaryTxt = new System.Windows.Forms.TextBox();
            this.MainView.SuspendLayout();
            this.fileSelectionPage.SuspendLayout();
            this.preferencesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.similarityMeasure)).BeginInit();
            this.RecommendationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedFiles)).BeginInit();
            this.ResultsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.Controls.Add(this.fileSelectionPage);
            this.MainView.Controls.Add(this.preferencesPage);
            this.MainView.Controls.Add(this.RecommendationsPage);
            this.MainView.Controls.Add(this.ResultsPage);
            this.MainView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainView.Location = new System.Drawing.Point(2, 3);
            this.MainView.Name = "MainView";
            this.MainView.SelectedIndex = 0;
            this.MainView.Size = new System.Drawing.Size(775, 504);
            this.MainView.TabIndex = 1;
            // 
            // fileSelectionPage
            // 
            this.fileSelectionPage.BackColor = System.Drawing.SystemColors.Control;
            this.fileSelectionPage.Controls.Add(this.btn_Load);
            this.fileSelectionPage.Controls.Add(this.uploadedList);
            this.fileSelectionPage.Controls.Add(this.btn_Upload);
            this.fileSelectionPage.Controls.Add(this.sortOptions);
            this.fileSelectionPage.Controls.Add(this.label2);
            this.fileSelectionPage.Controls.Add(this.History);
            this.fileSelectionPage.Controls.Add(this.availableFiles);
            this.fileSelectionPage.Controls.Add(this.btn_Browse);
            this.fileSelectionPage.Controls.Add(this.filePath);
            this.fileSelectionPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectionPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileSelectionPage.Location = new System.Drawing.Point(4, 35);
            this.fileSelectionPage.Name = "fileSelectionPage";
            this.fileSelectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileSelectionPage.Size = new System.Drawing.Size(767, 465);
            this.fileSelectionPage.TabIndex = 0;
            this.fileSelectionPage.Text = "File Selection";
            this.fileSelectionPage.Click += new System.EventHandler(this.fileSelectionPage_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.AutoEllipsis = true;
            this.btn_Load.BackColor = System.Drawing.Color.LightGray;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Load.Location = new System.Drawing.Point(361, 407);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(103, 36);
            this.btn_Load.TabIndex = 12;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // uploadedList
            // 
            this.uploadedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.uploadedList.FormattingEnabled = true;
            this.uploadedList.ItemHeight = 18;
            this.uploadedList.Location = new System.Drawing.Point(417, 103);
            this.uploadedList.Name = "uploadedList";
            this.uploadedList.Size = new System.Drawing.Size(337, 292);
            this.uploadedList.TabIndex = 10;
            this.uploadedList.SelectedIndexChanged += new System.EventHandler(this.uploadedList_SelectedIndexChanged);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.LightGray;
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Upload.Location = new System.Drawing.Point(650, 17);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(94, 38);
            this.btn_Upload.TabIndex = 9;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // sortOptions
            // 
            this.sortOptions.AutoCompleteCustomSource.AddRange(new string[] {
            "Name",
            "Date"});
            this.sortOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOptions.FormattingEnabled = true;
            this.sortOptions.Items.AddRange(new object[] {
            "Name",
            "Date"});
            this.sortOptions.Location = new System.Drawing.Point(96, 63);
            this.sortOptions.Name = "sortOptions";
            this.sortOptions.Size = new System.Drawing.Size(121, 25);
            this.sortOptions.TabIndex = 8;
            this.sortOptions.SelectedIndexChanged += new System.EventHandler(this.sortOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SortBy";
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.BackColor = System.Drawing.Color.Transparent;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.History.Location = new System.Drawing.Point(570, 68);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(63, 20);
            this.History.TabIndex = 4;
            this.History.Text = "History";
            // 
            // availableFiles
            // 
            this.availableFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableFiles.FormattingEnabled = true;
            this.availableFiles.Location = new System.Drawing.Point(9, 98);
            this.availableFiles.Name = "availableFiles";
            this.availableFiles.Size = new System.Drawing.Size(382, 298);
            this.availableFiles.TabIndex = 3;
            this.availableFiles.SelectedIndexChanged += new System.EventHandler(this.availableFiles_SelectedIndexChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.LightGray;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Browse.Location = new System.Drawing.Point(518, 17);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(104, 38);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // filePath
            // 
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(9, 23);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(483, 26);
            this.filePath.TabIndex = 0;
            // 
            // preferencesPage
            // 
            this.preferencesPage.BackColor = System.Drawing.SystemColors.Control;
            this.preferencesPage.Controls.Add(this.similarityMeasure);
            this.preferencesPage.Controls.Add(this.sorensenDistance);
            this.preferencesPage.Controls.Add(this.JaccardSimilarity);
            this.preferencesPage.Controls.Add(this.cosineSimilarity);
            this.preferencesPage.Controls.Add(this.label12);
            this.preferencesPage.Controls.Add(this.preferredDistance);
            this.preferencesPage.Controls.Add(this.label11);
            this.preferencesPage.Controls.Add(this.label1);
            this.preferencesPage.Controls.Add(this.compareSimilarity);
            this.preferencesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesPage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.preferencesPage.Location = new System.Drawing.Point(4, 35);
            this.preferencesPage.Name = "preferencesPage";
            this.preferencesPage.Padding = new System.Windows.Forms.Padding(3);
            this.preferencesPage.Size = new System.Drawing.Size(767, 465);
            this.preferencesPage.TabIndex = 1;
            this.preferencesPage.Text = "Preferences";
            // 
            // similarityMeasure
            // 
            this.similarityMeasure.BackColor = System.Drawing.Color.DarkGray;
            this.similarityMeasure.Location = new System.Drawing.Point(313, 103);
            this.similarityMeasure.Name = "similarityMeasure";
            this.similarityMeasure.Size = new System.Drawing.Size(202, 45);
            this.similarityMeasure.TabIndex = 9;
            this.similarityMeasure.Scroll += new System.EventHandler(this.similarityMeasure_Scroll);
            // 
            // sorensenDistance
            // 
            this.sorensenDistance.AutoSize = true;
            this.sorensenDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorensenDistance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sorensenDistance.Location = new System.Drawing.Point(318, 300);
            this.sorensenDistance.Name = "sorensenDistance";
            this.sorensenDistance.Size = new System.Drawing.Size(140, 20);
            this.sorensenDistance.TabIndex = 8;
            this.sorensenDistance.TabStop = true;
            this.sorensenDistance.Text = "Sorensen Distance";
            this.sorensenDistance.UseVisualStyleBackColor = true;
            this.sorensenDistance.CheckedChanged += new System.EventHandler(this.sorensenDistance_CheckedChanged);
            // 
            // JaccardSimilarity
            // 
            this.JaccardSimilarity.AutoSize = true;
            this.JaccardSimilarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JaccardSimilarity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.JaccardSimilarity.Location = new System.Drawing.Point(318, 241);
            this.JaccardSimilarity.Name = "JaccardSimilarity";
            this.JaccardSimilarity.Size = new System.Drawing.Size(132, 20);
            this.JaccardSimilarity.TabIndex = 7;
            this.JaccardSimilarity.TabStop = true;
            this.JaccardSimilarity.Text = "Jaccard Similarity";
            this.JaccardSimilarity.UseVisualStyleBackColor = true;
            this.JaccardSimilarity.CheckedChanged += new System.EventHandler(this.JaccardSimilarity_CheckedChanged);
            // 
            // cosineSimilarity
            // 
            this.cosineSimilarity.AutoSize = true;
            this.cosineSimilarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosineSimilarity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cosineSimilarity.Location = new System.Drawing.Point(318, 189);
            this.cosineSimilarity.Name = "cosineSimilarity";
            this.cosineSimilarity.Size = new System.Drawing.Size(224, 20);
            this.cosineSimilarity.TabIndex = 6;
            this.cosineSimilarity.TabStop = true;
            this.cosineSimilarity.Text = "Cosine Similarity (recommended)";
            this.cosineSimilarity.UseVisualStyleBackColor = true;
            this.cosineSimilarity.CheckedChanged += new System.EventHandler(this.cosineSimilarity_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(25, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Preferred Similarity Calculator";
            // 
            // preferredDistance
            // 
            this.preferredDistance.AutoSize = true;
            this.preferredDistance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.preferredDistance.Location = new System.Drawing.Point(526, 113);
            this.preferredDistance.Name = "preferredDistance";
            this.preferredDistance.Size = new System.Drawing.Size(16, 18);
            this.preferredDistance.TabIndex = 4;
            this.preferredDistance.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum Threshold Distance";
            // 
            // compareSimilarity
            // 
            this.compareSimilarity.BackColor = System.Drawing.Color.LightGray;
            this.compareSimilarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.compareSimilarity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.compareSimilarity.Location = new System.Drawing.Point(313, 351);
            this.compareSimilarity.Name = "compareSimilarity";
            this.compareSimilarity.Size = new System.Drawing.Size(99, 36);
            this.compareSimilarity.TabIndex = 0;
            this.compareSimilarity.Text = "Compare";
            this.compareSimilarity.UseVisualStyleBackColor = false;
            this.compareSimilarity.Click += new System.EventHandler(this.compareSimilarity_Click);
            // 
            // RecommendationsPage
            // 
            this.RecommendationsPage.Controls.Add(this.scoreGraph);
            this.RecommendationsPage.Controls.Add(this.scoreValue);
            this.RecommendationsPage.Controls.Add(this.scoreImg);
            this.RecommendationsPage.Controls.Add(this.recommendedFiles);
            this.RecommendationsPage.Controls.Add(this.optimalFileName);
            this.RecommendationsPage.Controls.Add(this.totalResults);
            this.RecommendationsPage.Controls.Add(this.button4);
            this.RecommendationsPage.Controls.Add(this.View);
            this.RecommendationsPage.Controls.Add(this.label8);
            this.RecommendationsPage.Controls.Add(this.label7);
            this.RecommendationsPage.Controls.Add(this.label3);
            this.RecommendationsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommendationsPage.Location = new System.Drawing.Point(4, 35);
            this.RecommendationsPage.Name = "RecommendationsPage";
            this.RecommendationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecommendationsPage.Size = new System.Drawing.Size(767, 465);
            this.RecommendationsPage.TabIndex = 2;
            this.RecommendationsPage.Text = "Recommendations";
            this.RecommendationsPage.UseVisualStyleBackColor = true;
            this.RecommendationsPage.Click += new System.EventHandler(this.RecommendationsPage_Click);
            // 
            // scoreGraph
            // 
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.scoreGraph.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Score";
            this.scoreGraph.Legends.Add(legend2);
            this.scoreGraph.Location = new System.Drawing.Point(-41, 249);
            this.scoreGraph.Name = "scoreGraph";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            series2.LabelBorderWidth = 10;
            series2.Legend = "Score";
            series2.Name = "Series1";
            this.scoreGraph.Series.Add(series2);
            this.scoreGraph.Size = new System.Drawing.Size(786, 178);
            this.scoreGraph.TabIndex = 19;
            this.scoreGraph.Text = "Scores";
            this.scoreGraph.Click += new System.EventHandler(this.scoreGraph_Click);
            // 
            // scoreValue
            // 
            this.scoreValue.AutoSize = true;
            this.scoreValue.Location = new System.Drawing.Point(63, 51);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(0, 20);
            this.scoreValue.TabIndex = 18;
            // 
            // scoreImg
            // 
            this.scoreImg.BackgroundImage = global::T_ReQs.Properties.Resources.scoreImage;
            this.scoreImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreImg.Image = global::T_ReQs.Properties.Resources.scoreImage;
            this.scoreImg.InitialImage = global::T_ReQs.Properties.Resources.scoreImage;
            this.scoreImg.Location = new System.Drawing.Point(13, 40);
            this.scoreImg.Name = "scoreImg";
            this.scoreImg.Size = new System.Drawing.Size(33, 31);
            this.scoreImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreImg.TabIndex = 17;
            this.scoreImg.TabStop = false;
            // 
            // recommendedFiles
            // 
            this.recommendedFiles.AllowUserToAddRows = false;
            this.recommendedFiles.AllowUserToDeleteRows = false;
            this.recommendedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recommendedFiles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recommendedFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.recommendedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recommendedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Score,
            this.DocumentName,
            this.ViewDocument,
            this.DownloadDocument});
            this.recommendedFiles.Location = new System.Drawing.Point(10, 93);
            this.recommendedFiles.Name = "recommendedFiles";
            this.recommendedFiles.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.recommendedFiles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.recommendedFiles.Size = new System.Drawing.Size(704, 153);
            this.recommendedFiles.TabIndex = 16;
            this.recommendedFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recommendedFiles_CellContentClick);
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.ToolTipText = "Click to sort list on Scores";
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "Document Name";
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            this.DocumentName.ToolTipText = "Click to sort list on Document Name";
            // 
            // ViewDocument
            // 
            this.ViewDocument.HeaderText = "View Document";
            this.ViewDocument.Name = "ViewDocument";
            this.ViewDocument.Text = "VIEW";
            this.ViewDocument.ToolTipText = "Click to view the Document";
            this.ViewDocument.UseColumnTextForButtonValue = true;
            // 
            // DownloadDocument
            // 
            this.DownloadDocument.HeaderText = "Download Document";
            this.DownloadDocument.Name = "DownloadDocument";
            this.DownloadDocument.Text = "DOWNLOAD";
            this.DownloadDocument.ToolTipText = "Click to download the Document";
            this.DownloadDocument.UseColumnTextForButtonValue = true;
            // 
            // optimalFileName
            // 
            this.optimalFileName.Location = new System.Drawing.Point(190, 14);
            this.optimalFileName.Name = "optimalFileName";
            this.optimalFileName.Size = new System.Drawing.Size(280, 26);
            this.optimalFileName.TabIndex = 15;
            // 
            // totalResults
            // 
            this.totalResults.AutoSize = true;
            this.totalResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResults.Location = new System.Drawing.Point(166, 430);
            this.totalResults.Name = "totalResults";
            this.totalResults.Size = new System.Drawing.Size(16, 18);
            this.totalResults.TabIndex = 13;
            this.totalResults.Text = "?";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(623, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Download";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.LightGray;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.SystemColors.ControlText;
            this.View.Location = new System.Drawing.Point(504, 8);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(104, 38);
            this.View.TabIndex = 7;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Loaded Results:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Other Recommendations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Most Optimal File:";
            // 
            // ResultsPage
            // 
            this.ResultsPage.Controls.Add(this.ComparedFile);
            this.ResultsPage.Controls.Add(this.SelectedFile);
            this.ResultsPage.Controls.Add(this.textBox3);
            this.ResultsPage.Controls.Add(this.downLoadBtn);
            this.ResultsPage.Controls.Add(this.clipBoardBtn);
            this.ResultsPage.Controls.Add(this.secondaryTxt);
            this.ResultsPage.Controls.Add(this.primaryTxt);
            this.ResultsPage.Location = new System.Drawing.Point(4, 35);
            this.ResultsPage.Name = "ResultsPage";
            this.ResultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsPage.Size = new System.Drawing.Size(767, 465);
            this.ResultsPage.TabIndex = 3;
            this.ResultsPage.Text = "Results";
            this.ResultsPage.UseVisualStyleBackColor = true;
            // 
            // ComparedFile
            // 
            this.ComparedFile.AutoSize = true;
            this.ComparedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparedFile.Location = new System.Drawing.Point(466, 30);
            this.ComparedFile.Name = "ComparedFile";
            this.ComparedFile.Size = new System.Drawing.Size(41, 13);
            this.ComparedFile.TabIndex = 18;
            this.ComparedFile.Text = "label2";
            this.ComparedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedFile
            // 
            this.SelectedFile.AutoSize = true;
            this.SelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFile.Location = new System.Drawing.Point(154, 30);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.Size = new System.Drawing.Size(41, 13);
            this.SelectedFile.TabIndex = 17;
            this.SelectedFile.Text = "label1";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(266, 333);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Visible = false;
            // 
            // downLoadBtn
            // 
            this.downLoadBtn.BackColor = System.Drawing.Color.LightGray;
            this.downLoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLoadBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downLoadBtn.Location = new System.Drawing.Point(422, 371);
            this.downLoadBtn.Name = "downLoadBtn";
            this.downLoadBtn.Size = new System.Drawing.Size(225, 34);
            this.downLoadBtn.TabIndex = 15;
            this.downLoadBtn.Text = "DOWNLOAD FILE";
            this.downLoadBtn.UseVisualStyleBackColor = false;
            this.downLoadBtn.Click += new System.EventHandler(this.downLoadBtn_Click);
            // 
            // clipBoardBtn
            // 
            this.clipBoardBtn.BackColor = System.Drawing.Color.LightGray;
            this.clipBoardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipBoardBtn.Location = new System.Drawing.Point(157, 371);
            this.clipBoardBtn.Name = "clipBoardBtn";
            this.clipBoardBtn.Size = new System.Drawing.Size(212, 34);
            this.clipBoardBtn.TabIndex = 14;
            this.clipBoardBtn.Text = "COPY TO CLIPBOARD";
            this.clipBoardBtn.UseVisualStyleBackColor = false;
            this.clipBoardBtn.Click += new System.EventHandler(this.clipBoardBtn_Click);
            // 
            // secondaryTxt
            // 
            this.secondaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryTxt.Location = new System.Drawing.Point(389, 56);
            this.secondaryTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.secondaryTxt.Multiline = true;
            this.secondaryTxt.Name = "secondaryTxt";
            this.secondaryTxt.ReadOnly = true;
            this.secondaryTxt.Size = new System.Drawing.Size(299, 274);
            this.secondaryTxt.TabIndex = 13;
            // 
            // primaryTxt
            // 
            this.primaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryTxt.Location = new System.Drawing.Point(84, 56);
            this.primaryTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.primaryTxt.Multiline = true;
            this.primaryTxt.Name = "primaryTxt";
            this.primaryTxt.ReadOnly = true;
            this.primaryTxt.Size = new System.Drawing.Size(306, 274);
            this.primaryTxt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 493);
            this.Controls.Add(this.MainView);
            this.Name = "Form1";
            this.Text = "T-ReQs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainView.ResumeLayout(false);
            this.fileSelectionPage.ResumeLayout(false);
            this.fileSelectionPage.PerformLayout();
            this.preferencesPage.ResumeLayout(false);
            this.preferencesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.similarityMeasure)).EndInit();
            this.RecommendationsPage.ResumeLayout(false);
            this.RecommendationsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendedFiles)).EndInit();
            this.ResultsPage.ResumeLayout(false);
            this.ResultsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainView;
        private System.Windows.Forms.TabPage fileSelectionPage;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.ListBox uploadedList;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.ComboBox sortOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.CheckedListBox availableFiles;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TabPage preferencesPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button compareSimilarity;
        private System.Windows.Forms.TabPage RecommendationsPage;
        private System.Windows.Forms.Label totalResults;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ResultsPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label preferredDistance;
        private System.Windows.Forms.RadioButton sorensenDistance;
        private System.Windows.Forms.RadioButton JaccardSimilarity;
        private System.Windows.Forms.RadioButton cosineSimilarity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox optimalFileName;
        private System.Windows.Forms.DataGridView recommendedFiles;
        private System.Windows.Forms.TrackBar similarityMeasure;
        private System.Windows.Forms.PictureBox scoreImg;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
        private System.Windows.Forms.DataGridViewButtonColumn ViewDocument;
        private System.Windows.Forms.DataGridViewButtonColumn DownloadDocument;
        public System.Windows.Forms.Label ComparedFile;
        public System.Windows.Forms.Label SelectedFile;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button downLoadBtn;
        private System.Windows.Forms.Button clipBoardBtn;
        public System.Windows.Forms.TextBox secondaryTxt;
        public System.Windows.Forms.TextBox primaryTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart scoreGraph;
    }
}

