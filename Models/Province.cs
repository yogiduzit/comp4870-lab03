using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}

