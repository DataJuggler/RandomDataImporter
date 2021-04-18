

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

    #region class FirstNameWriterBase
    /// <summary>
    /// This class is used for converting a 'FirstName' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class FirstNameWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(FirstName firstName)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='firstName'>The 'FirstName' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(FirstName firstName)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (firstName != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", firstName.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteFirstNameStoredProcedure(FirstName firstName)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteFirstName'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FirstName_Delete'.
            /// </summary>
            /// <param name="firstName">The 'FirstName' to Delete.</param>
            /// <returns>An instance of a 'DeleteFirstNameStoredProcedure' object.</returns>
            public static DeleteFirstNameStoredProcedure CreateDeleteFirstNameStoredProcedure(FirstName firstName)
            {
                // Initial Value
                DeleteFirstNameStoredProcedure deleteFirstNameStoredProcedure = new DeleteFirstNameStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteFirstNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(firstName);

                // return value
                return deleteFirstNameStoredProcedure;
            }
            #endregion

            #region CreateFindFirstNameStoredProcedure(FirstName firstName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindFirstNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FirstName_Find'.
            /// </summary>
            /// <param name="firstName">The 'FirstName' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindFirstNameStoredProcedure CreateFindFirstNameStoredProcedure(FirstName firstName)
            {
                // Initial Value
                FindFirstNameStoredProcedure findFirstNameStoredProcedure = null;

                // verify firstName exists
                if(firstName != null)
                {
                    // Instanciate findFirstNameStoredProcedure
                    findFirstNameStoredProcedure = new FindFirstNameStoredProcedure();

                    // Now create parameters for this procedure
                    findFirstNameStoredProcedure.Parameters = CreatePrimaryKeyParameter(firstName);
                }

                // return value
                return findFirstNameStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(FirstName firstName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new firstName.
            /// </summary>
            /// <param name="firstName">The 'FirstName' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(FirstName firstName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[1];
                SqlParameter param = null;

                // verify firstNameexists
                if(firstName != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", firstName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertFirstNameStoredProcedure(FirstName firstName)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertFirstNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FirstName_Insert'.
            /// </summary>
            /// <param name="firstName"The 'FirstName' object to insert</param>
            /// <returns>An instance of a 'InsertFirstNameStoredProcedure' object.</returns>
            public static InsertFirstNameStoredProcedure CreateInsertFirstNameStoredProcedure(FirstName firstName)
            {
                // Initial Value
                InsertFirstNameStoredProcedure insertFirstNameStoredProcedure = null;

                // verify firstName exists
                if(firstName != null)
                {
                    // Instanciate insertFirstNameStoredProcedure
                    insertFirstNameStoredProcedure = new InsertFirstNameStoredProcedure();

                    // Now create parameters for this procedure
                    insertFirstNameStoredProcedure.Parameters = CreateInsertParameters(firstName);
                }

                // return value
                return insertFirstNameStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(FirstName firstName)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing firstName.
            /// </summary>
            /// <param name="firstName">The 'FirstName' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(FirstName firstName)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify firstNameexists
                if(firstName != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", firstName.Name);

                    // set parameters[0]
                    parameters[0] = param;
                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", firstName.Id);
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateFirstNameStoredProcedure(FirstName firstName)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateFirstNameStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FirstName_Update'.
            /// </summary>
            /// <param name="firstName"The 'FirstName' object to update</param>
            /// <returns>An instance of a 'UpdateFirstNameStoredProcedure</returns>
            public static UpdateFirstNameStoredProcedure CreateUpdateFirstNameStoredProcedure(FirstName firstName)
            {
                // Initial Value
                UpdateFirstNameStoredProcedure updateFirstNameStoredProcedure = null;

                // verify firstName exists
                if(firstName != null)
                {
                    // Instanciate updateFirstNameStoredProcedure
                    updateFirstNameStoredProcedure = new UpdateFirstNameStoredProcedure();

                    // Now create parameters for this procedure
                    updateFirstNameStoredProcedure.Parameters = CreateUpdateParameters(firstName);
                }

                // return value
                return updateFirstNameStoredProcedure;
            }
            #endregion

            #region CreateFetchAllFirstNamesStoredProcedure(FirstName firstName)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllFirstNamesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'FirstName_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllFirstNamesStoredProcedure' object.</returns>
            public static FetchAllFirstNamesStoredProcedure CreateFetchAllFirstNamesStoredProcedure(FirstName firstName)
            {
                // Initial value
                FetchAllFirstNamesStoredProcedure fetchAllFirstNamesStoredProcedure = new FetchAllFirstNamesStoredProcedure();

                // return value
                return fetchAllFirstNamesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
