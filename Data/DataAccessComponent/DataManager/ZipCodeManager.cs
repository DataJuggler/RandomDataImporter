

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

    #region class ZipCodeManager
    /// <summary>
    /// This class is used to manage a 'ZipCode' object.
    /// </summary>
    public class ZipCodeManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ZipCodeManager' object.
        /// </summary>
        public ZipCodeManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteZipCode()
            /// <summary>
            /// This method deletes a 'ZipCode' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteZipCode(DeleteZipCodeStoredProcedure deleteZipCodeProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteZipCodeProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllZipCodes()
            /// <summary>
            /// This method fetches a  'List<ZipCode>' object.
            /// This method uses the 'ZipCodes_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<ZipCode>'</returns>
            /// </summary>
            public List<ZipCode> FetchAllZipCodes(FetchAllZipCodesStoredProcedure fetchAllZipCodesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<ZipCode> zipCodeCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allZipCodesDataSet = this.DataHelper.LoadDataSet(fetchAllZipCodesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allZipCodesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allZipCodesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            zipCodeCollection = ZipCodeReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return zipCodeCollection;
            }
            #endregion

            #region FindZipCode()
            /// <summary>
            /// This method finds a  'ZipCode' object.
            /// This method uses the 'ZipCode_Find' procedure.
            /// </summary>
            /// <returns>A 'ZipCode' object.</returns>
            /// </summary>
            public ZipCode FindZipCode(FindZipCodeStoredProcedure findZipCodeProc, DataConnector databaseConnector)
            {
                // Initial Value
                ZipCode zipCode = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet zipCodeDataSet = this.DataHelper.LoadDataSet(findZipCodeProc, databaseConnector);

                    // Verify DataSet Exists
                    if(zipCodeDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(zipCodeDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load ZipCode
                            zipCode = ZipCodeReader.Load(row);
                        }
                    }
                }

                // return value
                return zipCode;
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

            #region InsertZipCode()
            /// <summary>
            /// This method inserts a 'ZipCode' object.
            /// This method uses the 'ZipCode_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertZipCode(InsertZipCodeStoredProcedure insertZipCodeProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertZipCodeProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateZipCode()
            /// <summary>
            /// This method updates a 'ZipCode'.
            /// This method uses the 'ZipCode_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateZipCode(UpdateZipCodeStoredProcedure updateZipCodeProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateZipCodeProc, databaseConnector);
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
