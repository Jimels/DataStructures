namespace Data_Structures
{
    partial class DataStatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SummaryTxt = new System.Windows.Forms.TextBox();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.ElementRangeTxt = new System.Windows.Forms.TextBox();
            this.TestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryTxt
            // 
            this.SummaryTxt.Location = new System.Drawing.Point(12, 357);
            this.SummaryTxt.Multiline = true;
            this.SummaryTxt.Name = "SummaryTxt";
            this.SummaryTxt.ReadOnly = true;
            this.SummaryTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SummaryTxt.Size = new System.Drawing.Size(482, 72);
            this.SummaryTxt.TabIndex = 1;
            this.SummaryTxt.TextChanged += new System.EventHandler(this.SummaryTxt_TextChanged);
            // 
            // DataChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DataChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DataChart.Legends.Add(legend3);
            this.DataChart.Location = new System.Drawing.Point(12, 12);
            this.DataChart.Name = "DataChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.DataChart.Series.Add(series3);
            this.DataChart.Size = new System.Drawing.Size(630, 326);
            this.DataChart.TabIndex = 2;
            this.DataChart.Text = "chart1";
            this.DataChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary ";
            // 
            // ElementRangeTxt
            // 
            this.ElementRangeTxt.Location = new System.Drawing.Point(500, 357);
            this.ElementRangeTxt.Name = "ElementRangeTxt";
            this.ElementRangeTxt.Size = new System.Drawing.Size(142, 20);
            this.ElementRangeTxt.TabIndex = 4;
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(500, 383);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(142, 46);
            this.TestBtn.TabIndex = 5;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // DataStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.ElementRangeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataChart);
            this.Controls.Add(this.SummaryTxt);
            this.Name = "DataStatisticsForm";
            this.Text = "Metrics";
            this.Load += new System.EventHandler(this.DataStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SummaryTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ElementRangeTxt;
        private System.Windows.Forms.Button TestBtn;
    }
}