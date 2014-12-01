﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Stagio.Web.ViewModels.ContactEnterprise
{
    public class Draft
    {
        public int Id { get; set; }
        [DisplayName("Date de l'offre")]
        public String PublicationDate { get; set; }
        [DisplayName("Titre de l'offre")]
        public string StageTitle { get; set; }
    }
}