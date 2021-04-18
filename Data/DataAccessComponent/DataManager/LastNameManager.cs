

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

    #region class LastNameManager
    /// <summary>
    /// This class is used to manage a 'LastName' object.
    /// </summary>
    public class LastNameManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'LastNameManager' object.
        /// </summary>
        public LastNameManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteLastName()
            /// <summary>
            /// This method deletes a 'LastName' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteLastName(DeleteLastNameStoredProcedure deleteLastNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteLastNameProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllLastNames()
            /// <summary>
            /// This method fetches a  'List<LastName>' object.
            /// This method uses the 'LastNames_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<LastName>'</returns>
            /// </summary>
            public List<LastName> FetchAllLastNames(FetchAllLastNamesStoredProcedure fetchAllLastNamesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<LastName> lastNameCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allLastNamesDataSet = this.DataHelper.LoadDataSet(fetchAllLastNamesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allLastNamesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allLastNamesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            lastNameCollection = LastNameReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return lastNameCollection;
            }
            #endregion

            #region FindLastName()
            /// <summary>
            /// This method finds a  'LastName' object.
            /// This method uses the 'LastName_Find' procedure.
            /// </summary>
            /// <returns>A 'LastName' object.</returns>
            /// </summary>
            public LastName FindLastName(FindLastNameStoredProcedure findLastNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                LastName lastName = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet lastNameDataSet = this.DataHelper.LoadDataSet(findLastNameProc, databaseConnector);

                    // Verify DataSet Exists
                    if(lastNameDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(lastNameDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load LastName
                            lastName = LastNameReader.Load(row);
                        }
                    }
                }

                // return value
                return lastName;
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

            #region InsertLastName()
            /// <summary>
            /// This method inserts a 'LastName' object.
            /// This method uses the 'LastName_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertLastName(InsertLastNameStoredProcedure insertLastNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertLastNameProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateLastName()
            /// <summary>
            /// This method updates a 'LastName'.
            /// This method uses the 'LastName_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateLastName(UpdateLastNameStoredProcedure updateLastNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateLastNameProc, databaseConnector);
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
