
﻿using System;
using System.Windows.Forms;

namespace Data_Structures
{
    public partial class DataStatisticsForm : Form
    {
        DataStructure dataStructure = null;

        /// <summary>
        /// Upon intialisation, the properties of this form are defined, based on the parameters.
        /// </summary>
        /// <param name="dataStructure">Type of data structure.</param>
        /// <param name="title">Title to be displayed on chart.</param>
        public DataStatisticsForm(DataStructure dataStructure, String title)
        {
            InitializeComponent();

            this.dataStructure = dataStructure;

            DataChart.Titles.Add(title);
            DataChart.ChartAreas[0].Axes[0].Title = "Elements";
            DataChart.ChartAreas[0].Axes[1].Title = "Time(ms)";
            DataChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            DataChart.Series[0].Name = "Get";

            ElementRangeTxt.Text = "10000";

            if (this.dataStructure is SinglyList)
            {
                var chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                DataChart.ChartAreas.Add(chartArea2);

                DataChart.ChartAreas[1].Axes[1].Title = "Time(ms)";
                DataChart.Series.Add("Sort");
                DataChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                DataChart.Series[1].ChartArea = DataChart.ChartAreas[1].Name;
            }

            Show();
        }

        /// <summary>
        /// Begins performing metrics, based on the elements and data structure type provided by the user.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">Object reference of Event argument.</param>
        private void TestBtn_Click(object sender, EventArgs e)
        {
            var rng = new Random();
            var durationTimer = new System.Diagnostics.Stopwatch();
            var elementRange = 10000;

            try
            {
                elementRange = Convert.ToInt32(ElementRangeTxt.Text);
            }
            catch (FormatException e1)
            {
                SummaryTxt.AppendText(e1.ToString() + Environment.NewLine + "Defaulting element range to 10000" + Environment.NewLine);
            }

            durationTimer.Start();
            for (var i = 0; i < elementRange; i++)
                dataStructure.Add(rng.Next(elementRange));

            SummaryTxt.AppendText(elementRange + " elements added in " + Convert.ToString(durationTimer.ElapsedMilliseconds) + "ms.");

            DataChart.Series[0].Points.Clear();

            durationTimer.Reset();
            for (var i = 0; i < elementRange; i++)
            {
                var number = rng.Next(elementRange);

                durationTimer.Start();

                dataStructure.Get(number);

                durationTimer.Stop();

                DataChart.Series[0].Points.Add(durationTimer.ElapsedMilliseconds);
            }
            SummaryTxt.AppendText(Environment.NewLine + elementRange + " elements retrieved in " + Convert.ToString(durationTimer.ElapsedMilliseconds) + "ms.");

            if (dataStructure is SinglyList)
            {
                DataChart.Series[1].Points.Clear();
                var linkedList = (SinglyList)dataStructure;

                durationTimer.Restart();
                linkedList.sort();

                DataChart.Series[1].Points.Add(durationTimer.ElapsedMilliseconds);
                SummaryTxt.AppendText(Environment.NewLine + elementRange + " elements sorted in " + Convert.ToString(durationTimer.ElapsedMilliseconds) + "ms." + Environment.NewLine + Environment.NewLine);
            }

            durationTimer.Stop();
            dataStructure.Clear();
        }

        private void DataStatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void SummaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}