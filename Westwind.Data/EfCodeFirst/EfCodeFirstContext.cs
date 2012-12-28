﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Data.Entity;
using Westwind.Utilities.Data;

namespace Westwind.Data.EfCodeFirst
{
    /// <summary>
    /// Optional customized EF CodeFirst Context class that adds 
    /// support for more full featured low level ADO.NET data access
    /// using the Westwind.Utilities.Data.SqlDataAccess class.
    /// </summary>
    public class EfCodeFirstContext : DbContext
    {
        /// <summary>
        /// Low level data access object
        /// </summary>
        public DataAccessBase Db
        {
            get
            {
                if (_DbNative == null)
                    _DbNative = new SqlDataAccess(Database.Connection.ConnectionString);
                return _DbNative;
            }
            set
            {
                _DbNative = value;
            }
        }
        private DataAccessBase _DbNative;
        

        public EfCodeFirstContext()
        { }

        /// <summary>
        /// Custom constructor that allows passing in of a custom IDbNative context
        /// to provide SQL interactivity.
        /// </summary>
        /// <param name="dbNative"></param>
        public EfCodeFirstContext(DataAccessBase dbNative)   
        {
            Db = dbNative;            
        }

        public EfCodeFirstContext(string connectionString, string providerName = null)
        {
            if(!string.IsNullOrEmpty(providerName))
                Db = new SqlDataAccess(connectionString,providerName);
            else
                Db = new SqlDataAccess(connectionString);
        }


        
    }    
}