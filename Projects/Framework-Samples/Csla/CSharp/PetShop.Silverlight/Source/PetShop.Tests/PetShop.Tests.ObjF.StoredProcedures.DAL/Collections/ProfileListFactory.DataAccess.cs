﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: ObjectFactoryList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class ProfileListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new ProfileList with default values.
        /// </summary>
        /// <returns>new ProfileList.</returns>
        [RunLocal]
        public ProfileList Create()
        {
            var item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch ProfileList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public ProfileList Fetch(ProfileCriteria criteria)
        {
            ProfileList item = (ProfileList)Activator.CreateInstance(typeof(ProfileList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Profile_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_IsAnonymousHasValue", criteria.IsAnonymousHasValue);
					command.Parameters.AddWithValue("@p_LastActivityDateHasValue", criteria.LastActivityDateHasValue);
					command.Parameters.AddWithValue("@p_LastUpdatedDateHasValue", criteria.LastUpdatedDateHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                item.Add(new ProfileFactory().Map(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            MarkOld(item);
            OnFetched();
            return item;
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref Profile item, ref bool cancel);

        #endregion
    }
}