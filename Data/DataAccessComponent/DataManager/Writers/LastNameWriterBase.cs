

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

    #region class LastNameWriterBase
    /// <summary>
    /// This class is used for converting a 'LastName' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class LastNameWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(LastName lastName)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='lastName'>The 'LastName' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(LastName lastName)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (lastName != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", lastName.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteLastNameStoredProcedure(LastName lastName)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteLastName'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'LastName_Delete'.
            /// </summary>
            /// <param name="lastName">The 'LastName' to Delete.</param>
            /// <returns>An instance of a 'DeleteLastNameStoredProcedure' object.</returns>
            public static DeleteLastNameStoredProcedure CreateDeleteLastNameStoredProcedure(LastName lastName)
            {
                // Initial Value
                DeleteLastNameStoredProcedure deleteLastNameStoredProcedure = new DeleteLastNameStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteLastNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(lastName);

                // return value
                return deleteLastNameStoredProcedure;
            }
            #endregion

            #region CreateFindLastNameStoredProcedure(LastName lastName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindLastNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'LastName_Find'.
            /// </summary>
            /// <param name="lastName">The 'LastName' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindLastNameStoredProcedure CreateFindLastNameStoredProcedure(LastName lastName)
            {
                // Initial Value
                FindLastNameStoredProcedure findLastNameStoredProcedure = null;

                // verify lastName exists
                if(lastName != null)
                {
                    // Instanciate findLastNameStoredProcedure
                    findLastNameStoredProcedure = new FindLastNameStoredProcedure();

                    // Now create parameters for this procedure
                    findLastNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(lastName);
                }

                // return value
                return findLastNameStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(LastName lastName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new lastName.
            /// </summary>
            /// <param name="lastName">The 'LastName' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(LastName lastName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[1];
                SqlParameter param = null;

                // verify lastNameexists
                if(lastName != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", lastName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertLastNameStoredProcedure(LastName lastName)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertLastNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'LastName_Insert'.
            /// </summary>
            /// <param name="lastName"The 'LastName' object to insert</param>
            /// <returns>An instance of a 'InsertLastNameStoredProcedure' object.</returns>
            public static InsertLastNameStoredProcedure CreateInsertLastNameStoredProcedure(LastName lastName)
            {
                // Initial Value
                InsertLastNameStoredProcedure insertLastNameStoredProcedure = null;

                // verify lastName exists
                if(lastName != null)
                {
                    // Instanciate insertLastNameStoredProcedure
                    insertLastNameStoredProcedure = new InsertLastNameStoredProcedure();

                    // Now create parameters for this procedure
                    insertLastNameStoredProcedure.Parameters = CreateInsertParameters(lastName);
                }

                // return value
                return insertLastNameStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(LastName lastName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing lastName.
            /// </summary>
            /// <param name="lastName">The 'LastName' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(LastName lastName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify lastNameexists
                if(lastName != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", lastName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", lastName.Id);
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateLastNameStoredProcedure(LastName lastName)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateLastNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'LastName_Update'.
            /// </summary>
            /// <param name="lastName"The 'LastName' object to update</param>
            /// <returns>An instance of a 'UpdateLastNameStoredProcedure</returns>
            public static UpdateLastNameStoredProcedure CreateUpdateLastNameStoredProcedure(LastName lastName)
            {
                // Initial Value
                UpdateLastNameStoredProcedure updateLastNameStoredProcedure = null;

                // verify lastName exists
                if(lastName != null)
                {
                    // Instanciate updateLastNameStoredProcedure
                    updateLastNameStoredProcedure = new UpdateLastNameStoredProcedure();

                    // Now create parameters for this procedure
                    updateLastNameStoredProcedure.Parameters = CreateUpdateParameters(lastName);
                }

                // return value
                return updateLastNameStoredProcedure;
            }
            #endregion

            #region CreateFetchAllLastNamesStoredProcedure(LastName lastName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllLastNamesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'LastName_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllLastNamesStoredProcedure' object.</returns>
            public static FetchAllLastNamesStoredProcedure CreateFetchAllLastNamesStoredProcedure(LastName lastName)
            {
                // Initial value
                FetchAllLastNamesStoredProcedure fetchAllLastNamesStoredProcedure = new FetchAllLastNamesStoredProcedure();

                // return value
                return fetchAllLastNamesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
