using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShareWeb.CarsParts.Entities
{
    public class PartType
    {
        [Key]
        public int PartTypeID { get; set; }
        [Required, MaxLength(50)]
        public string PartTypeName { get; set; }

        public ICollection<CarPart> Parts { get; set; }
    }
}
