using System;

namespace Zadanie_02
{
    public class Cars : Vehicles
    {
        protected string engine;
        protected string color;

        public Cars() : base()
        {
            engine = "";
            color = "";
        }

        public void Read1()
        {
            Read();
        }

        public void Show1()
        {
            Show();
        }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("DODATKOWE DANE SAMOCHODU");
            engine = ReadNonEmptyString("Podaj typ silnika: ");
            color = ReadNonEmptyString("Podaj kolor samochodu: ");
        }

        public override void Show()
        {
            base.Show();
            
            Console.WriteLine($"Silnik:      {engine}");
            Console.WriteLine($"Kolor:       {color}");
        }
    }
}
