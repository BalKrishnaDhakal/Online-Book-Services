using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookServices.Models
{
    public class MemberShipType
    {

        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        public Byte SignUpFee { get; set; }


        [DisplayName("Rental Rate")]
        [Required]
        public Byte ChargeRateOneMonth { get; set; }


        [Required]
        public Byte ChargeRateSixMonth { get; set; }
    }
}