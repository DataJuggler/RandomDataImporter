

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

    #region class VerbWriterBase
    /// <summary>
    /// This class is used for converting a 'Verb' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class VerbWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Verb verb)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='verb'>The 'Verb' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Verb verb)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (verb != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", verb.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteVerbStoredProcedure(Verb verb)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteVerb'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Verb_Delete'.
            /// </summary>
            /// <param name="verb">The 'Verb' to Delete.</param>
            /// <returns>An instance of a 'DeleteVerbStoredProcedure' object.</returns>
            public static DeleteVerbStoredProcedure CreateDeleteVerbStoredProcedure(Verb verb)
            {
                // Initial Value
                DeleteVerbStoredProcedure deleteVerbStoredProcedure = new DeleteVerbStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteVerbStoredProcedure.Parameters = CreatePrimaryKeyParameter(verb);

                // return value
                return deleteVerbStoredProcedure;
            }
            #endregion

            #region CreateFindVerbStoredProcedure(Verb verb)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindVerbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Verb_Find'.
            /// </summary>
            /// <param name="verb">The 'Verb' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindVerbStoredProcedure CreateFindVerbStoredProcedure(Verb verb)
            {
                // Initial Value
                FindVerbStoredProcedure findVerbStoredProcedure = null;

                // verify verb exists
                if(verb != null)
                {
                    // Instanciate findVerbStoredProcedure
                    findVerbStoredProcedure = new FindVerbStoredProcedure();

                    // Now create parameters for this procedure
                    findVerbStoredProcedure.Parameters = CreatePrimaryKeyParameter(verb);
                }

                // return value
                return findVerbStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Verb verb)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new verb.
            /// </summary>
            /// <param name="verb">The 'Verb' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Verb verb)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify verbexists
                if(verb != null)
                {
                    // Create [Syllables] parameter
                    param = new SqlParameter("@Syllables", verb.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [WordText] parameter
                    param = new SqlParameter("@WordText", verb.WordText);

                    // set parameters[1]
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertVerbStoredProcedure(Verb verb)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertVerbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Verb_Insert'.
            /// </summary>
            /// <param name="verb"The 'Verb' object to insert</param>
            /// <returns>An instance of a 'InsertVerbStoredProcedure' object.</returns>
            public static InsertVerbStoredProcedure CreateInsertVerbStoredProcedure(Verb verb)
            {
                // Initial Value
                InsertVerbStoredProcedure insertVerbStoredProcedure = null;

                // verify verb exists
                if(verb != null)
                {
                    // Instanciate insertVerbStoredProcedure
                    insertVerbStoredProcedure = new InsertVerbStoredProcedure();

                    // Now create parameters for this procedure
                    insertVerbStoredProcedure.Parameters = CreateInsertParameters(verb);
                }

                // return value
                return insertVerbStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Verb verb)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing verb.
            /// </summary>
            /// <param name="verb">The 'Verb' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Verb verb)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify verbexists
                if(verb != null)
                {
                    // Create parameter for [Syllables]
                    param = new SqlParameter("@Syllables", verb.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [WordText]
                    param = new SqlParameter("@WordText", verb.WordText);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", verb.Id);
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateVerbStoredProcedure(Verb verb)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateVerbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Verb_Update'.
            /// </summary>
            /// <param name="verb"The 'Verb' object to update</param>
            /// <returns>An instance of a 'UpdateVerbStoredProcedure</returns>
            public static UpdateVerbStoredProcedure CreateUpdateVerbStoredProcedure(Verb verb)
            {
                // Initial Value
                UpdateVerbStoredProcedure updateVerbStoredProcedure = null;

                // verify verb exists
                if(verb != null)
                {
                    // Instanciate updateVerbStoredProcedure
                    updateVerbStoredProcedure = new UpdateVerbStoredProcedure();

                    // Now create parameters for this procedure
                    updateVerbStoredProcedure.Parameters = CreateUpdateParameters(verb);
                }

                // return value
                return updateVerbStoredProcedure;
            }
            #endregion

            #region CreateFetchAllVerbsStoredProcedure(Verb verb)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllVerbsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Verb_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllVerbsStoredProcedure' object.</returns>
            public static FetchAllVerbsStoredProcedure CreateFetchAllVerbsStoredProcedure(Verb verb)
            {
                // Initial value
                FetchAllVerbsStoredProcedure fetchAllVerbsStoredProcedure = new FetchAllVerbsStoredProcedure();

                // return value
                return fetchAllVerbsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
