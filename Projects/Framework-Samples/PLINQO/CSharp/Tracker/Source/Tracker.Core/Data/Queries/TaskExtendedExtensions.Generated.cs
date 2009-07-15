﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Data.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The query extension class for TaskExtended.
    /// </summary>
    public static partial class TaskExtendedExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Core.Data.TaskExtended ByKey(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, int taskId)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.TaskExtended>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.ByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, taskId);
            
            return queryable.FirstOrDefault(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.TaskExtended> table, int taskId)
        {
            return table.Delete(t => t.TaskId == taskId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.Browser"/>.
        /// </summary>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByBrowser(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string browser)
        {
            return queryable.Where(t => object.Equals(t.Browser, browser));
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.Os"/>.
        /// </summary>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByOs(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string os)
        {
            return queryable.Where(t => object.Equals(t.Os, os));
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.CreatedDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime createdDate)
        {
            return queryable.Where(t => t.CreatedDate == createdDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.ModifiedDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(t => t.ModifiedDate == modifiedDate);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, Tracker.Core.Data.TaskExtended> ByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int taskId) => 
                        db.TaskExtended.FirstOrDefault(t => t.TaskId == taskId));

        }
        #endregion
    }
}

