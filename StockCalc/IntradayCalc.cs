using System.Text.RegularExpressions;

namespace StockCalc
{
    public partial class IntradayCalc : Form
    {
        public IntradayCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textboxClick(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = Regex.Replace(textBox1.Text, "[^0-9.]", "");
                    if(!string.IsNullOrEmpty(textBox1.Text))
                    {
                        double ltp = Convert.ToDouble(Regex.Replace(textBox1.Text, "[^0-9.]", ""));
                        GenerateResult(ltp);
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.SelectionLength = 0;
                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private double CaculatePercent(double num, int percent)
        {
            return Math.Round(((num * percent * 0.2) / 100) + num,2);
        }

        private void GenerateResult(double ltp)
        {
            label5.Text =CaculatePercent(ltp, 1).ToString();
            label8.Text = CaculatePercent(ltp, 2).ToString();
            label9.Text = CaculatePercent(ltp, 3).ToString();
            label10.Text = CaculatePercent(ltp, 5).ToString();
            label11.Text = CaculatePercent(ltp, 10).ToString();
            label12.Text = CaculatePercent(ltp, 15).ToString();
            label14.Text = CaculatePercent(ltp, 20).ToString();
            labelNeg1.Text = CaculatePercent(ltp, -1).ToString();
            labelNeg2.Text = CaculatePercent(ltp, -2).ToString();
            labelNeg3.Text = CaculatePercent(ltp, -3).ToString();
            labelNeg4.Text = CaculatePercent(ltp, -4).ToString();
            labelNeg5.Text = CaculatePercent(ltp, -5).ToString();
            labelNeg6.Text = CaculatePercent(ltp, -7).ToString();
            labelNeg7.Text = CaculatePercent(ltp, -10).ToString();
        }
    }
}