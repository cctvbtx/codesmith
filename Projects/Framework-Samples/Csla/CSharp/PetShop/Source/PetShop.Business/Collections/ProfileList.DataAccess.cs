
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.7.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProfileList.cs'.
//
//     Template: EditableRootList.DataAccess.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;

using Csla;
using Csla.Data;

using PetShop.Data;

#endregion

namespace PetShop.Business
{
	public partial class ProfileList
	{
		#region Data Access
		
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }
        
		private void DataPortal_Fetch(ProfileCriteria criteria)
		{
            RaiseListChangedEvents = false;
            
            using(SafeDataReader reader = DataAccessLayer.Instance.ProfileFetch(criteria.StateBag)) 
			{
                while(reader.Read())
				{	
                    this.Add(new PetShop.Business.Profile(reader));
				}
			}
            
            RaiseListChangedEvents = true;
		}
       
		#endregion
	}
}