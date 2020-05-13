using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CathalMcGivney_s00190028;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500.0m, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600.0m, "IOS", "/images/apple.png", "/images/iphone11.jpg");

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Phones added");

                db.SaveChanges();
                Console.WriteLine("Changes Saved");
            }

        }
    }
}
