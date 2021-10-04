

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

    #region class AdjectiveWriterBase
    /// <summary>
    /// This class is used for converting a 'Adjective' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class AdjectiveWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Adjective adjective)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='adjective'>The 'Adjective' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Adjective adjective)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (adjective != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", adjective.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteAdjectiveStoredProcedure(Adjective adjective)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteAdjective'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adjective_Delete'.
            /// </summary>
            /// <param name="adjective">The 'Adjective' to Delete.</param>
            /// <returns>An instance of a 'DeleteAdjectiveStoredProcedure' object.</returns>
            public static DeleteAdjectiveStoredProcedure CreateDeleteAdjectiveStoredProcedure(Adjective adjective)
            {
                // Initial Value
                DeleteAdjectiveStoredProcedure deleteAdjectiveStoredProcedure = new DeleteAdjectiveStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteAdjectiveStoredProcedure.Parameters = CreatePrimaryKeyParameter(adjective);

                // return value
                return deleteAdjectiveStoredProcedure;
            }
            #endregion

            #region CreateFindAdjectiveStoredProcedure(Adjective adjective)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindAdjectiveStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adjective_Find'.
            /// </summary>
            /// <param name="adjective">The 'Adjective' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindAdjectiveStoredProcedure CreateFindAdjectiveStoredProcedure(Adjective adjective)
            {
                // Initial Value
                FindAdjectiveStoredProcedure findAdjectiveStoredProcedure = null;

                // verify adjective exists
                if(adjective != null)
                {
                    // Instanciate findAdjectiveStoredProcedure
                    findAdjectiveStoredProcedure = new FindAdjectiveStoredProcedure();

                    // Now create parameters for this procedure
                    findAdjectiveStoredProcedure.Parameters = CreatePrimaryKeyParameter(adjective);
                }

                // return value
                return findAdjectiveStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Adjective adjective)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new adjective.
            /// </summary>
            /// <param name="adjective">The 'Adjective' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Adjective adjective)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify adjectiveexists
                if(adjective != null)
                {
                    // Create [Syllables] parameter
                    param = new SqlParameter("@Syllables", adjective.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [WordText] parameter
                    param = new SqlParameter("@WordText", adjective.WordText);

                    // set parameters[1]
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertAdjectiveStoredProcedure(Adjective adjective)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertAdjectiveStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adjective_Insert'.
            /// </summary>
            /// <param name="adjective"The 'Adjective' object to insert</param>
            /// <returns>An instance of a 'InsertAdjectiveStoredProcedure' object.</returns>
            public static InsertAdjectiveStoredProcedure CreateInsertAdjectiveStoredProcedure(Adjective adjective)
            {
                // Initial Value
                InsertAdjectiveStoredProcedure insertAdjectiveStoredProcedure = null;

                // verify adjective exists
                if(adjective != null)
                {
                    // Instanciate insertAdjectiveStoredProcedure
                    insertAdjectiveStoredProcedure = new InsertAdjectiveStoredProcedure();

                    // Now create parameters for this procedure
                    insertAdjectiveStoredProcedure.Parameters = CreateInsertParameters(adjective);
                }

                // return value
                return insertAdjectiveStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Adjective adjective)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing adjective.
            /// </summary>
            /// <param name="adjective">The 'Adjective' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Adjective adjective)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify adjectiveexists
                if(adjective != null)
                {
                    // Create parameter for [Syllables]
                    param = new SqlParameter("@Syllables", adjective.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [WordText]
                    param = new SqlParameter("@WordText", adjective.WordText);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", adjective.Id);
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateAdjectiveStoredProcedure(Adjective adjective)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateAdjectiveStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adjective_Update'.
            /// </summary>
            /// <param name="adjective"The 'Adjective' object to update</param>
            /// <returns>An instance of a 'UpdateAdjectiveStoredProcedure</returns>
            public static UpdateAdjectiveStoredProcedure CreateUpdateAdjectiveStoredProcedure(Adjective adjective)
            {
                // Initial Value
                UpdateAdjectiveStoredProcedure updateAdjectiveStoredProcedure = null;

                // verify adjective exists
                if(adjective != null)
                {
                    // Instanciate updateAdjectiveStoredProcedure
                    updateAdjectiveStoredProcedure = new UpdateAdjectiveStoredProcedure();

                    // Now create parameters for this procedure
                    updateAdjectiveStoredProcedure.Parameters = CreateUpdateParameters(adjective);
                }

                // return value
                return updateAdjectiveStoredProcedure;
            }
            #endregion

            #region CreateFetchAllAdjectivesStoredProcedure(Adjective adjective)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllAdjectivesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adjective_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllAdjectivesStoredProcedure' object.</returns>
            public static FetchAllAdjectivesStoredProcedure CreateFetchAllAdjectivesStoredProcedure(Adjective adjective)
            {
                // Initial value
                FetchAllAdjectivesStoredProcedure fetchAllAdjectivesStoredProcedure = new FetchAllAdjectivesStoredProcedure();

                // return value
                return fetchAllAdjectivesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
