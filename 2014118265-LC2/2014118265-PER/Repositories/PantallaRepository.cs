﻿using _2014118265_ENT;
using _2014118265_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118265_PER.Repositories
{
    public class PantallaRepository : Repository<Pantalla>, IPantallaRepository
    {
        
        public PantallaRepository(_2014118265DbContext context) : base(context)
        {

        }
        
        
        
        /*private readonly _2014118265DbContext _Context;

        public PantallaRepository(_2014118265DbContext context)
        {
            _Context = context;
        }
        private PantallaRepository()
        {

        }
        */
    }
}
