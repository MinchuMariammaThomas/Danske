using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data.Contracts.EntityModels;

namespace TMS.Data.EntityModels
{
    public class Municipality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MunicipalityName { get; set; }
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }
        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }
        public int TaxId { get; set; }
    }
}
