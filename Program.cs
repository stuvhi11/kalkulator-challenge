// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        string ulang = "";
        Console.Write(
                "Selamat Datang di Program Perhitungan" +
                "\nMenu Operasi (+, -, *, :)" +
                "\n(angka)(operasi)(angka)=" +
                "\nInput Operasi : "
            );

        string input = Console.ReadLine().Replace(" ", "");
        int hasil = 0, hasil1;

        if (input.EndsWith("="))
        {
            char[] operasi = { '+', '-', '*', ':' };
            int posisi = input.IndexOfAny(operasi);
            int posisisd = input.IndexOf('=');
            int pp = input.Length - (posisi + 1) - 1;
            int a1 = Convert.ToInt32(input.Substring(0, posisi));
            int a2 = Convert.ToInt32(input.Substring(posisi + 1, pp));
            char execute = input[posisi];

            switch (execute)
            {
                case '+':
                    // int a1, angka2;
                    hasil = a1 + a2;
                    Console.Write($"{hasil} ");
                    break;
                case '-':
                    // int a1, angka2;
                    hasil = a1 - a2;
                    Console.Write($"{hasil} ");
                    break;
                case ':':
                    // int a1, angka2;
                    hasil = a1 / a2;
                    Console.Write($"{hasil} ");
                    break;
                case '*':
                    // int a1, angka2;
                    hasil = a1 * a2;
                    Console.Write($"{hasil} ");
                    break;
                default:
                    Console.Write("Maaf yang anda inputkan tidak tersedia");
                    break;
            }

            while (true)
            {
                string lanjut = Console.ReadLine();
                string[] Lanjut = lanjut.Split(operasi);
                int posisi1 = lanjut.IndexOfAny(operasi);
                char Operasi = lanjut[posisi1];

                switch (Operasi)
                {
                    case '+':
                        int alanjut = int.Parse(Lanjut[1]);
                        hasil1 = hasil + alanjut;
                        Console.Write($"{hasil1}");
                        break;
                    case '-':
                        alanjut = int.Parse(Lanjut[1]);
                        hasil1 = hasil - alanjut;
                        Console.Write($"{hasil1}");
                        break;
                    case '*':
                        alanjut = int.Parse(Lanjut[1]);
                        hasil1 = (hasil * alanjut);
                        Console.Write($"{hasil1}");
                        break;
                    case '/':
                    case ':':
                        alanjut = int.Parse(Lanjut[1]);
                        hasil1 = hasil / alanjut;
                        Console.Write($"{hasil1}");
                        break;
                    default:
                        Console.Write("\nPilihan anda tidak tersedia");
                        break;
                }


            }
        }
        else
        {

            Console.Write("beri tanda = ");

        }

    }
}