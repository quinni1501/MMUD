using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal_Signature_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void signBt_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(pTb.Text);
            int alpha = Convert.ToInt32(alphaTb.Text);
            int a = Convert.ToInt32(aTb.Text);
            int k = Convert.ToInt32(kTb.Text);
            int x = Convert.ToInt32(xTb.Text);

            int beta = CalculateBeta(alpha, a, p);
            pubTb.Text = beta.ToString();

            int[] signature = Sign(p, alpha, a, k, x);
            y1Tb.Text = signature[0].ToString();
            y2Tb.Text = signature[1].ToString();
        }

        private void verifyBt_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(pTb.Text);
            int alpha = Convert.ToInt32(alphaTb.Text);
            int beta = Convert.ToInt32(pubTb.Text);
            int y1 = Convert.ToInt32(y1Tb.Text);
            int y2 = Convert.ToInt32(y2Tb.Text);
            int x = Convert.ToInt32(xTb.Text);

            bool verified = Verify(p, alpha, beta, y1, y2, x);
            if (verified)
            {
                MessageBox.Show("Chữ ký hợp lệ !");
            }
            else
            {
                MessageBox.Show("Chữ ký không hợp lệ !");
            }
        }
        private int CalculateBeta(int alpha, int a, int p)
        {
            return ModPow(alpha, a, p);
        }

        private int[] Sign(int p, int alpha, int a, int k, int x)
        {
            int y1 = ModPow(alpha, k, p);
            int kInverse = ModInverse(k, p - 1);
            int y2 = ((x - a * y1) * kInverse) % (p - 1);
            if (y2 < 0)
            {
                y2 += (p - 1);
            }
            return new int[] { y1, y2 };
        }

        private bool Verify(int p, int alpha, int beta, int y1, int y2, int x)
        {
            int left = (ModPow(beta, y1, p) * ModPow(y1, y2, p)) % p;
            int right = ModPow(alpha, x, p);
            return left == right;
        }

        private int ModPow(int a, int b, int m)
        {
            if (b == 0)
                return 1;
            long t = ModPow(a, b / 2, m);
            long c = (t * t) % m;
            if (b % 2 == 0)
                return (int)c;
            else
                return (int)((c * a) % m);
        }

        private int ModInverse(int a, int m)
        {
            int m0 = m;
            int y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                int q = a / m;
                int t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }
    }
}
