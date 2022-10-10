using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_tuple_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tuple ile bir method üzerinden birden fazla değer döndürmemiz sağlanıyor

            Tuple<int, string, char> kisi = new Tuple<int, string, char>(3, "furkan", 'F');

            // ya da daha kolay yontem olan "var" ile olustururuz tuple ı

            var bilgiler = Tuple.Create(6, "conor", 'M');

            var sayilar = Tuple.Create(5, 7, 8, 9);

            // tuple dan elemanlara erisme

            Console.WriteLine(kisi.Item1); // 3
            Console.WriteLine(kisi.Item2); // furkan
            Console.WriteLine(kisi.Item3); // F

           Console.WriteLine("------------");

            // Bir tuple sekizden fazla öğe eklemek istiyorsak, bunu sekizinci öge olarak başka bir tuple nesnesini iç içe yerleştirerek yapabiliriz. Son iç içe geçmiş tuple’a Rest özelliği kullanılarak erişilebilir. Yuvalanmış tanımlama grubunun öğesine erişmek için Rest.Item1.Item1 özelliğini kullanınlır.

            var rakamlar = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(rakamlar.Item1); //  1
            Console.WriteLine(rakamlar.Item7); //  7
            Console.WriteLine(rakamlar.Rest.Item1); // (8, 9, 10, 11, 12, 13)
            Console.WriteLine(rakamlar.Rest.Item1.Item1); // 8
            Console.WriteLine(rakamlar.Rest.Item1.Item2); // 9

            Console.ReadKey();


        }
    }
}
