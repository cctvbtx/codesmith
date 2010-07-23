﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: ReadOnlyChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Tests.Collections.ReadOnlyChild
{
    [Serializable]
    public partial class CategoryInfo : ReadOnlyBase< CategoryInfo >
    {
        #region Contructor(s)

        private CategoryInfo()
        { /* Require use of factory methods */ }
        internal CategoryInfo(System.String categoryId)
        {
            LoadProperty(_categoryIdProperty, categoryId);
        }

        internal CategoryInfo(SafeDataReader reader)
        {
            Map(reader);
        }
        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
        }

        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty, (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
        }

        private static readonly PropertyInfo< System.String > _descriptionProperty = RegisterProperty< System.String >(p => p.Description, string.Empty, (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static CategoryInfo GetByCategoryId(System.String categoryId)
        {
            var criteria = new CategoryCriteria {CategoryId = categoryId};
            

            return DataPortal.FetchChild< CategoryInfo >(criteria);
        }

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(CategoryCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);
        partial void OnChildSelfDeleted();
        partial void OnDeleting(CategoryCriteria criteria, ref bool cancel);
        partial void OnDeleting(CategoryCriteria criteria, SqlConnection connection, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return PetShop.Tests.Collections.ReadOnlyChild.ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}