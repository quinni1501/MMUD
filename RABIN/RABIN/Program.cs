using System;

namespace RABIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = GenerateKeys();
            int n = keys[0]; // Khóa công khai
            int privateKey = keys[1]; // Khóa bí mật

            Console.WriteLine("Khoa cong khai: " + n);
            Console.WriteLine("Khoa bi mat: " + privateKey);

            Console.WriteLine("Nhap ban tin can ma hoa :");
            int message = int.Parse(Console.ReadLine());

            int ciphertext = Encrypt(message, n); // Mã hóa bản tin

            Console.WriteLine("Ban tin da ma hoa: " + ciphertext);

            int decryptedMessage = Decrypt(ciphertext, keys[1], keys[2], n); // Giải mã bản mã
            Console.WriteLine("Ban ma da giai ma: " + decryptedMessage);
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        // Hàm tìm nghịch đảo theo modulo
        static int ModInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }
            return 1;
        }

        // Hàm tạo khóa
        static int[] GenerateKeys()
        {
            int[] keys = new int[2];
            Random rand = new Random();
            int p, q, n;

            do
            {
                Console.WriteLine("NNhap so nguyen to p:");
                p = int.Parse(Console.ReadLine());
            } while (!IsPrime(p));

            do
            {
                Console.WriteLine("Nhap so nguyen to q:");
                q = int.Parse(Console.ReadLine());
            } while (!IsPrime(q));

            n = p * q; // Tính n
            keys[0] = n; // Khóa công khai
            keys[1] = p * q; // Khóa bí mật

            return keys;
        }

        // Hàm mã hóa
        static int Encrypt(int message, int n)
        {
            return (int)Math.Pow(message, 2) % n;
        }

        // Hàm giải mã
        static int Decrypt(int ciphertext, int p, int q, int n)
        {
            int m1 = (int)(Math.Pow(ciphertext, (p + 1) / 4) % p);
            int m2 = (int)(Math.Pow(ciphertext, (q + 1) / 4) % q);
            int y_p = ModInverse(p, q);
            int y_q = ModInverse(q, p);
            int d1 = (y_p * p * m2 + y_q * q * m1) % (p * q);
            int d2 = n - d1;
            int d3 = -d1 % n;
            int d4 = -d2 % n;
            return d1;
        }
    }
}
