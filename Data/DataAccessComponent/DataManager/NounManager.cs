

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

    #region class NounManager
    /// <summary>
    /// This class is used to manage a 'Noun' object.
    /// </summary>
    public class NounManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'NounManager' object.
        /// </summary>
        public NounManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteNoun()
            /// <summary>
            /// This method deletes a 'Noun' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteNoun(DeleteNounStoredProcedure deleteNounProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteNounProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllNouns()
            /// <summary>
            /// This method fetches a  'List<Noun>' object.
            /// This method uses the 'Nouns_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Noun>'</returns>
            /// </summary>
            public List<Noun> FetchAllNouns(FetchAllNounsStoredProcedure fetchAllNounsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Noun> nounCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allNounsDataSet = this.DataHelper.LoadDataSet(fetchAllNounsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allNounsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allNounsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            nounCollection = NounReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return nounCollection;
            }
            #endregion

            #region FindNoun()
            /// <summary>
            /// This method finds a  'Noun' object.
            /// This method uses the 'Noun_Find' procedure.
            /// </summary>
            /// <returns>A 'Noun' object.</returns>
            /// </summary>
            public Noun FindNoun(FindNounStoredProcedure findNounProc, DataConnector databaseConnector)
            {
                // Initial Value
                Noun noun = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet nounDataSet = this.DataHelper.LoadDataSet(findNounProc, databaseConnector);

                    // Verify DataSet Exists
                    if(nounDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(nounDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Noun
                            noun = NounReader.Load(row);
                        }
                    }
                }

                // return value
                return noun;
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

            #region InsertNoun()
            /// <summary>
            /// This method inserts a 'Noun' object.
            /// This method uses the 'Noun_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertNoun(InsertNounStoredProcedure insertNounProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertNounProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateNoun()
            /// <summary>
            /// This method updates a 'Noun'.
            /// This method uses the 'Noun_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateNoun(UpdateNounStoredProcedure updateNounProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateNounProc, databaseConnector);
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
