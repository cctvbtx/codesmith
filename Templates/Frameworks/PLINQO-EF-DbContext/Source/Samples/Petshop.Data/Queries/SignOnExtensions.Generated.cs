﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petshop.Data.Queries
{
    public static partial class SignOnExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Petshop.Data.Entities.SignOn GetByKey(this System.Linq.IQueryable<Petshop.Data.Entities.SignOn> queryable, string userName)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<Petshop.Data.Entities.SignOn>;
            if (dbSet != null)
                return dbSet.Find(userName);
                
            return queryable.FirstOrDefault(s => s.UserName == userName);
        }
    }
}
