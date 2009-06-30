//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.6.x CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CartList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Business
{
	[Serializable]
	public partial class CartList : BusinessListBase< CartList, Cart >
	{
		#region Factory Methods 
		
		internal static CartList NewList()
		{
			return DataPortal.CreateChild< CartList >();
		}
		
		internal static Cart GetCart(int cartId)
		{
			return DataPortal.FetchChild< Cart >(
				new CartCriteria(cartId));
		}
        
        internal static CartList GetAll()
        {
            return DataPortal.FetchChild< CartList >(new CartCriteria());
        }
        
        internal static CartList GetByUniqueID(int uniqueID)
		{
            return DataPortal.FetchChild< CartList >(
                new CartCriteria { UniqueID = uniqueID });
        }

		private CartList()
		{
			AllowNew = true;
            MarkAsChild();
		}
		
		#endregion

		#region Business Methods
		
		protected override object AddNewCore()
		{
			Cart item = PetShop.Business.Cart.NewCart();
			Add(item);
			return item;
		}
		
		#endregion
	}
}