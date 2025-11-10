namespace S
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayı1 = 10;
            var sayı2 = 10;
            var sonuc = Toplam(sayı1, sayı2);
            Console.WriteLine(sonuc);



        }

        static int Toplam(int a, int b)
        {
            var toplam = a + b;
            return toplam;
        }


    }




}






