namespace T_ReQs
{
    partial class ResultView
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
            this.downLoadBtn = new System.Windows.Forms.Button();
            this.clipBoardBtn = new System.Windows.Forms.Button();
            this.secondaryTxt = new System.Windows.Forms.TextBox();
            this.primaryTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SelectedFile = new System.Windows.Forms.Label();
            this.ComparedFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downLoadBtn
            // 
            this.downLoadBtn.BackColor = System.Drawing.Color.LightGray;
            this.downLoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLoadBtn.ForeColor = System.Drawing.Color.Black;
            this.downLoadBtn.Location = new System.Drawing.Point(326, 355);
            this.downLoadBtn.Name = "downLoadBtn";
            this.downLoadBtn.Size = new System.Drawing.Size(197, 34);
            this.downLoadBtn.TabIndex = 8;
            this.downLoadBtn.Text = "DOWNLOAD FILE";
            this.downLoadBtn.UseVisualStyleBackColor = false;
            this.downLoadBtn.Click += new System.EventHandler(this.downLoadBtn_Click);
            // 
            // clipBoardBtn
            // 
            this.clipBoardBtn.BackColor = System.Drawing.Color.LightGray;
            this.clipBoardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipBoardBtn.Location = new System.Drawing.Point(79, 355);
            this.clipBoardBtn.Name = "clipBoardBtn";
            this.clipBoardBtn.Size = new System.Drawing.Size(202, 34);
            this.clipBoardBtn.TabIndex = 7;
            this.clipBoardBtn.Text = "COPY TO CLIPBOARD";
            this.clipBoardBtn.UseVisualStyleBackColor = false;
            this.clipBoardBtn.Click += new System.EventHandler(this.clipBoardBtn_Click);
            // 
            // secondaryTxt
            // 
            this.secondaryTxt.Location = new System.Drawing.Point(303, 52);
            this.secondaryTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.secondaryTxt.Multiline = true;
            this.secondaryTxt.Name = "secondaryTxt";
            this.secondaryTxt.Size = new System.Drawing.Size(299, 274);
            this.secondaryTxt.TabIndex = 6;
            // 
            // primaryTxt
            // 
            this.primaryTxt.Location = new System.Drawing.Point(-2, 52);
            this.primaryTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.primaryTxt.Multiline = true;
            this.primaryTxt.Name = "primaryTxt";
            this.primaryTxt.Size = new System.Drawing.Size(306, 274);
            this.primaryTxt.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Visible = false;
            // 
            // SelectedFile
            // 
            this.SelectedFile.AutoSize = true;
            this.SelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFile.Location = new System.Drawing.Point(76, 26);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.Size = new System.Drawing.Size(41, 13);
            this.SelectedFile.TabIndex = 10;
            this.SelectedFile.Text = "label1";
            this.SelectedFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComparedFile
            // 
            this.ComparedFile.AutoSize = true;
            this.ComparedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparedFile.Location = new System.Drawing.Point(371, 26);
            this.ComparedFile.Name = "ComparedFile";
            this.ComparedFile.Size = new System.Drawing.Size(41, 13);
            this.ComparedFile.TabIndex = 11;
            this.ComparedFile.Text = "label2";
            // 
            // ResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 408);
            this.Controls.Add(this.ComparedFile);
            this.Controls.Add(this.SelectedFile);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.downLoadBtn);
            this.Controls.Add(this.clipBoardBtn);
            this.Controls.Add(this.secondaryTxt);
            this.Controls.Add(this.primaryTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultView";
            this.ShowIcon = false;
            this.Text = "View Similarity";
            this.Load += new System.EventHandler(this.ResultView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downLoadBtn;
        private System.Windows.Forms.Button clipBoardBtn;
        public System.Windows.Forms.TextBox secondaryTxt;
        public System.Windows.Forms.TextBox primaryTxt;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label SelectedFile;
        public System.Windows.Forms.Label ComparedFile;
    }
}