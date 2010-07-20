﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template path: EditableRoot.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
using Csla.Data;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.CategoryFactoryName)]
    public partial class Category : BusinessBase< Category >
    {
        #region Contructor(s)

        private Category()
        { /* Require use of factory methods */ }

        internal Category(System.String categoryId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_categoryIdProperty, categoryId);
            }
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_categoryIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Used for optimistic concurrency.
        /// </summary>
        [NotUndoable]
        internal System.Byte[] TheVersion = new System.Byte[8];

        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalCategoryIdProperty = RegisterProperty< System.String >(p => p.OriginalCategoryId, string.Empty);
        /// <summary>
        /// Holds the original value for CategoryId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalCategoryId
        {
            get { return GetProperty(_originalCategoryIdProperty); }
            set{ SetProperty(_originalCategoryIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty, (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _descriptionProperty = RegisterProperty< System.String >(p => p.Description, string.Empty, (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }

        //AssociatedOneToMany
        private static readonly PropertyInfo< ProductList > _productsProperty = RegisterProperty<ProductList>(p => p.Products, Csla.RelationshipTypes.Child);
        public ProductList Products
        {
            get
            {
                if(!FieldManager.FieldExists(_productsProperty))
                {
					var criteria = new PetShop.Tests.ObjF.ParameterizedSQL.ProductCriteria {CategoryId = CategoryId};
					

                    if(IsNew || !PetShop.Tests.ObjF.ParameterizedSQL.ProductList.Exists(criteria))
                        LoadProperty(_productsProperty, PetShop.Tests.ObjF.ParameterizedSQL.ProductList.NewList());
                    else
                        LoadProperty(_productsProperty, PetShop.Tests.ObjF.ParameterizedSQL.ProductList.GetByCategoryId(CategoryId));
                }

                return GetProperty(_productsProperty);
            }
        }
        #endregion

        #region Synchronous Factory Methods 

        public static Category NewCategory()
        {
            return DataPortal.Create< Category >();
        }

        public static Category GetByCategoryId(System.String categoryId)
        {
			var criteria = new CategoryCriteria {CategoryId = categoryId};
			
			
            return DataPortal.Fetch< Category >(criteria);
        }

        public static void DeleteCategory(System.String categoryId)
        {
			var criteria = new CategoryCriteria {CategoryId = categoryId};
			
			
            DataPortal.Delete< Category >(criteria);
        }

        #endregion

        #region Overridden properties

        /// <summary>
        /// Returns true if the business object or any of its children properties are dirty.
        /// </summary>
        public override bool IsDirty
        {
            get
            {
                if (base.IsDirty) return true;
                if (FieldManager.FieldExists(_productsProperty) && Products.IsDirty) return true;

                return false;
            }
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CategoryCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(CategoryCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}