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

namespace PLINQO.Tracker.Data
{
    /// <summary>
    /// The query extension class for TaskExtended.
    /// </summary>
    public static partial class TaskExtendedExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static PLINQO.Tracker.Data.TaskExtended ByKey(this IQueryable<PLINQO.Tracker.Data.TaskExtended> queryable, int taskId)
        {
            var entity = queryable as System.Data.Linq.Table<PLINQO.Tracker.Data.TaskExtended>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.ByKey.Invoke((PLINQO.Tracker.Data.TrackerDataContext)entity.Context, taskId);
            
            return queryable.FirstOrDefault(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<PLINQO.Tracker.Data.TaskExtended> table, int taskId)
        {
            return table.Delete(t => t.TaskId == taskId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.Browser"/>.
        /// </summary>
        public static IQueryable<PLINQO.Tracker.Data.TaskExtended> ByBrowser(this IQueryable<PLINQO.Tracker.Data.TaskExtended> queryable, string browser)
        {
            return queryable.Where(t => object.Equals(t.Browser, browser));
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.Os"/>.
        /// </summary>
        public static IQueryable<PLINQO.Tracker.Data.TaskExtended> ByOs(this IQueryable<PLINQO.Tracker.Data.TaskExtended> queryable, string os)
        {
            return queryable.Where(t => object.Equals(t.Os, os));
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.CreatedDate"/>.
        /// </summary>
        public static IQueryable<PLINQO.Tracker.Data.TaskExtended> ByCreatedDate(this IQueryable<PLINQO.Tracker.Data.TaskExtended> queryable, System.DateTime createdDate)
        {
            return queryable.Where(t => t.CreatedDate == createdDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="TaskExtended.ModifiedDate"/>.
        /// </summary>
        public static IQueryable<PLINQO.Tracker.Data.TaskExtended> ByModifiedDate(this IQueryable<PLINQO.Tracker.Data.TaskExtended> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(t => t.ModifiedDate == modifiedDate);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<PLINQO.Tracker.Data.TrackerDataContext, int, PLINQO.Tracker.Data.TaskExtended> ByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (PLINQO.Tracker.Data.TrackerDataContext db, int taskId) => 
                        db.TaskExtended.FirstOrDefault(t => t.TaskId == taskId));

        }
        #endregion
    }
}
