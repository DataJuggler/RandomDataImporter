

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class AddressWriterBase
    /// <summary>
    /// This class is used for converting a 'Address' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class AddressWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Address address)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='address'>The 'Address' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Address address)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (address != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", address.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteAddressStoredProcedure(Address address)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteAddress'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Address_Delete'.
            /// </summary>
            /// <param name="address">The 'Address' to Delete.</param>
            /// <returns>An instance of a 'DeleteAddressStoredProcedure' object.</returns>
            public static DeleteAddressStoredProcedure CreateDeleteAddressStoredProcedure(Address address)
            {
                // Initial Value
                DeleteAddressStoredProcedure deleteAddressStoredProcedure = new DeleteAddressStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteAddressStoredProcedure.Parameters = CreatePrimaryKeyParameter(address);

                // return value
                return deleteAddressStoredProcedure;
            }
            #endregion

            #region CreateFindAddressStoredProcedure(Address address)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindAddressStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Address_Find'.
            /// </summary>
            /// <param name="address">The 'Address' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindAddressStoredProcedure CreateFindAddressStoredProcedure(Address address)
            {
                // Initial Value
                FindAddressStoredProcedure findAddressStoredProcedure = null;

                // verify address exists
                if(address != null)
                {
                    // Instanciate findAddressStoredProcedure
                    findAddressStoredProcedure = new FindAddressStoredProcedure();

                    // Now create parameters for this procedure
                    findAddressStoredProcedure.Parameters = CreatePrimaryKeyParameter(address);
                }

                // return value
                return findAddressStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Address address)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new address.
            /// </summary>
            /// <param name="address">The 'Address' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Address address)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify addressexists
                if(address != null)
                {
                    // Create [City] parameter
                    param = new SqlParameter("@City", address.City);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [MemberId] parameter
                    param = new SqlParameter("@MemberId", address.MemberId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [StateId] parameter
                    param = new SqlParameter("@StateId", address.StateId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [StreetAddress] parameter
                    param = new SqlParameter("@StreetAddress", address.StreetAddress);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [Unit] parameter
                    param = new SqlParameter("@Unit", address.Unit);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [ZipCode] parameter
                    param = new SqlParameter("@ZipCode", address.ZipCode);

                    // set parameters[5]
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertAddressStoredProcedure(Address address)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertAddressStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Address_Insert'.
            /// </summary>
            /// <param name="address"The 'Address' object to insert</param>
            /// <returns>An instance of a 'InsertAddressStoredProcedure' object.</returns>
            public static InsertAddressStoredProcedure CreateInsertAddressStoredProcedure(Address address)
            {
                // Initial Value
                InsertAddressStoredProcedure insertAddressStoredProcedure = null;

                // verify address exists
                if(address != null)
                {
                    // Instanciate insertAddressStoredProcedure
                    insertAddressStoredProcedure = new InsertAddressStoredProcedure();

                    // Now create parameters for this procedure
                    insertAddressStoredProcedure.Parameters = CreateInsertParameters(address);
                }

                // return value
                return insertAddressStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Address address)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing address.
            /// </summary>
            /// <param name="address">The 'Address' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Address address)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[7];
                SqlParameter param = null;

                // verify addressexists
                if(address != null)
                {
                    // Create parameter for [City]
                    param = new SqlParameter("@City", address.City);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [MemberId]
                    param = new SqlParameter("@MemberId", address.MemberId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [StateId]
                    param = new SqlParameter("@StateId", address.StateId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [StreetAddress]
                    param = new SqlParameter("@StreetAddress", address.StreetAddress);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Unit]
                    param = new SqlParameter("@Unit", address.Unit);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [ZipCode]
                    param = new SqlParameter("@ZipCode", address.ZipCode);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", address.Id);
                    parameters[6] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateAddressStoredProcedure(Address address)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateAddressStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Address_Update'.
            /// </summary>
            /// <param name="address"The 'Address' object to update</param>
            /// <returns>An instance of a 'UpdateAddressStoredProcedure</returns>
            public static UpdateAddressStoredProcedure CreateUpdateAddressStoredProcedure(Address address)
            {
                // Initial Value
                UpdateAddressStoredProcedure updateAddressStoredProcedure = null;

                // verify address exists
                if(address != null)
                {
                    // Instanciate updateAddressStoredProcedure
                    updateAddressStoredProcedure = new UpdateAddressStoredProcedure();

                    // Now create parameters for this procedure
                    updateAddressStoredProcedure.Parameters = CreateUpdateParameters(address);
                }

                // return value
                return updateAddressStoredProcedure;
            }
            #endregion

            #region CreateFetchAllAddressesStoredProcedure(Address address)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllAddressesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Address_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllAddressesStoredProcedure' object.</returns>
            public static FetchAllAddressesStoredProcedure CreateFetchAllAddressesStoredProcedure(Address address)
            {
                // Initial value
                FetchAllAddressesStoredProcedure fetchAllAddressesStoredProcedure = new FetchAllAddressesStoredProcedure();

                // return value
                return fetchAllAddressesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
