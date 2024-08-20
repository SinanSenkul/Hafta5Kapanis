using System;

namespace Hafta5Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>(); //car list which collects the created car objects

            //this method creates a new car object with given inputs:
            void CreateCar()
            {
                Console.WriteLine("aracın seri numarasını giriniz");
                string serialNum = Console.ReadLine();
                Console.WriteLine("aracın markasını giriniz");
                string brand = Console.ReadLine();
                Console.WriteLine("aracın modelini giriniz");
                string model = Console.ReadLine();
                Console.WriteLine("aracın rengini giriniz");
                string color = Console.ReadLine();
                int doorType = 4;
            EnterSerialNum: //transfer point for goto jump
                Console.WriteLine("aracın kapı sayısını giriniz");
                try
                {
                    doorType = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex) //if any format error occurs with door type (ie a string input) thise code runs:
                {
                    Console.WriteLine("format hatası : bir sayı girmelisiniz");
                    goto EnterSerialNum;
                }
                Car newCar = new Car(serialNum, brand, model, color, doorType);
                carList.Add(newCar);
                Console.WriteLine($"araç bilgileri: seri numarası:{serialNum} marka: {brand} model: {model} " +
                    $"kapı sayısı: {doorType}");
            }

            void ListCars()
            {
                int rank = 1;
                foreach (Car car in carList)
                {
                    Console.WriteLine($"{rank} - seri no: {car.SerialNum} marka: {car.Brand} ");
                    rank++;
                }
            }

            bool repeat = true; // code will re-run until this boolean variable becomes false
            while (repeat)
            {
                Console.WriteLine("araç üretmek istiyor musunuz? (evet için 'e' hayır için 'h' tuşlayınız)");
                string proceed = Console.ReadLine().ToLower();
                while (proceed != "e" && proceed != "h") //while user enters an invalid input
                {
                    Console.WriteLine("yanlış giriş yaptınız. evet için 'e' hayır için 'h' tuşlayınız");
                    proceed = Console.ReadLine().ToLower();
                }
                if (proceed == "e")
                {
                    CreateCar();
                }
                else //if user exits, and if there's no car created program will console write the text down below or
                     //if any car created it will list created cars:
                {
                    repeat = false;
                    if (carList.Count == 0)
                    {
                        Console.WriteLine("programdan çıkış yapılıyor...");
                    }
                    else
                    {
                        Console.WriteLine("oluşturduğunuz araçlar aşağıda listelenmiştir:");
                        ListCars();
                    }
                }
            }
        }
    }
}
