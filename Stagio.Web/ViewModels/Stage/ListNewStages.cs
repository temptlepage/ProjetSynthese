﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stagio.Web.ViewModels.Stage
{
    public class ListNewStages
    {

        public int Id { get; set; }
         [DisplayName("Date de l'offre")]
        public String PublicationDate { get; set; }

        [DisplayName("Entreprise ou Organisation")]
        [Required(ErrorMessage = "Requis")]
        
        public String CompanyName { get; set; }

        [DisplayName("Titre du stage")]
        [Required(ErrorMessage = "Requis")]
        public String StageTitle { get; set; }

        [DisplayName("Date de fin de soumission")]
        [Required(ErrorMessage = "Requis")]
        public String LimitDate { get; set; }

        [DisplayName("Nombre de stagiaires")]
        [Required(ErrorMessage = "Requis")]
        public int NbrStagiaire { get; set; }

       
    }
}