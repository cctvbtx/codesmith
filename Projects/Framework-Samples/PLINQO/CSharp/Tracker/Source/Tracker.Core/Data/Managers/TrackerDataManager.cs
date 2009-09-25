﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The data manager for a DataContext.
    /// </summary>
    public class TrackerDataManager : CodeSmith.Data.DataManagerBase<Tracker.Core.Data.TrackerDataContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tracker.Core.Data.TrackerDataManager"/> class.
        /// </summary>
        /// <param name="context">An instance of <see cref="Tracker.Core.Data.TrackerDataContext"/> DataContext.</param>
        public TrackerDataManager(Tracker.Core.Data.TrackerDataContext context) : base(context)
        { }
        
        #region Managers
        
        private AuditManager _auditManager;

        /// <summary>
        /// Gets the manager for Audit.
        /// </summary>
        public AuditManager Audit
        {
            get
            {
                if (_auditManager == null)
                    _auditManager = new AuditManager(this);

                return _auditManager;
            }
        }
        
        private RoleManager _roleManager;

        /// <summary>
        /// Gets the manager for Role.
        /// </summary>
        public RoleManager Role
        {
            get
            {
                if (_roleManager == null)
                    _roleManager = new RoleManager(this);

                return _roleManager;
            }
        }
        
        private StatusManager _statusManager;

        /// <summary>
        /// Gets the manager for Status.
        /// </summary>
        public StatusManager Status
        {
            get
            {
                if (_statusManager == null)
                    _statusManager = new StatusManager(this);

                return _statusManager;
            }
        }
        
        private TaskManager _taskManager;

        /// <summary>
        /// Gets the manager for Task.
        /// </summary>
        public TaskManager Task
        {
            get
            {
                if (_taskManager == null)
                    _taskManager = new TaskManager(this);

                return _taskManager;
            }
        }
        
        private TaskExtendedManager _taskExtendedManager;

        /// <summary>
        /// Gets the manager for TaskExtended.
        /// </summary>
        public TaskExtendedManager TaskExtended
        {
            get
            {
                if (_taskExtendedManager == null)
                    _taskExtendedManager = new TaskExtendedManager(this);

                return _taskExtendedManager;
            }
        }
        
        private UserManager _userManager;

        /// <summary>
        /// Gets the manager for User.
        /// </summary>
        public UserManager User
        {
            get
            {
                if (_userManager == null)
                    _userManager = new UserManager(this);

                return _userManager;
            }
        }
        
        private UserRoleManager _userRoleManager;

        /// <summary>
        /// Gets the manager for UserRole.
        /// </summary>
        public UserRoleManager UserRole
        {
            get
            {
                if (_userRoleManager == null)
                    _userRoleManager = new UserRoleManager(this);

                return _userRoleManager;
            }
        }
        #endregion
    }
}