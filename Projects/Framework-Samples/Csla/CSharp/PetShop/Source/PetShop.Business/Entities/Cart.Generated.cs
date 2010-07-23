﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: EditableChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Validation;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Cart : BusinessBase< Cart >
    {
        #region Contructor(s)

        private Cart()
        {
            // require use of factory method.
            MarkAsChild();
        }

        internal Cart(System.Int32 cartId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_cartIdProperty, cartId);
            }

            MarkAsChild();
        }

        internal Cart(SafeDataReader reader)
        {
            Map(reader);

            MarkAsChild();
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _itemIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringRequired, _nameProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_nameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _typeProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_typeProperty, 80));
            ValidationRules.AddRule(CommonRules.StringRequired, _categoryIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringRequired, _productIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_productIdProperty, 10));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _cartIdProperty = RegisterProperty< System.Int32 >(p => p.CartId, string.Empty);
		[System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 CartId
        {
            get { return GetProperty(_cartIdProperty); }
            internal set{ SetProperty(_cartIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _uniqueIDProperty = RegisterProperty< System.Int32 >(p => p.UniqueID, string.Empty);
        public System.Int32 UniqueID
        {
            get { return GetProperty(_uniqueIDProperty); }
            set{ SetProperty(_uniqueIDProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _itemIdProperty = RegisterProperty< System.String >(p => p.ItemId, string.Empty);
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _typeProperty = RegisterProperty< System.String >(p => p.Type, string.Empty);
        public System.String Type
        {
            get { return GetProperty(_typeProperty); }
            set{ SetProperty(_typeProperty, value); }
        }
        private static readonly PropertyInfo< System.Decimal > _priceProperty = RegisterProperty< System.Decimal >(p => p.Price, string.Empty);
        public System.Decimal Price
        {
            get { return GetProperty(_priceProperty); }
            set{ SetProperty(_priceProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _productIdProperty = RegisterProperty< System.String >(p => p.ProductId, string.Empty);
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Boolean > _isShoppingCartProperty = RegisterProperty< System.Boolean >(p => p.IsShoppingCart, string.Empty);
        public System.Boolean IsShoppingCart
        {
            get { return GetProperty(_isShoppingCartProperty); }
            set{ SetProperty(_isShoppingCartProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _quantityProperty = RegisterProperty< System.Int32 >(p => p.Quantity, string.Empty);
        public System.Int32 Quantity
        {
            get { return GetProperty(_quantityProperty); }
            set{ SetProperty(_quantityProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Profile > _profileMemberProperty = RegisterProperty< Profile >(p => p.ProfileMember, Csla.RelationshipTypes.Child);
        public Profile ProfileMember
        {
            get
            {
                if(!FieldManager.FieldExists(_profileMemberProperty))
                {
                    var criteria = new PetShop.Business.ProfileCriteria {UniqueID = UniqueID};
                    
                    if(PetShop.Business.Profile.Exists(criteria))
                        LoadProperty(_profileMemberProperty, PetShop.Business.Profile.GetByUniqueID(UniqueID));
                }

                return GetProperty(_profileMemberProperty); 
            }
        }
        #endregion

        #region Synchronous Factory Methods 

        internal static Cart NewCart()
        {
            return DataPortal.CreateChild< Cart >();
        }

        internal static Cart GetByCartId(System.Int32 cartId)
        {
            var criteria = new CartCriteria {CartId = cartId};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }

        internal static Cart GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new CartCriteria {UniqueID = uniqueID};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }

        internal static Cart GetByIsShoppingCart(System.Boolean isShoppingCart)
        {
            var criteria = new CartCriteria {IsShoppingCart = isShoppingCart};
            
        
            return DataPortal.FetchChild< Cart >(criteria);
        }

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(CartCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);
        partial void OnChildSelfDeleted();
        partial void OnDeleting(CartCriteria criteria, ref bool cancel);
        partial void OnDeleting(CartCriteria criteria, SqlConnection connection, ref bool cancel);
        partial void OnDeleted();

        #endregion

        #region Exists Command

        public static bool Exists(CartCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}