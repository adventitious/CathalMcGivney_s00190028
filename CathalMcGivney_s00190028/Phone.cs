using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathalMcGivney_s00190028
{
    class Phone
    {
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem{ get; set; }
        public string OS_Image{ get; set; }
        public string Phone_Image{ get; set; }
        
        
        public void IncreasePrice( double percent )
        {
            Price = Price *  (decimal)(1.0 + ( 0.01 * percent) );
        }
    }
}
