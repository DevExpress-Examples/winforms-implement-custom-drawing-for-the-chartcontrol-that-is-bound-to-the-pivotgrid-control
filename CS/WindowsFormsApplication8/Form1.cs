using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraCharts;

namespace WindowsFormsApplication8 {
    public partial class Form1 : Form {

        #region Constants & Variables
        static ImageList imgList = new ImageList();

        static string[] seriesArguments = new string[] { 
            "FAR WEST", "GREAT LAKES", "MIDEAST", "NEW ENGLAND", 
            "PLAINS", "ROCKY MOUNTAIN", "SOUTHEAST", "SOUTHWEST" };

        static Color[] seriesColors = new Color[] { 
            Color.Aqua, Color.Aquamarine, Color.BlueViolet, Color.Crimson, 
            Color.DarkOrange, Color.DarkSeaGreen, Color.Green, Color.Indigo };
        #endregion


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
            imgList.Images.AddRange(CreateImages(seriesColors));
            pivotGridControl1.ValueImages = imgList;

        }


        private void pivotGridControl1_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
            if (e.Field == fieldRegion && e.ValueType == PivotGridValueType.Value)
                e.ImageIndex = GetIndexByName(e.Value);
        }

        private void chartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {

            UpdateDrawOptions((BarDrawOptions)e.SeriesDrawOptions);
            UpdateDrawOptions((BarDrawOptions)e.LegendDrawOptions);

        }


        public static void UpdateDrawOptions(BarDrawOptions options) {

            options.FillStyle.FillMode = FillMode.Hatch;
            options.Shadow.Color = Color.Azure;            
        }


        #region Auxilliary Methods
        private Image[] CreateImages(Color[] colors) {
            Image[] images = new Image[colors.Length];
            for (int i = 0; i < colors.Length; i++) {
                images[i] = CreateImage(16, 16, colors[i]);
            }

            return images;
        }

        private Image CreateImage(int width, int height, Color imageColor) {
            Bitmap image = new Bitmap(width, height);

            using (Graphics gfx = Graphics.FromImage(image))
            using (SolidBrush brush = new SolidBrush(imageColor)) {
                gfx.FillRectangle(brush, 0, 0, width, height);
            }

            return (Image)image;
        }

        private static int GetIndexByName(object name) {
            if (name != null)
                for (int i = 0; i < seriesArguments.Length; i++)
                    if (seriesArguments[i] == name.ToString()) return i;

            return -1;
        }
        #endregion

    }
}
