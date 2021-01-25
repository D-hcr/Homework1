using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 25;//1
            int n2 = 72;
            int n3;//2
            int n4 = 72;

            Console.WriteLine(Add(ref n1, n2));
            Console.WriteLine(Add2(out n3, n4));
        }
         static int Add(ref int n1, int n2)
        {
            n1 = 15;
            return n1+n2;
        }
        static int Add2(out int n3, int n4)
        {
            n3 = 15;
            return n3 + n4;   
        }
    }
   /*ref kullandığımızda 1 de olduğu gibi değişkene bir değer vermemiz 
    gerek yoksa hata alırız ama out kullanıyorsak da değişkene add2 de 
   değer vermek yeterli tekrar yukarda bir değer vermeden de çalışır .*/
}
