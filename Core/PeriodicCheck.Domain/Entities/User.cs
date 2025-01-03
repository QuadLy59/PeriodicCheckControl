﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public RoleAuthority RoleAuthority { get; set; }
        public Authority Authority { get; set; }
        public string Name_And_Surname { get; set; }
        public int Phone_Number { get; set; }
        public string Email { get; set; }
        public byte Password { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }


    }
}
