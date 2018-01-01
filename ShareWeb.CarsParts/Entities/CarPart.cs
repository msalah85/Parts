using System;
using System.ComponentModel.DataAnnotations;

namespace ShareWeb.CarsParts.Entities
{
    public class CarPart
    {
        [Key]
        public int PartID { get; set; }
        public int MakeID { get; set; }
        public int ModelID { get; set; }
        public int Year { get; set; }
        [Required, MaxLength(50)]
        public string PartName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool Active { get; set; }
        public bool Features { get; set; }
        public bool Deleted { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public PartType PartType { get; set; }
    }
}
