using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_SignAndVerify
{
    public partial class signBt : Form
    {
        public signBt()
        {
            InitializeComponent();
        }

        private void chooseBt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileTb.Text = openFileDialog.FileName;
                string content = File.ReadAllText(openFileDialog.FileName);
                contentTb.Text = content;
            }
        }

        private void signBt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = fileTb.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            int p, q, d;
            if (!int.TryParse(pTb.Text, out p) || !int.TryParse(qTb.Text, out q) || !int.TryParse(keyTb.Text, out d))
            {
                MessageBox.Show("Invalid input for p, q, or d!");
                return;
            }

            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("p and q must be prime numbers!");
                return;
            }

            int n = p * q;
            int phi = (p - 1) * (q - 1);
            int publicKey = FindPublicKey(d, phi);

            string content = File.ReadAllText(filePath);
            int signature = SignMessage(content.GetHashCode(), d, n);

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"\nChu ky: {signature}");
                writer.WriteLine($"Xac nhan: Chu ky hop le !");
            }

            bool verification = VerifySignature(content.GetHashCode(), signature, publicKey, n);
            if (verification)
            {
                MessageBox.Show("Signature verified successfully!");
            }
            else
            {
                MessageBox.Show("Invalid signature!");
            }
        }
        private int FindPublicKey(int d, int phi)
        {
            int e = FindDecryptionExponent(d, phi);
            return e;
        }

        private int FindDecryptionExponent(int d, int phiN)
        {
            int e = 1;
            while (((d * e) % phiN) != 1)
            {
                e++;
            }
            return e;
        }

        private int SignMessage(int message, int d, int n)
        {
            int signedMessage = 1;
            for (int i = 0; i < d; i++)
            {
                signedMessage = (signedMessage * message) % n;
            }
            return signedMessage;
        }

        private bool VerifySignature(int message, int signature, int e, int n)
        {
            int verifiedSignature = 1;
            for (int i = 0; i < e; i++)
            {
                verifiedSignature = (verifiedSignature * signature) % n;
            }
            return (verifiedSignature == message);
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
