﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stagio.Web.ViewModels.Interviews
{
    public class Create
    {
        [DisplayName("Date de l'entrevue")]
        [Required]
        public DateTime Date { get; set; }

        [DisplayName("Stage")]
        [Required]
        public int StageId { get; set; }

        public IEnumerable<SelectListItem> Apply { get; set; } 

    }
}