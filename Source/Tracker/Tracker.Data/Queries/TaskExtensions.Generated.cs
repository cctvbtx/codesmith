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

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for Task.
    /// </summary>
    public static partial class TaskExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Data.Task ByKey(this IQueryable<Tracker.Data.Task> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Data.Task>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.ByKey.Invoke((Tracker.Data.TrackerDataContext)entity.Context, id);
            
            return queryable.FirstOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Data.Task> table, int id)
        {
            return table.Delete(t => t.Id == id);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.StatusId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByStatusId(this IQueryable<Tracker.Data.Task> queryable, int statusId)
        {
            return queryable.Where(t => t.StatusId == statusId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.PriorityId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByPriorityId(this IQueryable<Tracker.Data.Task> queryable, Priority priorityId)
        {
            return queryable.Where(t => t.PriorityId == priorityId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.CreatedId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByCreatedId(this IQueryable<Tracker.Data.Task> queryable, int createdId)
        {
            return queryable.Where(t => t.CreatedId == createdId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.Summary"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> BySummary(this IQueryable<Tracker.Data.Task> queryable, string summary)
        {
            return queryable.Where(t => t.Summary == summary);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.Details"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByDetails(this IQueryable<Tracker.Data.Task> queryable, string details)
        {
            return queryable.Where(t => object.Equals(t.Details, details));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.StartDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByStartDate(this IQueryable<Tracker.Data.Task> queryable, System.DateTime? startDate)
        {
            return queryable.Where(t => object.Equals(t.StartDate, startDate));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.DueDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByDueDate(this IQueryable<Tracker.Data.Task> queryable, System.DateTime? dueDate)
        {
            return queryable.Where(t => object.Equals(t.DueDate, dueDate));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.CompleteDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByCompleteDate(this IQueryable<Tracker.Data.Task> queryable, System.DateTime? completeDate)
        {
            return queryable.Where(t => object.Equals(t.CompleteDate, completeDate));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.AssignedId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByAssignedId(this IQueryable<Tracker.Data.Task> queryable, int? assignedId)
        {
            return queryable.Where(t => object.Equals(t.AssignedId, assignedId));
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.CreatedDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByCreatedDate(this IQueryable<Tracker.Data.Task> queryable, System.DateTime createdDate)
        {
            return queryable.Where(t => t.CreatedDate == createdDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.ModifiedDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByModifiedDate(this IQueryable<Tracker.Data.Task> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(t => t.ModifiedDate == modifiedDate);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Task.LastModifiedBy"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Task> ByLastModifiedBy(this IQueryable<Tracker.Data.Task> queryable, string lastModifiedBy)
        {
            return queryable.Where(t => object.Equals(t.LastModifiedBy, lastModifiedBy));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Data.TrackerDataContext, int, Tracker.Data.Task> ByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Data.TrackerDataContext db, int id) => 
                        db.Task.FirstOrDefault(t => t.Id == id));

        }
        #endregion
    }
}

