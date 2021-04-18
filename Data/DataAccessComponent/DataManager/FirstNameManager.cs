

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

    #region class FirstNameManager
    /// <summary>
    /// This class is used to manage a 'FirstName' object.
    /// </summary>
    public class FirstNameManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FirstNameManager' object.
        /// </summary>
        public FirstNameManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteFirstName()
            /// <summary>
            /// This method deletes a 'FirstName' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteFirstName(DeleteFirstNameStoredProcedure deleteFirstNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteFirstNameProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllFirstNames()
            /// <summary>
            /// This method fetches a  'List<FirstName>' object.
            /// This method uses the 'FirstNames_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<FirstName>'</returns>
            /// </summary>
            public List<FirstName> FetchAllFirstNames(FetchAllFirstNamesStoredProcedure fetchAllFirstNamesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<FirstName> firstNameCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allFirstNamesDataSet = this.DataHelper.LoadDataSet(fetchAllFirstNamesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allFirstNamesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allFirstNamesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            firstNameCollection = FirstNameReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return firstNameCollection;
            }
            #endregion

            #region FindFirstName()
            /// <summary>
            /// This method finds a  'FirstName' object.
            /// This method uses the 'FirstName_Find' procedure.
            /// </summary>
            /// <returns>A 'FirstName' object.</returns>
            /// </summary>
            public FirstName FindFirstName(FindFirstNameStoredProcedure findFirstNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                FirstName firstName = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet firstNameDataSet = this.DataHelper.LoadDataSet(findFirstNameProc, databaseConnector);

                    // Verify DataSet Exists
                    if(firstNameDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(firstNameDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load FirstName
                            firstName = FirstNameReader.Load(row);
                        }
                    }
                }

                // return value
                return firstName;
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

            #region InsertFirstName()
            /// <summary>
            /// This method inserts a 'FirstName' object.
            /// This method uses the 'FirstName_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertFirstName(InsertFirstNameStoredProcedure insertFirstNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertFirstNameProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateFirstName()
            /// <summary>
            /// This method updates a 'FirstName'.
            /// This method uses the 'FirstName_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateFirstName(UpdateFirstNameStoredProcedure updateFirstNameProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateFirstNameProc, databaseConnector);
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
