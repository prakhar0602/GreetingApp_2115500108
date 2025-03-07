using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class Message
    {
        [Key]
        public int content { get; set; }
        [Required]
        public string message { get; set; }
    }
}
