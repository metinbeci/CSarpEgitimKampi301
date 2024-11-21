using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CSarpEgitimKampi301.EntityLayer.Concrete
{
    /*
        - field-Variable-property
    */
    
    //int x; // Field (Clasın içine tanımlanırsa)
    //public int y { get; set; }  // Property 
    //void test() // Variable (metot içinde tanımlanırsa değişken )
    //{
    //    int z;
    //}
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products{ get; set; }



    }
}
