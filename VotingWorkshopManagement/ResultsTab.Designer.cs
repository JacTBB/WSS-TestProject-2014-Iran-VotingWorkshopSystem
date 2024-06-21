namespace VotingWorkshopManagement
{
    partial class ResultsTab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            surveysTable = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.Label();
            txtQuestion = new System.Windows.Forms.Label();
            lblStartDate = new System.Windows.Forms.Label();
            txtStartDate = new System.Windows.Forms.Label();
            lblEndDate = new System.Windows.Forms.Label();
            txtEndDate = new System.Windows.Forms.Label();
            chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)surveysTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResults).BeginInit();
            SuspendLayout();
            // 
            // surveysTable
            // 
            surveysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            surveysTable.Location = new System.Drawing.Point(46, 101);
            surveysTable.Name = "surveysTable";
            surveysTable.RowHeadersWidth = 62;
            surveysTable.RowTemplate.Height = 33;
            surveysTable.Size = new System.Drawing.Size(584, 506);
            surveysTable.TabIndex = 6;
            surveysTable.CellContentClick += surveysTable_CellContentClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(540, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(180, 32);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Survey Results";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(731, 101);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(59, 25);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new System.Drawing.Point(731, 136);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(84, 25);
            lblQuestion.TabIndex = 9;
            lblQuestion.Text = "Question";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new System.Drawing.Point(849, 101);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(59, 25);
            txtName.TabIndex = 10;
            txtName.Text = "Name";
            // 
            // txtQuestion
            // 
            txtQuestion.AutoSize = true;
            txtQuestion.Location = new System.Drawing.Point(849, 136);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new System.Drawing.Size(84, 25);
            txtQuestion.TabIndex = 11;
            txtQuestion.Text = "Question";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(731, 170);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(90, 25);
            lblStartDate.TabIndex = 12;
            lblStartDate.Text = "Start Date";
            // 
            // txtStartDate
            // 
            txtStartDate.AutoSize = true;
            txtStartDate.Location = new System.Drawing.Point(849, 170);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(90, 25);
            txtStartDate.TabIndex = 13;
            txtStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new System.Drawing.Point(731, 206);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(84, 25);
            lblEndDate.TabIndex = 14;
            lblEndDate.Text = "End Date";
            // 
            // txtEndDate
            // 
            txtEndDate.AutoSize = true;
            txtEndDate.Location = new System.Drawing.Point(849, 206);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(84, 25);
            txtEndDate.TabIndex = 15;
            txtEndDate.Text = "End Date";
            // 
            // chartResults
            // 
            chartArea1.Name = "ChartArea1";
            chartResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResults.Legends.Add(legend1);
            chartResults.Location = new System.Drawing.Point(731, 268);
            chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResults.Series.Add(series1);
            chartResults.Size = new System.Drawing.Size(454, 339);
            chartResults.TabIndex = 16;
            chartResults.Text = "chart1";
            // 
            // ResultsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(chartResults);
            Controls.Add(txtEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(lblStartDate);
            Controls.Add(txtQuestion);
            Controls.Add(txtName);
            Controls.Add(lblQuestion);
            Controls.Add(lblName);
            Controls.Add(surveysTable);
            Controls.Add(lblTitle);
            Name = "ResultsTab";
            Text = "ResultsTab";
            ((System.ComponentModel.ISupportInitialize)surveysTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView surveysTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label txtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label txtEndDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
    }
}