using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace beltExam.Models
{
    public class Enthusiast
    {
        [Key]
        public int EnthusiastId { get; set; }
        public int HobbyId{ get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public Hobby Hobbies { get; set; }
    }
}