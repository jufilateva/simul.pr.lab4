using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chart();
            Balance();
            Rate();
            InitDays();
        }

        const double k = 0.05;
        double rur = 10000;
        int usd = 0;
        ArrayList li = new ArrayList();

        private double Rate() 
        {

            double rate = (double)UDRate.Value;
            Random random = new Random();
            rate = rate * (1 + k * (random.NextDouble() - 0.5));

            return rate;
        }
        private void Balance()
        {
            tRUB.Text = "RUB: " + rur.ToString();
            tUSD.Text = "USD: " + usd.ToString();
        }
        private void InitDays()
        {
            li.Add((double)UDRate.Value);
            for(int i=1; i< (int)UDDays.Value; i++)
            {
                li.Add(Rate());
            }

        }
        private void Chart()
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < li.Count; i++) chart1.Series[0].Points.AddXY(i, li[i]);
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            li.RemoveAt(0);
            li.Add(Rate());
            UDRate.Value = (decimal)Rate();
            Chart();
            Balance();

        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            if (rur >= (int)UDBuy.Value * (double)UDRate.Value)
            {
                rur -= (int)UDBuy.Value * (double)UDRate.Value;
                usd += (int)UDBuy.Value;
                Balance();
            }
        }

        private void bSell_Click(object sender, EventArgs e)
        { 
            if (usd >= (int)UDSell.Value)
            {
                rur += (int)UDSell.Value * (double)UDRate.Value;
                usd -= (int)UDSell.Value;
                Balance();
            }
        }
    }
}
