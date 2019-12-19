using System;
using System.ComponentModel.DataAnnotations;

namespace FamBam.DAL
{
    public class Family
    {
        [Key]
        public int family_ID { get; set; }

        public String first_name { get; set; }

        public String last_name { get; set; }

        public String middle_name { get; set; }

        public DateTime birthday { get; set; }

    }
}