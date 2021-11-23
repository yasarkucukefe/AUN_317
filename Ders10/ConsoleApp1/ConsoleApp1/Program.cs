using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringOlustur();
            //ArrayListOrnek();
            //SortedListOrnek();
            //string sehirler = DictionaryOrnek("TR");
            //Console.WriteLine(sehirler);
            TupleOrnek();
        }

        private static void TupleOrnek()
        {
            Tuple<int, int, string> tuple = new Tuple<int, int, string>(2, 3, "Monitör");
            //Console.WriteLine(tuple.Item2);
            //
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            Console.WriteLine(numbers.Rest.Item1.Item3);
        }

        private static string DictionaryOrnek(string ulkeKodu)
        {
            Dictionary<string, string> ulkeler = new Dictionary<string, string>();
            //var ulkeler = new Dictionary<string, string>();
            ulkeler.Add("TR", "İstanbul, Ankara, İzmir");
            ulkeler.Add("UK", "Londra, Manchester, Birmingham");
            ulkeler.Add("USA", "New York, Washington, Los Angeles");
            ulkeler["TR"]="İstanbul, Ankara, İzmir, Adana";


            //Console.WriteLine(ulkeler["TR"]);
            //
            //Console.WriteLine(ulkeler["FR"]);
            if (ulkeler.ContainsKey(ulkeKodu))
            {
                return ulkeler[ulkeKodu];
            }
            return "-";
        }

        private static void SortedListOrnek()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Pazartesi");
            sl.Add(2, "Salı");
            sl.Add(5, "Cuma");
            sl.Add(3, "Çarşamba");
            sl.Add(4, "Perşembe");

            foreach (var kvp in sl)
            {
                Console.WriteLine(kvp.Key + "=>" + kvp.Value);
            }

        }

        static void ArrayListOrnek()
        {
            int[] rakamlar = { 1, 2, 3, 4 };
            string[] isimler = { "Ahmet", "Ayşe", "Cemal" };
            // Array'ler tek bir türü içerebileri. int, string, bool,
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ahmet");
            arrayList.Add(2);

            ArrayList arrayList2 = new ArrayList(){ 2, "Mehmet", 3, true };
            //
            // ArrayList elemanlarına erişim
            //int sayi = arrayList[0]; // hata verecektir.
            int sayi = (int) arrayList[0]; // veri türü cast edilmelidir.
            String isim = (string) arrayList[1];
            //
            // ArrayList'e ekleme mümkündür.
            arrayList.AddRange(arrayList2);
            //
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");

            arrayList.AddRange(q);
            //
            foreach(var deger in arrayList)
            {
                Console.WriteLine(deger);
            }

            // Queue
            Queue sira = new Queue();
            sira.Enqueue("Burak");
            sira.Enqueue("Mehmet");
            sira.Enqueue("Erdem");
            sira.Enqueue("Mert");
            sira.Enqueue("Mahir");
            sira.Enqueue("Tayfur");
            //
            foreach(var isim_ in sira)
            {
                Console.WriteLine(isim_);
            }
            //
            Console.WriteLine("İlk çıkacak kişi: "+sira.Dequeue()); // Dequeue: ilk eleman queue'dan çıkar
            Console.WriteLine("Sıradaki kişi: "+sira.Peek()); // Peek: ilk eleman 



        }

        static void StringOlustur()
        {
            String mesaj = "Merhaba,";
            mesaj = mesaj + " Dünya.";
            mesaj = mesaj + "\nBugün günlerden Salı.";
            mesaj = mesaj + "\nBugün yağmur bekleniyor.";
            Console.WriteLine(mesaj);
            //
            // StringBuilder kullanılarak aynı String'in oluşturulması mümkündür. StringBuilder kullanarak uygulama performansı arttırılır.
            //StringBuilder sb = new StringBuilder("Merhaba"); => Başlangıç değeri ile oluşturulması
            StringBuilder sb = new StringBuilder(); // Boş değer ile oluşturulması
            sb.Append("Merhaba");
            sb.AppendLine(" Dünya.");
            sb.AppendLine("Bugün günlerden Salı.");
            sb.AppendLine("Bugün yağmur bekleniyor.");
            Console.WriteLine(sb);
        }

        
    }

    class Islem
    {
        public int getFactoriyel(int rakam)
        {
            return 0;
        }
    }
}
