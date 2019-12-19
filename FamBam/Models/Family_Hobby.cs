using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamBam.DAL
{
    public class Family_Hobby
    {
        [Key, Column(Order=1)]
        public int family_ID { get; set; }

        [Key, Column(Order = 2)]
        public int hobby_ID { get; set; }
    }
}