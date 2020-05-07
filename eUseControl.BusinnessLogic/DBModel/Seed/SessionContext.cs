﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DBModel.Seed
{
    internal class SessionContext : DbContext
    {
        public SessionContext() : base("name=eUseControlDB")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}
