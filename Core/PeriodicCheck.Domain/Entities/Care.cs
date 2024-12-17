﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class Care
    {
        [Key]
        public int Care_id { get; set; }
        public int Equipment_id { get; set; }
        public DateTime Care_date { get; set; }
        public string Techinician { get; set; }
        public DateTime Next_Care_Date { get; set; }
        public DateTime Previ_Care_Date { get; set; }
        public string Control_Type { get; set; }
        public string Care_Description { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; } 
        public bool Is_deleted { get; set; }
        public Equipment Equipment { get; set; }
        public Equipment Equipment2 { get; set; }

    }
}
