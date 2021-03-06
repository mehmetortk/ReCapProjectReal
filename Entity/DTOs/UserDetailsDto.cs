using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.DTOs
{
    public class UserDetailsDto:IDto
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string CompanyName { get; set; }
        public string CarModelYear { get; set; }
        public string CarDescription { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public DateTime CarRentDate { get; set; }
    }
}
