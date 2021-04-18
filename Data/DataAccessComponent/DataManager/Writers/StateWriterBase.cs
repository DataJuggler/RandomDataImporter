

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

    #region class StateWriterBase
    /// <summary>
    /// This class is used for converting a 'State' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class StateWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(State state)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='state'>The 'State' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(State state)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (state != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", state.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteStateStoredProcedure(State state)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteState'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'State_Delete'.
            /// </summary>
            /// <param name="state">The 'State' to Delete.</param>
            /// <returns>An instance of a 'DeleteStateStoredProcedure' object.</returns>
            public static DeleteStateStoredProcedure CreateDeleteStateStoredProcedure(State state)
            {
                // Initial Value
                DeleteStateStoredProcedure deleteStateStoredProcedure = new DeleteStateStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteStateStoredProcedure.Parameters = CreatePrimaryKeyParameter(state);

                // return value
                return deleteStateStoredProcedure;
            }
            #endregion

            #region CreateFindStateStoredProcedure(State state)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindStateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'State_Find'.
            /// </summary>
            /// <param name="state">The 'State' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindStateStoredProcedure CreateFindStateStoredProcedure(State state)
            {
                // Initial Value
                FindStateStoredProcedure findStateStoredProcedure = null;

                // verify state exists
                if(state != null)
                {
                    // Instanciate findStateStoredProcedure
                    findStateStoredProcedure = new FindStateStoredProcedure();

                    // Now create parameters for this procedure
                    findStateStoredProcedure.Parameters = CreatePrimaryKeyParameter(state);
                }

                // return value
                return findStateStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(State state)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new state.
            /// </summary>
            /// <param name="state">The 'State' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(State state)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[2];
                SqlParameter param = null;

                // verify stateexists
                if(state != null)
                {
                    // Create [Code] parameter
                    param = new SqlParameter("@Code", state.Code);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", state.Name);

                    // set parameters[1]
                    parameters[1] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertStateStoredProcedure(State state)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertStateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'State_Insert'.
            /// </summary>
            /// <param name="state"The 'State' object to insert</param>
            /// <returns>An instance of a 'InsertStateStoredProcedure' object.</returns>
            public static InsertStateStoredProcedure CreateInsertStateStoredProcedure(State state)
            {
                // Initial Value
                InsertStateStoredProcedure insertStateStoredProcedure = null;

                // verify state exists
                if(state != null)
                {
                    // Instanciate insertStateStoredProcedure
                    insertStateStoredProcedure = new InsertStateStoredProcedure();

                    // Now create parameters for this procedure
                    insertStateStoredProcedure.Parameters = CreateInsertParameters(state);
                }

                // return value
                return insertStateStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(State state)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing state.
            /// </summary>
            /// <param name="state">The 'State' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(State state)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify stateexists
                if(state != null)
                {
                    // Create parameter for [Code]
                    param = new SqlParameter("@Code", state.Code);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", state.Name);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", state.Id);
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateStateStoredProcedure(State state)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateStateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'State_Update'.
            /// </summary>
            /// <param name="state"The 'State' object to update</param>
            /// <returns>An instance of a 'UpdateStateStoredProcedure</returns>
            public static UpdateStateStoredProcedure CreateUpdateStateStoredProcedure(State state)
            {
                // Initial Value
                UpdateStateStoredProcedure updateStateStoredProcedure = null;

                // verify state exists
                if(state != null)
                {
                    // Instanciate updateStateStoredProcedure
                    updateStateStoredProcedure = new UpdateStateStoredProcedure();

                    // Now create parameters for this procedure
                    updateStateStoredProcedure.Parameters = CreateUpdateParameters(state);
                }

                // return value
                return updateStateStoredProcedure;
            }
            #endregion

            #region CreateFetchAllStatesStoredProcedure(State state)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllStatesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'State_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllStatesStoredProcedure' object.</returns>
            public static FetchAllStatesStoredProcedure CreateFetchAllStatesStoredProcedure(State state)
            {
                // Initial value
                FetchAllStatesStoredProcedure fetchAllStatesStoredProcedure = new FetchAllStatesStoredProcedure();

                // return value
                return fetchAllStatesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
