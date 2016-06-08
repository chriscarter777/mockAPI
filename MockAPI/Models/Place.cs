using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MockAPI.Models
{
    public class Place
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a place name.")]
        public string Name { get; set; }
        [RegularExpression("[0-9]{1,}", ErrorMessage ="Please enter an integer population value.")]
        public int Population { get; set; }
    }
}