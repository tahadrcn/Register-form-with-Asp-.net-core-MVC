using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace courseapp.Models
{
    public class StudentsResponse
    {
        [Required(ErrorMessage ="isminizi giriniz!")]
        public string name { get; set; }
       
        
        [Required(ErrorMessage ="E-mail adresinizi giriniz!")]
        
        [EmailAddress(ErrorMessage ="")]
        public string email { get; set; }
       
        [Required(ErrorMessage ="numaranızı giriniz!")]

        public string phone { get; set; }
       
        [Required(ErrorMessage ="Seçim yapınız.")]

        public bool? confirm { get; set; }
    }
}