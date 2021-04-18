

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

    #region class ZipCodeWriterBase
    /// <summary>
    /// This class is used for converting a 'ZipCode' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ZipCodeWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(ZipCode zipCode)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='zipCode'>The 'ZipCode' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(ZipCode zipCode)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (zipCode != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", zipCode.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteZipCodeStoredProcedure(ZipCode zipCode)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteZipCode'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ZipCode_Delete'.
            /// </summary>
            /// <param name="zipCode">The 'ZipCode' to Delete.</param>
            /// <returns>An instance of a 'DeleteZipCodeStoredProcedure' object.</returns>
            public static DeleteZipCodeStoredProcedure CreateDeleteZipCodeStoredProcedure(ZipCode zipCode)
            {
                // Initial Value
                DeleteZipCodeStoredProcedure deleteZipCodeStoredProcedure = new DeleteZipCodeStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteZipCodeStoredProcedure.Parameters = CreatePrimaryKeyParameter(zipCode);

                // return value
                return deleteZipCodeStoredProcedure;
            }
            #endregion

            #region CreateFindZipCodeStoredProcedure(ZipCode zipCode)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindZipCodeStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ZipCode_Find'.
            /// </summary>
            /// <param name="zipCode">The 'ZipCode' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindZipCodeStoredProcedure CreateFindZipCodeStoredProcedure(ZipCode zipCode)
            {
                // Initial Value
                FindZipCodeStoredProcedure findZipCodeStoredProcedure = null;

                // verify zipCode exists
                if(zipCode != null)
                {
                    // Instanciate findZipCodeStoredProcedure
                    findZipCodeStoredProcedure = new FindZipCodeStoredProcedure();

                    // Now create parameters for this procedure
                    findZipCodeStoredProcedure.Parameters = CreatePrimaryKeyParameter(zipCode);
                }

                // return value
                return findZipCodeStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(ZipCode zipCode)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new zipCode.
            /// </summary>
            /// <param name="zipCode">The 'ZipCode' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(ZipCode zipCode)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify zipCodeexists
                if(zipCode != null)
                {
                    // Create [CityName] parameter
                    param = new SqlParameter("@CityName", zipCode.CityName);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", zipCode.Name);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [StateId] parameter
                    param = new SqlParameter("@StateId", zipCode.StateId);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertZipCodeStoredProcedure(ZipCode zipCode)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertZipCodeStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ZipCode_Insert'.
            /// </summary>
            /// <param name="zipCode"The 'ZipCode' object to insert</param>
            /// <returns>An instance of a 'InsertZipCodeStoredProcedure' object.</returns>
            public static InsertZipCodeStoredProcedure CreateInsertZipCodeStoredProcedure(ZipCode zipCode)
            {
                // Initial Value
                InsertZipCodeStoredProcedure insertZipCodeStoredProcedure = null;

                // verify zipCode exists
                if(zipCode != null)
                {
                    // Instanciate insertZipCodeStoredProcedure
                    insertZipCodeStoredProcedure = new InsertZipCodeStoredProcedure();

                    // Now create parameters for this procedure
                    insertZipCodeStoredProcedure.Parameters = CreateInsertParameters(zipCode);
                }

                // return value
                return insertZipCodeStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(ZipCode zipCode)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing zipCode.
            /// </summary>
            /// <param name="zipCode">The 'ZipCode' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(ZipCode zipCode)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify zipCodeexists
                if(zipCode != null)
                {
                    // Create parameter for [CityName]
                    param = new SqlParameter("@CityName", zipCode.CityName);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", zipCode.Name);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [StateId]
                    param = new SqlParameter("@StateId", zipCode.StateId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", zipCode.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateZipCodeStoredProcedure(ZipCode zipCode)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateZipCodeStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ZipCode_Update'.
            /// </summary>
            /// <param name="zipCode"The 'ZipCode' object to update</param>
            /// <returns>An instance of a 'UpdateZipCodeStoredProcedure</returns>
            public static UpdateZipCodeStoredProcedure CreateUpdateZipCodeStoredProcedure(ZipCode zipCode)
            {
                // Initial Value
                UpdateZipCodeStoredProcedure updateZipCodeStoredProcedure = null;

                // verify zipCode exists
                if(zipCode != null)
                {
                    // Instanciate updateZipCodeStoredProcedure
                    updateZipCodeStoredProcedure = new UpdateZipCodeStoredProcedure();

                    // Now create parameters for this procedure
                    updateZipCodeStoredProcedure.Parameters = CreateUpdateParameters(zipCode);
                }

                // return value
                return updateZipCodeStoredProcedure;
            }
            #endregion

            #region CreateFetchAllZipCodesStoredProcedure(ZipCode zipCode)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllZipCodesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ZipCode_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllZipCodesStoredProcedure' object.</returns>
            public static FetchAllZipCodesStoredProcedure CreateFetchAllZipCodesStoredProcedure(ZipCode zipCode)
            {
                // Initial value
                FetchAllZipCodesStoredProcedure fetchAllZipCodesStoredProcedure = new FetchAllZipCodesStoredProcedure();

                // return value
                return fetchAllZipCodesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
