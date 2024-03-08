using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DTO.CarDTO
{
    public class ResultLastFiveCarsWithBrandDTO
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageURL { get; set; }
        public int KM { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageURL { get; set; }
    }
}
