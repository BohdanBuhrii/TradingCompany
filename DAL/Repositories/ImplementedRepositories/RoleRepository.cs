﻿using DAL.Models;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.ImplementedRepositories
{
    public class RoleRepository : BasicRepository<Role>, IRoleRepository
    {
        public RoleRepository(TradingCompanyContext context)
            :base(context)
        {

        }
    }
}
