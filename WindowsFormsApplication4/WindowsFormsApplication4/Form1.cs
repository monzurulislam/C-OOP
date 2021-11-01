using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        private readonly int _axisMargin = 2;//TODO Why?
        private DashStyle _xAxisDashStyle;
        private DashStyle _yAxisDashStyle;
        private bool _isXAxisLabelEnabled;
        private bool _isYAxisLabelEnabled;
        private bool _isXAxisGridLineEnabled;
        private bool _isYAxisGridLineEnabled;
        private ChartTitle _chartTitle;
        private double _minReference;

        public Form1()
        {
            InitializeComponent();
                chartControl1.SeriesDataMember = "Series";
            var seriesTemplate = chartControl1.SeriesTemplate;
            seriesTemplate.ArgumentDataMember = "Argument";
            seriesTemplate.ValueDataMembers.AddRange("Value");
            seriesTemplate.View = new LineSeriesView();
         //   chartControl1.BoundDataChanged += ChartControl1_BoundDataChanged;
            var series1 = chartControl1.Series[0];
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Circle;
            ((LineSeriesView)series1.View).LineMarkerOptions.Color = Color.Green;
            ((LineSeriesView)series1.View).Color = Color.Blue;
            
            
            _isXAxisLabelEnabled = true;
            _isYAxisLabelEnabled = true;
            InitializeChart();
            XaxisValues.AddRange(new List<double>(){-9,-13,-4,0.0,4,13,9,0});
            YaxisValues.AddRange(new List<double>(){8,6,2,0,0,0,2,6,8});
            ChartTitle1 = new ChartTitle()
            {
                Text = string.Format("{0} {1}", "A", "B"),
                Dock = ChartTitleDockStyle.Top,
                Alignment = StringAlignment.Center,
                Visibility = DefaultBoolean.True,
                WordWrap = true,
                MaxLineCount = 2,
                TextColor = Color.Black,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };;
            LoadChartData();
           
        }
        public List<double> XaxisValues { get; set; }
        public List<double> YaxisValues { get; set; }

        public ViewType CurveViewType { private get; set; }
        public ChartTitle ChartTitle1 { private get; set; }

        public DashStyle XAxisMajorGridLineDashStyle
        {
            set { _xAxisDashStyle = value; }
        }

        public DashStyle YAxisMajorGridLineDashStyle
        {
            set { _yAxisDashStyle = value; }
        }

        public bool IsXAxisLabelEnabled
        {
            set { _isXAxisLabelEnabled = true; }
        }

        public bool IsYAxisLabelEnabled
        {
            set { _isYAxisLabelEnabled = true; }
        }

        public bool IsXAxisGridLineEnabled
        {
            set { _isXAxisGridLineEnabled = true; }
        }

        public bool IsYAxisGridLineEnabled
        {
            set { _isYAxisGridLineEnabled = true; }
        }

        public string XaxisTitle { get; set; }
        public string YaxisTitle { get; set; }

        private void InitializeChart()
        {
            XaxisValues = new List<double>();
            YaxisValues = new List<double>();
        }
        private void LoadChartData()
        {

            var series = new Series();
            var chartSeries = new Series("Curve Series", ViewType.ScatterLine);
            for (var i = 0; i < XaxisValues.Count; i++)
            {
                chartSeries.Points.Add(new SeriesPoint(XaxisValues.ElementAt(i), YaxisValues.ElementAt(i)));
            }

            //var seriesList = new List<Series>();
            //for (int i = 0; i < XaxisValues.Count-1; i++)
            //{
            //    var lineSeries = new Series("Line" + i, ViewType.Line);
            //    lineSeries.Points.Add(new SeriesPoint(XaxisValues.ElementAt(i), YaxisValues.ElementAt(i)));
            //    lineSeries.Points.Add(new SeriesPoint(XaxisValues.ElementAt(i+1), YaxisValues.ElementAt(i+1)));
            //    seriesList.Add(lineSeries);
            //}
            chartControl1.Series.Clear();
            
            chartControl1.SeriesSorting = SortingMode.None;
          
            chartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.Qualitative;
            
            //chartControl1.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Argument;
           // chartControl1.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1;
            chartControl1.Series.Add(chartSeries);
            chartControl1.Series.Add(series);
            //chartControl1.Series.AddRange(seriesList.ToArray());
           // chartControl1.SeriesTemplate.SeriesPointsSorting = SortingMode.Ascending;
           // chartControl1.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Argument;
         //   chartControl1.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1;
         //   chartSeries.CrosshairEnabled = DefaultBoolean.True;
            var diagram = (XYDiagram)chartControl1.Diagram;
            AddChartTile();
            AddChartGridLine(diagram);
            AddChartLabel(diagram);
            SetXAndYAxesTitle(diagram);
            ChartModification(diagram);
            var series1 = chartControl1.Series[0];
            ((ScatterLineSeriesView) series1.View).MarkerVisibility = DefaultBoolean.True;
            ((ScatterLineSeriesView)series1.View).LineMarkerOptions.Color = Color.Green;


        }

        private void ChartModification(XYDiagram diagram)
        {
            //  HideYaxisGridLine(diagram);
            SetChartAxisCrossHairLabelVisibilityOption(diagram);
            XaxisStartFromZero(diagram);
        }

        private void HideYaxisGridLine(XYDiagram diagram)
        {
            diagram.AxisY.GridLines.Visible = false;
        }

        private void SetChartAxisCrossHairLabelVisibilityOption(XYDiagram diagram)
        {
            diagram.AxisX.CrosshairAxisLabelOptions.Visibility = DefaultBoolean.False;
            diagram.AxisY.CrosshairAxisLabelOptions.Visibility = DefaultBoolean.False;
        }

        private void XaxisStartFromZero(XYDiagram diagram)
        {
            diagram.AxisY.WholeRange.SideMarginsValue = 0;
            diagram.AxisX.WholeRange.SideMarginsValue = 0;
            var min = YaxisValues.Min(t => t);
            var max = YaxisValues.Max(t => t);
            var xMin = XaxisValues.Min(t => t);
            var xMax = XaxisValues.Max(t => t);
            var marginy = (max - min) * 0.1;
            var marginX = (xMax - xMin) * 0.1;
            _minReference = Math.Round(min - 1);

            diagram.AxisY.WholeRange.SetMinMaxValues(_minReference, max + marginy);
            diagram.AxisX.WholeRange.SetMinMaxValues(xMin-1, xMax + marginX);
        }

        private void AddChartLabel(XYDiagram diagram)
        {
            diagram.AxisX.Label.Visible = _isXAxisLabelEnabled;
            diagram.AxisY.Label.Visible = _isYAxisLabelEnabled;
        }

        private void AddChartTile()
        {
            chartControl1.Titles.Clear();
            chartControl1.Titles.Add(ChartTitle1);
            chartControl1.Legend.Visibility = DefaultBoolean.False;
        }

        private void AddChartGridLine(XYDiagram diagram)
        {
            diagram.AxisX.GridLines.Visible = _isXAxisGridLineEnabled;
          //  diagram.AxisX.GridLines.LineStyle.DashStyle = _xAxisDashStyle;

            diagram.AxisY.GridLines.Visible = _isYAxisGridLineEnabled;
          //  diagram.AxisY.GridLines.LineStyle.DashStyle = _yAxisDashStyle;
        }

        private void SetXAndYAxesTitle(XYDiagram diagram)
        {
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            diagram.AxisY.Title.Visibility = DefaultBoolean.True;

            diagram.AxisX.Title.Alignment = StringAlignment.Center;
            diagram.AxisX.Title.Text = XaxisTitle;
            diagram.AxisX.Title.TextColor = Color.Black;
            diagram.AxisX.Title.EnableAntialiasing = DefaultBoolean.True;
            diagram.AxisX.Title.Font = new Font("Tahoma", 8, FontStyle.Regular);

            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.Text = YaxisTitle;
            diagram.AxisY.Title.TextColor = Color.Black;
            diagram.AxisY.Title.EnableAntialiasing = DefaultBoolean.True;
            diagram.AxisY.Title.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
    }
}
