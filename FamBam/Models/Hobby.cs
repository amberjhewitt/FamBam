using System;
using System.ComponentModel.DataAnnotations;

namespace FamBam.DAL
{
    public class Hobby
    {
        [Key]
        public int hobby_ID { get; set; }

        public String hobby_description { get; set; }
    }
}