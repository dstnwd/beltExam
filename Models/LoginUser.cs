using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace beltExam.Models
{
    public class LoginUser
    {
        [Required]
        [MinLength(3)]
        public string LoginUsername { get;set; } 
        
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string LoginPassword{ get;set; }
    }
}