

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

    #region class VerbManager
    /// <summary>
    /// This class is used to manage a 'Verb' object.
    /// </summary>
    public class VerbManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'VerbManager' object.
        /// </summary>
        public VerbManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteVerb()
            /// <summary>
            /// This method deletes a 'Verb' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteVerb(DeleteVerbStoredProcedure deleteVerbProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteVerbProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllVerbs()
            /// <summary>
            /// This method fetches a  'List<Verb>' object.
            /// This method uses the 'Verbs_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Verb>'</returns>
            /// </summary>
            public List<Verb> FetchAllVerbs(FetchAllVerbsStoredProcedure fetchAllVerbsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Verb> verbCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allVerbsDataSet = this.DataHelper.LoadDataSet(fetchAllVerbsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allVerbsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allVerbsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            verbCollection = VerbReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return verbCollection;
            }
            #endregion

            #region FindVerb()
            /// <summary>
            /// This method finds a  'Verb' object.
            /// This method uses the 'Verb_Find' procedure.
            /// </summary>
            /// <returns>A 'Verb' object.</returns>
            /// </summary>
            public Verb FindVerb(FindVerbStoredProcedure findVerbProc, DataConnector databaseConnector)
            {
                // Initial Value
                Verb verb = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet verbDataSet = this.DataHelper.LoadDataSet(findVerbProc, databaseConnector);

                    // Verify DataSet Exists
                    if(verbDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(verbDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Verb
                            verb = VerbReader.Load(row);
                        }
                    }
                }

                // return value
                return verb;
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

            #region InsertVerb()
            /// <summary>
            /// This method inserts a 'Verb' object.
            /// This method uses the 'Verb_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertVerb(InsertVerbStoredProcedure insertVerbProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertVerbProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateVerb()
            /// <summary>
            /// This method updates a 'Verb'.
            /// This method uses the 'Verb_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateVerb(UpdateVerbStoredProcedure updateVerbProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateVerbProc, databaseConnector);
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
