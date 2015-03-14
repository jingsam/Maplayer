using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Maplayer
{
    public partial class FormMain : Form
    {
        #region Member
        private string _csvPath;
        private IEnumerator<string> _datas;
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
            if (!File.Exists(fileName)) return;

            _csvPath = fileName;
            picMap.Image = null;
            this.Text = @"Maplayer - " + fileName;

            string[] lines = File.ReadAllLines(fileName);
            var headers = lines.First();
            CreateSeries(headers);
            _datas = lines.Skip(1).GetEnumerator();

            progress.Value = 0;
            progress.Maximum = lines.Count() - 1;
            txtStep.Text = string.Format("{0}/{1}", progress.Value, progress.Maximum);
        }

        private void CreateSeries(string headers)
        {
            chart1.Series.Clear();

            var query = headers.Split(',').Skip(1);
            foreach (var header in query)
            {
                Series series = new Series
                {
                    Name = header,
                    MarkerStyle = MarkerStyle.Circle,
                    ChartType = SeriesChartType.Spline,
                    BorderWidth = 2
                };
                chart1.Series.Add(series);
            }
        }

        private void UpdateChart()
        {
            if (_datas == null) return;

            if (_datas.MoveNext())
            {
                var data = _datas.Current.Split(',');
                int x = int.Parse(data[0]);
                for (int i = 1; i < data.Count(); i++)
                {
                    double y = double.Parse(data[i]);
                    chart1.Series[i - 1].Points.AddXY(x, y);
                }

                progress.Value++;
                txtStep.Text = string.Format("{0}/{1}", progress.Value, progress.Maximum);
            }
        }

        private void UpdateMap()
        {
            string path = string.Format("{0}\\{1}.tif",
                Path.GetDirectoryName(_csvPath), progress.Value);
            if (File.Exists(path))
            {
                picMap.Image = CreateImage(path);
                picMap.Refresh();
            }
        }

        private Color GetColor(int value)
        {
            Color color;
            switch (value)
            {
                case 0:
                    color = btn0.BackColor;
                    break;
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
                default:
                    color = btnDefault.BackColor;
                    break;
            }

            return color;
        }

        private void PiantColor(Bitmap bitmap, int[] data)
        {
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * bitmap.Height;
            byte[] rgbValues = new byte[numBytes];

            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int value = data[i + j * bitmap.Width];
                    int index = i * 3 + j * bmpData.Stride;
                    Color color = GetColor(value);
                    rgbValues[index] = color.B;
                    rgbValues[index + 1] = color.G;
                    rgbValues[index + 2] = color.R;
                }
            }
            Marshal.Copy(rgbValues, 0, ptr, numBytes);

            bitmap.UnlockBits(bmpData);
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

        private void Play()
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                itemPlay.Text = "Pause";
                btnPlay.Image = Properties.Resources.button_pause_blue;
            }
        }

        private void Pause()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                itemPlay.Text = "Play";
                btnPlay.Image = Properties.Resources.button_play_blue;
            }
        }

        private void PlayOrPause()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                itemPlay.Text = "Play";
                btnPlay.Image = Properties.Resources.button_play_blue;
            }
            else
            {
                timer1.Start();
                itemPlay.Text = "Pause";
                btnPlay.Image = Properties.Resources.button_pause_blue;
            }
        }

        private void StepTo(int step)
        {
            if (step >= progress.Value)
            {
                for (int i = progress.Value + 1; i <= step; i++)
                {
                    timer1_Tick(null, null);
                }
            }
            else
            {
                ReadCsv(_csvPath);
                for (int i = 1; i <= step; i++)
                {
                    timer1_Tick(null, null);
                }
            }
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
                Play();
            }
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMap();
            UpdateChart();
        }

        private void itemPlay_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }

        private void itemStop_Click(object sender, EventArgs e)
        {
            Pause();
            ReadCsv(_csvPath);
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
            PlayOrPause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Pause();
            ReadCsv(_csvPath);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            StepTo(progress.Value - 2);
        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            StepTo(progress.Value + 2);
        }

        private void barSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = barSpeed.Value;
        }
        #endregion //Event
    }
}
