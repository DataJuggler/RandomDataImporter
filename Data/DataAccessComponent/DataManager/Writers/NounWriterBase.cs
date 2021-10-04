

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

    #region class NounWriterBase
    /// <summary>
    /// This class is used for converting a 'Noun' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class NounWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Noun noun)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='noun'>The 'Noun' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Noun noun)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (noun != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", noun.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteNounStoredProcedure(Noun noun)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteNoun'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Noun_Delete'.
            /// </summary>
            /// <param name="noun">The 'Noun' to Delete.</param>
            /// <returns>An instance of a 'DeleteNounStoredProcedure' object.</returns>
            public static DeleteNounStoredProcedure CreateDeleteNounStoredProcedure(Noun noun)
            {
                // Initial Value
                DeleteNounStoredProcedure deleteNounStoredProcedure = new DeleteNounStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteNounStoredProcedure.Parameters = CreatePrimaryKeyParameter(noun);

                // return value
                return deleteNounStoredProcedure;
            }
            #endregion

            #region CreateFindNounStoredProcedure(Noun noun)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindNounStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Noun_Find'.
            /// </summary>
            /// <param name="noun">The 'Noun' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindNounStoredProcedure CreateFindNounStoredProcedure(Noun noun)
            {
                // Initial Value
                FindNounStoredProcedure findNounStoredProcedure = null;

                // verify noun exists
                if(noun != null)
                {
                    // Instanciate findNounStoredProcedure
                    findNounStoredProcedure = new FindNounStoredProcedure();

                    // Now create parameters for this procedure
                    findNounStoredProcedure.Parameters = CreatePrimaryKeyParameter(noun);
                }

                // return value
                return findNounStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Noun noun)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new noun.
            /// </summary>
            /// <param name="noun">The 'Noun' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Noun noun)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify nounexists
                if(noun != null)
                {
                    // Create [Syllables] parameter
                    param = new SqlParameter("@Syllables", noun.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [WordText] parameter
                    param = new SqlParameter("@WordText", noun.WordText);

                    // set parameters[1]
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertNounStoredProcedure(Noun noun)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertNounStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Noun_Insert'.
            /// </summary>
            /// <param name="noun"The 'Noun' object to insert</param>
            /// <returns>An instance of a 'InsertNounStoredProcedure' object.</returns>
            public static InsertNounStoredProcedure CreateInsertNounStoredProcedure(Noun noun)
            {
                // Initial Value
                InsertNounStoredProcedure insertNounStoredProcedure = null;

                // verify noun exists
                if(noun != null)
                {
                    // Instanciate insertNounStoredProcedure
                    insertNounStoredProcedure = new InsertNounStoredProcedure();

                    // Now create parameters for this procedure
                    insertNounStoredProcedure.Parameters = CreateInsertParameters(noun);
                }

                // return value
                return insertNounStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Noun noun)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing noun.
            /// </summary>
            /// <param name="noun">The 'Noun' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Noun noun)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify nounexists
                if(noun != null)
                {
                    // Create parameter for [Syllables]
                    param = new SqlParameter("@Syllables", noun.Syllables);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [WordText]
                    param = new SqlParameter("@WordText", noun.WordText);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", noun.Id);
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateNounStoredProcedure(Noun noun)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateNounStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Noun_Update'.
            /// </summary>
            /// <param name="noun"The 'Noun' object to update</param>
            /// <returns>An instance of a 'UpdateNounStoredProcedure</returns>
            public static UpdateNounStoredProcedure CreateUpdateNounStoredProcedure(Noun noun)
            {
                // Initial Value
                UpdateNounStoredProcedure updateNounStoredProcedure = null;

                // verify noun exists
                if(noun != null)
                {
                    // Instanciate updateNounStoredProcedure
                    updateNounStoredProcedure = new UpdateNounStoredProcedure();

                    // Now create parameters for this procedure
                    updateNounStoredProcedure.Parameters = CreateUpdateParameters(noun);
                }

                // return value
                return updateNounStoredProcedure;
            }
            #endregion

            #region CreateFetchAllNounsStoredProcedure(Noun noun)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllNounsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Noun_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllNounsStoredProcedure' object.</returns>
            public static FetchAllNounsStoredProcedure CreateFetchAllNounsStoredProcedure(Noun noun)
            {
                // Initial value
                FetchAllNounsStoredProcedure fetchAllNounsStoredProcedure = new FetchAllNounsStoredProcedure();

                // return value
                return fetchAllNounsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
