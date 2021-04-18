

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

    #region class AdverbWriterBase
    /// <summary>
    /// This class is used for converting a 'Adverb' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class AdverbWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Adverb adverb)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='adverb'>The 'Adverb' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Adverb adverb)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (adverb != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", adverb.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteAdverbStoredProcedure(Adverb adverb)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteAdverb'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adverb_Delete'.
            /// </summary>
            /// <param name="adverb">The 'Adverb' to Delete.</param>
            /// <returns>An instance of a 'DeleteAdverbStoredProcedure' object.</returns>
            public static DeleteAdverbStoredProcedure CreateDeleteAdverbStoredProcedure(Adverb adverb)
            {
                // Initial Value
                DeleteAdverbStoredProcedure deleteAdverbStoredProcedure = new DeleteAdverbStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteAdverbStoredProcedure.Parameters = CreatePrimaryKeyParameter(adverb);

                // return value
                return deleteAdverbStoredProcedure;
            }
            #endregion

            #region CreateFindAdverbStoredProcedure(Adverb adverb)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindAdverbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adverb_Find'.
            /// </summary>
            /// <param name="adverb">The 'Adverb' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindAdverbStoredProcedure CreateFindAdverbStoredProcedure(Adverb adverb)
            {
                // Initial Value
                FindAdverbStoredProcedure findAdverbStoredProcedure = null;

                // verify adverb exists
                if(adverb != null)
                {
                    // Instanciate findAdverbStoredProcedure
                    findAdverbStoredProcedure = new FindAdverbStoredProcedure();

                    // Now create parameters for this procedure
                    findAdverbStoredProcedure.Parameters = CreatePrimaryKeyParameter(adverb);
                }

                // return value
                return findAdverbStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Adverb adverb)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new adverb.
            /// </summary>
            /// <param name="adverb">The 'Adverb' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Adverb adverb)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify adverbexists
                if(adverb != null)
                {
                    // Create [Syllables] parameter
                    param = new SqlParameter("@Syllables", adverb.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [WordText] parameter
                    param = new SqlParameter("@WordText", adverb.WordText);

                    // set parameters[1]
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertAdverbStoredProcedure(Adverb adverb)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertAdverbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adverb_Insert'.
            /// </summary>
            /// <param name="adverb"The 'Adverb' object to insert</param>
            /// <returns>An instance of a 'InsertAdverbStoredProcedure' object.</returns>
            public static InsertAdverbStoredProcedure CreateInsertAdverbStoredProcedure(Adverb adverb)
            {
                // Initial Value
                InsertAdverbStoredProcedure insertAdverbStoredProcedure = null;

                // verify adverb exists
                if(adverb != null)
                {
                    // Instanciate insertAdverbStoredProcedure
                    insertAdverbStoredProcedure = new InsertAdverbStoredProcedure();

                    // Now create parameters for this procedure
                    insertAdverbStoredProcedure.Parameters = CreateInsertParameters(adverb);
                }

                // return value
                return insertAdverbStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Adverb adverb)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing adverb.
            /// </summary>
            /// <param name="adverb">The 'Adverb' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Adverb adverb)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify adverbexists
                if(adverb != null)
                {
                    // Create parameter for [Syllables]
                    param = new SqlParameter("@Syllables", adverb.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [WordText]
                    param = new SqlParameter("@WordText", adverb.WordText);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", adverb.Id);
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateAdverbStoredProcedure(Adverb adverb)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateAdverbStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adverb_Update'.
            /// </summary>
            /// <param name="adverb"The 'Adverb' object to update</param>
            /// <returns>An instance of a 'UpdateAdverbStoredProcedure</returns>
            public static UpdateAdverbStoredProcedure CreateUpdateAdverbStoredProcedure(Adverb adverb)
            {
                // Initial Value
                UpdateAdverbStoredProcedure updateAdverbStoredProcedure = null;

                // verify adverb exists
                if(adverb != null)
                {
                    // Instanciate updateAdverbStoredProcedure
                    updateAdverbStoredProcedure = new UpdateAdverbStoredProcedure();

                    // Now create parameters for this procedure
                    updateAdverbStoredProcedure.Parameters = CreateUpdateParameters(adverb);
                }

                // return value
                return updateAdverbStoredProcedure;
            }
            #endregion

            #region CreateFetchAllAdverbsStoredProcedure(Adverb adverb)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllAdverbsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Adverb_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllAdverbsStoredProcedure' object.</returns>
            public static FetchAllAdverbsStoredProcedure CreateFetchAllAdverbsStoredProcedure(Adverb adverb)
            {
                // Initial value
                FetchAllAdverbsStoredProcedure fetchAllAdverbsStoredProcedure = new FetchAllAdverbsStoredProcedure();

                // return value
                return fetchAllAdverbsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
