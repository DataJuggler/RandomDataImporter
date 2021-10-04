

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class MemberAddressViewWriterBase
    /// <summary>
    /// This class is used for converting a 'MemberAddressView' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class MemberAddressViewWriterBase
    {

        #region Static Methods

            #region CreateFetchAllMemberAddressViewsStoredProcedure(MemberAddressView memberAddressView)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllMemberAddressViewsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'MemberAddressView_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllMemberAddressViewsStoredProcedure' object.</returns>
            public static FetchAllMemberAddressViewsStoredProcedure CreateFetchAllMemberAddressViewsStoredProcedure(MemberAddressView memberAddressView)
            {
                // Initial value
                FetchAllMemberAddressViewsStoredProcedure fetchAllMemberAddressViewsStoredProcedure = new FetchAllMemberAddressViewsStoredProcedure();

                // return value
                return fetchAllMemberAddressViewsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
