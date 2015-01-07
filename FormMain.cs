using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;


namespace Maplayer
{
    public partial class FormMain : Form
    {
        #region Member
        private string _csvPath;
        private CsvReader _csv;
        private DataTable _series;
        private int _count;

        #endregion //Member


        #region Constructor
        public FormMain()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }
        #endregion // Constructor


        #region Property


        #endregion // Property


        #region Method
        private void ReadCsv(String fileName)
        {
            _csv = new CsvReader(new StreamReader(fileName), true);
            string[] headers = _csv.GetFieldHeaders();
            _series = new DataTable();
            foreach (string header in headers)
            {
                _series.Columns.Add(header, typeof (double));
            }

            string lines = File.ReadAllLines(fileName);

            var query = lines.Select(line => line.Split(',').ToArray());

            chart1.DataBindTable(_series);

            _count = 0;
            this.Text = @"Maplayer - " + fileName;
        }

        private void UpdateMap()
        {
            picMap.Refresh();

        }

        private void UpdateChart()
        {
            chart1.DataBindTable(_csv);
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
            PiantColor(bitmap, data);

            return bitmap;
        }
        #endregion


        #region Event
        private void itemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Log file (*.csv)|*.csv|All File (*.*)|*.*";
            DialogResult dlgResult = dialog.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                ReadCsv(dialog.FileName);
            }
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Stop();
                return;


            UpdateMap();
            UpdateChart();
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
                grpLegend.Show();
            }
            else
            {
                grpLegend.Hide();
            }
        }

        private void itemChart_Click(object sender, EventArgs e)
        {
            if (itemChart.Checked)
            {
                grpChart.Show();
            }
            else
            {
                grpChart.Hide();
            }
        }

        private void itemStatus_Click(object sender, EventArgs e)
        {
            if (itemStatus.Checked)
            {
                grpStatus.Show();
            }
            else
            {
                grpStatus.Hide();
            }
        }

        private void itemFullScreen_Click(object sender, EventArgs e)
        {
            if (itemFullScreen.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var button = sender as Button;
                if (button != null) button.BackColor = dialog.Color;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Tag.ToString() == "play")
            {
                timer1.Start();
                btnPlay.Image = Properties.Resources.button_pause_blue;
                btnPlay.Tag = "pause";
            }
            else
            {
                timer1.Stop();
                btnPlay.Image = Properties.Resources.button_play_blue;
                btnPlay.Tag = "play";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            barSpeed.Value += barSpeed.SmallChange;
        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            barSpeed.Value -= barSpeed.SmallChange;
        }

        private void barSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = barSpeed.Value;
        }
        #endregion //Event
    }
}
