

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

    #region class AdverbManager
    /// <summary>
    /// This class is used to manage a 'Adverb' object.
    /// </summary>
    public class AdverbManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'AdverbManager' object.
        /// </summary>
        public AdverbManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteAdverb()
            /// <summary>
            /// This method deletes a 'Adverb' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteAdverb(DeleteAdverbStoredProcedure deleteAdverbProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteAdverbProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllAdverbs()
            /// <summary>
            /// This method fetches a  'List<Adverb>' object.
            /// This method uses the 'Adverbs_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Adverb>'</returns>
            /// </summary>
            public List<Adverb> FetchAllAdverbs(FetchAllAdverbsStoredProcedure fetchAllAdverbsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Adverb> adverbCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allAdverbsDataSet = this.DataHelper.LoadDataSet(fetchAllAdverbsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allAdverbsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allAdverbsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            adverbCollection = AdverbReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return adverbCollection;
            }
            #endregion

            #region FindAdverb()
            /// <summary>
            /// This method finds a  'Adverb' object.
            /// This method uses the 'Adverb_Find' procedure.
            /// </summary>
            /// <returns>A 'Adverb' object.</returns>
            /// </summary>
            public Adverb FindAdverb(FindAdverbStoredProcedure findAdverbProc, DataConnector databaseConnector)
            {
                // Initial Value
                Adverb adverb = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet adverbDataSet = this.DataHelper.LoadDataSet(findAdverbProc, databaseConnector);

                    // Verify DataSet Exists
                    if(adverbDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(adverbDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Adverb
                            adverb = AdverbReader.Load(row);
                        }
                    }
                }

                // return value
                return adverb;
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

            #region InsertAdverb()
            /// <summary>
            /// This method inserts a 'Adverb' object.
            /// This method uses the 'Adverb_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertAdverb(InsertAdverbStoredProcedure insertAdverbProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertAdverbProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateAdverb()
            /// <summary>
            /// This method updates a 'Adverb'.
            /// This method uses the 'Adverb_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateAdverb(UpdateAdverbStoredProcedure updateAdverbProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateAdverbProc, databaseConnector);
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
