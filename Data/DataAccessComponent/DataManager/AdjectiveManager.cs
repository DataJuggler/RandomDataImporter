

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

    #region class AdjectiveManager
    /// <summary>
    /// This class is used to manage a 'Adjective' object.
    /// </summary>
    public class AdjectiveManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'AdjectiveManager' object.
        /// </summary>
        public AdjectiveManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteAdjective()
            /// <summary>
            /// This method deletes a 'Adjective' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteAdjective(DeleteAdjectiveStoredProcedure deleteAdjectiveProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteAdjectiveProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllAdjectives()
            /// <summary>
            /// This method fetches a  'List<Adjective>' object.
            /// This method uses the 'Adjectives_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Adjective>'</returns>
            /// </summary>
            public List<Adjective> FetchAllAdjectives(FetchAllAdjectivesStoredProcedure fetchAllAdjectivesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Adjective> adjectiveCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allAdjectivesDataSet = this.DataHelper.LoadDataSet(fetchAllAdjectivesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allAdjectivesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allAdjectivesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            adjectiveCollection = AdjectiveReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return adjectiveCollection;
            }
            #endregion

            #region FindAdjective()
            /// <summary>
            /// This method finds a  'Adjective' object.
            /// This method uses the 'Adjective_Find' procedure.
            /// </summary>
            /// <returns>A 'Adjective' object.</returns>
            /// </summary>
            public Adjective FindAdjective(FindAdjectiveStoredProcedure findAdjectiveProc, DataConnector databaseConnector)
            {
                // Initial Value
                Adjective adjective = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet adjectiveDataSet = this.DataHelper.LoadDataSet(findAdjectiveProc, databaseConnector);

                    // Verify DataSet Exists
                    if(adjectiveDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(adjectiveDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Adjective
                            adjective = AdjectiveReader.Load(row);
                        }
                    }
                }

                // return value
                return adjective;
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

            #region InsertAdjective()
            /// <summary>
            /// This method inserts a 'Adjective' object.
            /// This method uses the 'Adjective_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertAdjective(InsertAdjectiveStoredProcedure insertAdjectiveProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertAdjectiveProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateAdjective()
            /// <summary>
            /// This method updates a 'Adjective'.
            /// This method uses the 'Adjective_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateAdjective(UpdateAdjectiveStoredProcedure updateAdjectiveProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateAdjectiveProc, databaseConnector);
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
