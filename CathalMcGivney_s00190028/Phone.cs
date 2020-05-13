using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CathalMcGivney_s00190028
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem{ get; set; }
        public string OS_Image{ get; set; }
        public string Phone_Image{ get; set; }


        public Phone()
        {
        }

         
        public Phone( string name, decimal price, string operatingSystem, string OS_ImageArg, string phone_Image  )
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = OS_ImageArg;
            Phone_Image = phone_Image;
        }

        public void IncreasePrice( double percent )
        {
            Price = Price *  (decimal)(1.0 + ( 0.01 * percent) );
        }
    }


    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }

        public DbSet<Phone> Phones { get; set; }
    }

}
