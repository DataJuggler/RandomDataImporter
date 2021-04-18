

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class StateManager
    /// <summary>
    /// This class is used to manage a 'State' object.
    /// </summary>
    public class StateManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'StateManager' object.
        /// </summary>
        public StateManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteState()
            /// <summary>
            /// This method deletes a 'State' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteState(DeleteStateStoredProcedure deleteStateProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteStateProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllStates()
            /// <summary>
            /// This method fetches a  'List<State>' object.
            /// This method uses the 'States_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<State>'</returns>
            /// </summary>
            public List<State> FetchAllStates(FetchAllStatesStoredProcedure fetchAllStatesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<State> stateCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allStatesDataSet = this.DataHelper.LoadDataSet(fetchAllStatesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allStatesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allStatesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            stateCollection = StateReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return stateCollection;
            }
            #endregion

            #region FindState()
            /// <summary>
            /// This method finds a  'State' object.
            /// This method uses the 'State_Find' procedure.
            /// </summary>
            /// <returns>A 'State' object.</returns>
            /// </summary>
            public State FindState(FindStateStoredProcedure findStateProc, DataConnector databaseConnector)
            {
                // Initial Value
                State state = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet stateDataSet = this.DataHelper.LoadDataSet(findStateProc, databaseConnector);

                    // Verify DataSet Exists
                    if(stateDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(stateDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load State
                            state = StateReader.Load(row);
                        }
                    }
                }

                // return value
                return state;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertState()
            /// <summary>
            /// This method inserts a 'State' object.
            /// This method uses the 'State_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertState(InsertStateStoredProcedure insertStateProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertStateProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateState()
            /// <summary>
            /// This method updates a 'State'.
            /// This method uses the 'State_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateState(UpdateStateStoredProcedure updateStateProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateStateProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
