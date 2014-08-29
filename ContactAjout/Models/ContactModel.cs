using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContactAjout.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [RegularExpression(@".*@.*", ErrorMessage="Entrez une adresse électronique valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Commentaire { get; set; }
    }
}