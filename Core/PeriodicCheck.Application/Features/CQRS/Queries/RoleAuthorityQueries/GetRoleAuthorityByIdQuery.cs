﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.RoleAuthorityQueries
{
    public class GetRoleAuthorityByIdQuery
    {
        public int Id { get; set; }

        public GetRoleAuthorityByIdQuery(int id)
        {
            Id = id;
        }
    }
}