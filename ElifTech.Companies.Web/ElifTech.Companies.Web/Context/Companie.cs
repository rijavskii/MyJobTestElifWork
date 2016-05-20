using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElifTech.Companies.Web.Context
{
    [Table("Companies")]
    public class Companie
    {
        [Key]
        public int Id { get; set; }

        [Column ("parent_id")]
        public int ParentId { get; set; }
        public string Name { get; set; }
        public float Earnings { get; set; }
    }
}