﻿using _2014118265_ENT;
using _2014118265_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265_PER.Repositories
{
    public class ATMRepository : Repository<ATM>, IATMRepository
    {
        
        public ATMRepository(_2014118265DbContext context) : base(context)
        {

        }
        
        /*private readonly _2014118265DbContext _Context;

        public ATMRepository(_2014118265DbContext context)
        {
            _Context = context;
        }
        private ATMRepository()
        {

        }
        */
    }
}
