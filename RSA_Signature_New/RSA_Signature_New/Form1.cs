using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSA_Signature_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateBt_Click(object sender, EventArgs e)
        {
            int p, q, d;
            if (!int.TryParse(pTb.Text, out p) || !IsPrime(p))
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố hợp lệ cho p.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(qTb.Text, out q) || !IsPrime(q))
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố hợp lệ cho q.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(dTb.Text, out d))
            {
                MessageBox.Show("Vui lòng nhập một giá trị số nguyên hợp lệ cho d.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = p * q;

            nTb.Text = n.ToString();

            int phi = (p - 1) * (q - 1);
            phiTb.Text = phi.ToString();

            int publicKey = FindPublicKey(d, phi);
            pubTb.Text = publicKey.ToString();

            priTb.Text = d.ToString();
        }

        private void signBt_Click(object sender, EventArgs e)
        {
            int d, n;
            if (!int.TryParse(dTb.Text, out d) || !int.TryParse(nTb.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập giá trị nguyên hợp lệ cho d và n.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int message;
            if (!int.TryParse(messageTb.Text, out message))
            {
                MessageBox.Show("Vui lòng nhập một giá trị nguyên hợp lệ cho thông điệp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int signature = Sign(message, d, n);
            signTb.Text = signature.ToString();
        }

        private void verifyBt_Click(object sender, EventArgs e)
        {
            int message, signature, n, publicKey;
            if (!int.TryParse(messageTb.Text, out message) || !int.TryParse(signTb.Text, out signature) ||
                !int.TryParse(nTb.Text, out n) || !int.TryParse(pubTb.Text, out publicKey))
            {
                MessageBox.Show("Vui lòng nhập các giá trị nguyên hợp lệ cho thông điệp, chữ ký, n và public key.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool verification = Verify(message, signature, n, publicKey);
            MessageBox.Show(verification ? "Chữ ký hợp lệ !" : "Chữ ký không hợp lệ !", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int FindPublicKey(int d, int phi)
        {
            int e = 2;
            while (true)
            {
                if ((e * d) % phi == 1)
                {
                    return e;
                }
                e++;
            }
        }

        private int Sign(int message, int d, int n)
        {
            return ModPow(message, d, n);
        }

        private bool Verify(int message, int signature, int n, int e)
        {
            int decrypted = ModPow(signature, e, n);
            return decrypted == message;
        }

        private int ModPow(int baseNumber, int exponent, int modulus)
        {
            int result = 1;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                {
                    result = (result * baseNumber) % modulus;
                }
                baseNumber = (baseNumber * baseNumber) % modulus;
                exponent /= 2;
            }
            return result;
        }
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

}
