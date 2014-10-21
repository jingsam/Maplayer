using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

using ZedGraph;


namespace MapPlayer
{
    public partial class FormMain : Form
    {
        #region Member
        public string Log;

        private PointPairList _points;

        private XmlNodeList _iters;

        private int _count = 0;
        #endregion //Member


        #region Constructor
        public FormMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            InitControl();
        }
        #endregion // Constructor


        #region Property


        #endregion // Property


        #region Method
        private void InitControl()
        {
            // Set transparent background
            graph.Parent = picMap;
            graph.GraphPane.Fill.Color = Color.Transparent;
            graph.MasterPane.Fill.IsVisible = false;
            graph.GraphPane.Chart.Fill.IsVisible = false;

            GraphPane myPane = graph.GraphPane;
            myPane.XAxis.Title.Text = "Generation";
            myPane.XAxis.Title.FontSpec.Size = 20;
            myPane.YAxis.Title.Text = "Fitness";
            myPane.YAxis.Title.FontSpec.Size = 20;
            myPane.Title.IsVisible = false;
            myPane.Legend.IsVisible = false;

            _points = new PointPairList();
            myPane.AddCurve("进程1", _points, Color.Red, SymbolType.Circle);
        }

        private bool ReadLog(String fileName)
        {
            try
            {
                this.Log = fileName;

                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                XmlElement root = doc.DocumentElement;
                _iters = root.GetElementsByTagName("iter");

                RefreshMap();
                RefreshCurve();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private Color GetColor(int value)
        {
            Color color;
            switch (value)
            {
                case 1:
                    color = btn1.BackColor;
                    break;
                case 2:
                    color = btn2.BackColor;
                    break;
                case 3:
                    color = btn3.BackColor;
                    break;
                case 4:
                    color = btn4.BackColor;
                    break;
                case 5:
                    color = btn5.BackColor;
                    break;
                case 6:
                    color = btn6.BackColor;
                    break;
                case 7:
                    color = btn7.BackColor;
                    break;
                case 8:
                    color = btn8.BackColor;
                    break;
                case 9:
                    color = btn9.BackColor;
                    break;
                case 10:
                    color = btn10.BackColor;
                    break;
                default:
                    color = btnDefault.BackColor;
                    break;
            }

            return color;
        }

        private void PiantColor(Bitmap bitmap, int[] data)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int value = data[i + j * bitmap.Width];

                    Color color = GetColor(value);
                    bitmap.SetPixel(i, j, color);
                }
            }
        }

        private Bitmap CreateImage(string fileName)
        {
            int width = GDALRead.GetXSize(fileName);
            int height = GDALRead.GetYSize(fileName);
            Bitmap bitmap = new Bitmap(width, height);

            int[] data = GDALRead.ReadIntDataset(fileName);
            this.PiantColor(bitmap, data);

            return bitmap;
        }

        private void RefreshMap()
        {
            XmlNode nodeIter = _iters[_count];
            _count++;

            // show generation
            XmlElement elemGen = nodeIter.SelectSingleNode("gen") as XmlElement;
            txtGeneration.Text = elemGen.InnerText;

            // show fitness
            XmlElement elemFitness = nodeIter.SelectSingleNode("fitness") as XmlElement;
            txtFitness.Text = elemFitness.InnerText;

            // show map
            XmlElement elemFile = nodeIter.SelectSingleNode("file") as XmlElement;
            String fileName = Path.GetDirectoryName(this.Log) + @"\" + elemFile.InnerText;
            if (! File.Exists(fileName)) return;

            picMap.Image = this.CreateImage(fileName);
            picMap.Refresh();

        }

        private void RefreshCurve()
        {
            // Add a node of the curve
            double dGeneration = Double.Parse(txtGeneration.Text);
            double dFitness = Double.Parse(txtFitness.Text);
            _points.Add(dGeneration, dFitness);
            
            graph.AxisChange();
            graph.Refresh();
        }
        #endregion


        #region Event
        private void itemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Log file (*.xml)|*.xml|All File (*.*)|*.*";
            DialogResult dlgResult = myDialog.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                if (!ReadLog(myDialog.FileName))
                {
                    MessageBox.Show("Failed to load " + myDialog.FileName);
                }
            }
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_count >= _iters.Count)
            {
                timer1.Stop();
                return;
            }

            RefreshMap();
            RefreshCurve();
        }

        private void itemStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void itemPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void itemStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _count = 0;
        }

        private void itemLegend_Click(object sender, EventArgs e)
        {
            if (itemLegend.Checked)
            {
                this.grpLegend.Show();
            }
            else
            {
                this.grpLegend.Hide();
            }
        }

        private void itemGraph_Click(object sender, EventArgs e)
        {
            if (itemGraph.Checked)
            {
                this.graph.Show();
            }
            else
            {
                this.graph.Hide();
            }
        }

        private void itemStatus_Click(object sender, EventArgs e)
        {
            if (itemStatus.Checked)
            {
                this.grpStatus.Show();
            }
            else
            {
                this.grpStatus.Hide();
            }
        }

        private void itemFullScreen_Click(object sender, EventArgs e)
        {
            if (itemFullScreen.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = dialog.Color;
            }
        }
        #endregion //Event
    }
}
