using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen to p: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen to q: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so mu ma hoa  e: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap du lieu can ma hoa: ");
            int m = Convert.ToInt32(Console.ReadLine());

            // Tính n và d
            int n = p * q;
            int phi = (p - 1) * (q - 1);
            int d = ModInverse(e, phi);

            Console.WriteLine($"So mu giai ma d: {d}");

            // Mã hóa bản tin
            int encryptedMessage = Encrypt(m, e, n);
            Console.WriteLine($"Ban ma: {encryptedMessage}");

            // Giải mã bản mã
            int decryptedMessage = Decrypt(encryptedMessage, d, n);
            Console.WriteLine($"Ban tin giai ma: {decryptedMessage}");
        }
        // Hàm tính bản mã
        static int Encrypt(int m, int e, int n)
        {
            return ModPow(m, e, n);
        }

        // Hàm giải mã bản mã
        static int Decrypt(int c, int d, int n)
        {
            return ModPow(c, d, n);
        }

        // Hàm tính a^b mod m
        static int ModPow(int a, int b, int m)
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

        // Hàm tính nghịch đảo modulo
        static int ModInverse(int a, int m)
        {
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            throw new ArithmeticException("No modular inverse exists");
        }

    }
}
