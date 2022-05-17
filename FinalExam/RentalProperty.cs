using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalExam
{
    public enum RentalType { House, Flat, Share }
    public class RentalProperty
    {
        public int ID { get; set; }
        public RentalType rentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public void IncreaseRent( decimal percentage)
        {
            //take the price and increase it by the percentage entered

            decimal increase = Price * percentage;

            Price =Price + increase;
            
            

        }
        public override string ToString()
        {
            return Location;
        }

    }
    public class RentalData : DbContext
    {
        public RentalData() : base("RentalData") { }

        public DbSet<RentalProperty> RentalProperties { get; set; }
           


    }
}
