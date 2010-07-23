//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderStatus.cs'.
//
//     Template: ObjectFactoryList.DataAccess.ParameterizedSQL.cst
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

using PetShop.Tests.ObjF.ParameterizedSQL;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public partial class OrderStatusListFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new OrderStatusList with default values.
        /// </summary>
        /// <returns>new OrderStatusList.</returns>
        [RunLocal]
        public OrderStatusList Create()
        {
            var item = (OrderStatusList)Activator.CreateInstance(typeof(OrderStatusList), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            CheckRules(item);
            MarkNew(item);
            MarkAsChild(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch OrderStatusList.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public OrderStatusList Fetch(OrderStatusCriteria criteria)
        {
            OrderStatusList item = (OrderStatusList)Activator.CreateInstance(typeof(OrderStatusList), true);

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return item;

            // Fetch Child objects.
            string commandText = string.Format("SELECT [OrderId], [LineNum], [Timestamp], [Status] FROM [dbo].[OrderStatus] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                        {
                            do
                            {
                                item.Add(new OrderStatusFactory().Map(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            MarkOld(item);
            MarkAsChild(item);
            OnFetched();
            return item;
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(OrderStatusCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref OrderStatus item, ref bool cancel);

        #endregion
    }
}