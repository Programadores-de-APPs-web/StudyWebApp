using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWebApp.Shared.Logging
{
    public class Loggings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLog { get; set; }
        public string Registro { get; set; } = string.Empty;
        public string LogLevel { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
    }
}
