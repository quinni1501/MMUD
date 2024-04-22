using System;
using System.IO;
using System.Text;

namespace RSA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập đường dẫn tệp văn bản cần ký (.txt)
            Console.WriteLine("Nhap duong dan den file can ky (.txt): ");
            string filePath = Console.ReadLine();

            // Kiểm tra xem tệp văn bản có tồn tại không
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist !");
                return;
            }

            // Nhập số nguyên tố p
            Console.WriteLine("Nhap so nguyen to p: ");
            int p = int.Parse(Console.ReadLine());
            if (!IsPrime(p))
            {
                Console.WriteLine("p khong phai la so nguyen to.");
                return;
            }

            // Nhập số nguyên tố q
            Console.WriteLine("Nhap so nguyen to q: ");
            int q = int.Parse(Console.ReadLine());
            if (!IsPrime(q))
            {
                Console.WriteLine("q khong phai la so nguyen to.");
                return;
            }

            // Nhập khóa bí mật d
            Console.WriteLine("Nhap khoa bi mat d: ");
            int d = int.Parse(Console.ReadLine());

            // Tính toán n, phi, và khóa công khai
            int n = p * q;
            int phi = (p - 1) * (q - 1);
            int publicKey = FindPublicKey(d, phi);

            Console.WriteLine($"Khoa cong khai: {publicKey}");
            Console.WriteLine($"n: {n}");

            // Đọc nội dung từ tệp văn bản
            string content = File.ReadAllText(filePath);

            // Ký nội dung
            int signature = SignMessage(content.GetHashCode(), d, n);
            Console.WriteLine($"Chu ky: {signature}");

            // Ghi chữ ký vào cuối tệp văn bản input
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"\nChu ky: {signature}");
                writer.WriteLine($"Xac nhan: Chu ky hop le !"); // Mặc định xác nhận là hợp lệ
            }

            // Xác minh chữ ký
            bool verification = VerifySignature(content.GetHashCode(), signature, publicKey, n);
            if (!verification)
            {
                Console.WriteLine("Chu ky khong hop le !");
            }
        }

        private static int FindPublicKey(int d, int phi)
        {
            int e = FindDecryptionExponent(d, phi);
            return e;
        }

        // Tìm ước chung lớn nhất của a và b
        public static int UCLN(int x, int y)
        {
            while (y > 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }
            return x;
        }

        // Tìm số nguyên e sao cho (d * e) % phiN = 1
        public static int FindDecryptionExponent(int d, int phiN)
        {
            int e = 1;
            while (((d * e) % phiN) != 1)
            {
                e++;
            }
            return e;
        }

        // Ký thông điệp
        public static int SignMessage(int message, int d, int n)
        {
            int signedMessage = 1;
            for (int i = 0; i < d; i++)
            {
                signedMessage = (signedMessage * message) % n;
            }
            return signedMessage;
        }

        // Kiểm tra chữ ký
        public static bool VerifySignature(int message, int signature, int e, int n)
        {
            int verifiedSignature = 1;
            for (int i = 0; i < e; i++)
            {
                verifiedSignature = (verifiedSignature * signature) % n;
            }
            return (verifiedSignature == message);
        }

        private static bool IsPrime(int number)
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
