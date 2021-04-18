

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

    #region class StreetNameManager
    /// <summary>
    /// This class is used to manage a 'StreetName' object.
    /// </summary>
    public class StreetNameManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'StreetNameManager' object.
        /// </summary>
        public StreetNameManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteStreetName()
            /// <summary>
            /// This method deletes a 'StreetName' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteStreetName(DeleteStreetNameStoredProcedure deleteStreetNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteStreetNameProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllStreetNames()
            /// <summary>
            /// This method fetches a  'List<StreetName>' object.
            /// This method uses the 'StreetNames_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<StreetName>'</returns>
            /// </summary>
            public List<StreetName> FetchAllStreetNames(FetchAllStreetNamesStoredProcedure fetchAllStreetNamesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<StreetName> streetNameCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allStreetNamesDataSet = this.DataHelper.LoadDataSet(fetchAllStreetNamesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allStreetNamesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allStreetNamesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            streetNameCollection = StreetNameReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return streetNameCollection;
            }
            #endregion

            #region FindStreetName()
            /// <summary>
            /// This method finds a  'StreetName' object.
            /// This method uses the 'StreetName_Find' procedure.
            /// </summary>
            /// <returns>A 'StreetName' object.</returns>
            /// </summary>
            public StreetName FindStreetName(FindStreetNameStoredProcedure findStreetNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                StreetName streetName = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet streetNameDataSet = this.DataHelper.LoadDataSet(findStreetNameProc, databaseConnector);

                    // Verify DataSet Exists
                    if(streetNameDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(streetNameDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load StreetName
                            streetName = StreetNameReader.Load(row);
                        }
                    }
                }

                // return value
                return streetName;
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

            #region InsertStreetName()
            /// <summary>
            /// This method inserts a 'StreetName' object.
            /// This method uses the 'StreetName_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertStreetName(InsertStreetNameStoredProcedure insertStreetNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertStreetNameProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateStreetName()
            /// <summary>
            /// This method updates a 'StreetName'.
            /// This method uses the 'StreetName_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateStreetName(UpdateStreetNameStoredProcedure updateStreetNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateStreetNameProc, databaseConnector);
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
