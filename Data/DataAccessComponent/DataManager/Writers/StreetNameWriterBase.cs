

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

    #region class StreetNameWriterBase
    /// <summary>
    /// This class is used for converting a 'StreetName' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class StreetNameWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(StreetName streetName)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='streetName'>The 'StreetName' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(StreetName streetName)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (streetName != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", streetName.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteStreetNameStoredProcedure(StreetName streetName)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteStreetName'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'StreetName_Delete'.
            /// </summary>
            /// <param name="streetName">The 'StreetName' to Delete.</param>
            /// <returns>An instance of a 'DeleteStreetNameStoredProcedure' object.</returns>
            public static DeleteStreetNameStoredProcedure CreateDeleteStreetNameStoredProcedure(StreetName streetName)
            {
                // Initial Value
                DeleteStreetNameStoredProcedure deleteStreetNameStoredProcedure = new DeleteStreetNameStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteStreetNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(streetName);

                // return value
                return deleteStreetNameStoredProcedure;
            }
            #endregion

            #region CreateFindStreetNameStoredProcedure(StreetName streetName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindStreetNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'StreetName_Find'.
            /// </summary>
            /// <param name="streetName">The 'StreetName' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindStreetNameStoredProcedure CreateFindStreetNameStoredProcedure(StreetName streetName)
            {
                // Initial Value
                FindStreetNameStoredProcedure findStreetNameStoredProcedure = null;

                // verify streetName exists
                if(streetName != null)
                {
                    // Instanciate findStreetNameStoredProcedure
                    findStreetNameStoredProcedure = new FindStreetNameStoredProcedure();

                    // Now create parameters for this procedure
                    findStreetNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(streetName);
                }

                // return value
                return findStreetNameStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(StreetName streetName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new streetName.
            /// </summary>
            /// <param name="streetName">The 'StreetName' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(StreetName streetName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[1];
                SqlParameter param = null;

                // verify streetNameexists
                if(streetName != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", streetName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertStreetNameStoredProcedure(StreetName streetName)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertStreetNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'StreetName_Insert'.
            /// </summary>
            /// <param name="streetName"The 'StreetName' object to insert</param>
            /// <returns>An instance of a 'InsertStreetNameStoredProcedure' object.</returns>
            public static InsertStreetNameStoredProcedure CreateInsertStreetNameStoredProcedure(StreetName streetName)
            {
                // Initial Value
                InsertStreetNameStoredProcedure insertStreetNameStoredProcedure = null;

                // verify streetName exists
                if(streetName != null)
                {
                    // Instanciate insertStreetNameStoredProcedure
                    insertStreetNameStoredProcedure = new InsertStreetNameStoredProcedure();

                    // Now create parameters for this procedure
                    insertStreetNameStoredProcedure.Parameters = CreateInsertParameters(streetName);
                }

                // return value
                return insertStreetNameStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(StreetName streetName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing streetName.
            /// </summary>
            /// <param name="streetName">The 'StreetName' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(StreetName streetName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify streetNameexists
                if(streetName != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", streetName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", streetName.Id);
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateStreetNameStoredProcedure(StreetName streetName)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateStreetNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'StreetName_Update'.
            /// </summary>
            /// <param name="streetName"The 'StreetName' object to update</param>
            /// <returns>An instance of a 'UpdateStreetNameStoredProcedure</returns>
            public static UpdateStreetNameStoredProcedure CreateUpdateStreetNameStoredProcedure(StreetName streetName)
            {
                // Initial Value
                UpdateStreetNameStoredProcedure updateStreetNameStoredProcedure = null;

                // verify streetName exists
                if(streetName != null)
                {
                    // Instanciate updateStreetNameStoredProcedure
                    updateStreetNameStoredProcedure = new UpdateStreetNameStoredProcedure();

                    // Now create parameters for this procedure
                    updateStreetNameStoredProcedure.Parameters = CreateUpdateParameters(streetName);
                }

                // return value
                return updateStreetNameStoredProcedure;
            }
            #endregion

            #region CreateFetchAllStreetNamesStoredProcedure(StreetName streetName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllStreetNamesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'StreetName_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllStreetNamesStoredProcedure' object.</returns>
            public static FetchAllStreetNamesStoredProcedure CreateFetchAllStreetNamesStoredProcedure(StreetName streetName)
            {
                // Initial value
                FetchAllStreetNamesStoredProcedure fetchAllStreetNamesStoredProcedure = new FetchAllStreetNamesStoredProcedure();

                // return value
                return fetchAllStreetNamesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
