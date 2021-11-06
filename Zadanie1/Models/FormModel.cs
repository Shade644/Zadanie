using System;
using System.ComponentModel.DataAnnotations;

namespace Zadanie1.Models
{

    public class FormModel
    {
        [Display(Name = "Imie")]
        public string Name { get; set; }
        [Display(Name = "Ilość dni od twoich urodzin")]
        public string Date { get; set; }
        public string Date2 { get; set; }


    }

}
    

