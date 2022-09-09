using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace beltExam.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get;set; }
        [Required]
        public string HobbyName { get;set; }
        [Required]
        public string Description { get; set; }
        public int UserId { get; set; }
        public List<Enthusiast> Enthusiasts { get; set; }
        
        
        
    }
}