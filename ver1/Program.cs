// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        int hasil = 0;
        Console.Write("\nInputkan Operasi : ");
        while (true)
        {

        string input = Console.ReadLine().Replace(" ", "");
        char[] operasi = { '+', '-', '*', ':' };
        int tempat = input.IndexOfAny(operasi);
        int a1 = 0, a2 = 0;

        if (tempat == 0)
        {
            //int tempatsd = input.IndexOf('=');
            a1 = hasil;
            int pp = input.Length - (tempat + 1) - 1;
            a2 = Convert.ToInt32(input.Substring(tempat + 1, pp));
        }else
        {
            a1 =Convert.ToInt32(input.Substring(0, tempat));
            int pp = input.Length - (tempat + 1) - 1;
            a2 = Convert.ToInt32(input.Substring(tempat + 1, pp));
        }
            char execute = input[tempat];

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
                    Console.WriteLine("Maaf yang anda inputkan tidak tersedia");
                    break;
            }
        }

            //     switch (Operasi)
            //     {
            //         case '+':
            //             int alanjut = int.Parse(Lanjut[1]);
            //             hasil1 = hasil + alanjut;
            //             Console.Write($"{hasil1}");
            //             break;
            //         case '-':
            //             alanjut = int.Parse(Lanjut[1]);
            //             hasil1 = hasil - alanjut;
            //             Console.Write($"{hasil1}");
            //             break;
            //         case '*':
            //             alanjut = int.Parse(Lanjut[1]);
            //             hasil1 = (hasil * alanjut);
            //             Console.Write($"{hasil1}");
            //             break;
            //         case '/':
            //         case ':':
            //             alanjut = int.Parse(Lanjut[1]);
            //             hasil1 = hasil / alanjut;
            //             Console.Write($"{hasil1}");
            //             break;
            //         default:
            //             Console.Write("\nPilihan anda tidak tersedia");
            //             break;
            //     }


            // }
    }
        // else
        // {

        //     Console.Write("beri tanda = ");

        // }
}
