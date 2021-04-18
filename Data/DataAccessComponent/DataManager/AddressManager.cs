

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

    #region class AddressManager
    /// <summary>
    /// This class is used to manage a 'Address' object.
    /// </summary>
    public class AddressManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'AddressManager' object.
        /// </summary>
        public AddressManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteAddress()
            /// <summary>
            /// This method deletes a 'Address' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteAddress(DeleteAddressStoredProcedure deleteAddressProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteAddressProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllAddresses()
            /// <summary>
            /// This method fetches a  'List<Address>' object.
            /// This method uses the 'Addresses_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Address>'</returns>
            /// </summary>
            public List<Address> FetchAllAddresses(FetchAllAddressesStoredProcedure fetchAllAddressesProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Address> addressCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allAddressesDataSet = this.DataHelper.LoadDataSet(fetchAllAddressesProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allAddressesDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allAddressesDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            addressCollection = AddressReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return addressCollection;
            }
            #endregion

            #region FindAddress()
            /// <summary>
            /// This method finds a  'Address' object.
            /// This method uses the 'Address_Find' procedure.
            /// </summary>
            /// <returns>A 'Address' object.</returns>
            /// </summary>
            public Address FindAddress(FindAddressStoredProcedure findAddressProc, DataConnector databaseConnector)
            {
                // Initial Value
                Address address = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet addressDataSet = this.DataHelper.LoadDataSet(findAddressProc, databaseConnector);

                    // Verify DataSet Exists
                    if(addressDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(addressDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Address
                            address = AddressReader.Load(row);
                        }
                    }
                }

                // return value
                return address;
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

            #region InsertAddress()
            /// <summary>
            /// This method inserts a 'Address' object.
            /// This method uses the 'Address_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertAddress(InsertAddressStoredProcedure insertAddressProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertAddressProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateAddress()
            /// <summary>
            /// This method updates a 'Address'.
            /// This method uses the 'Address_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateAddress(UpdateAddressStoredProcedure updateAddressProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateAddressProc, databaseConnector);
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
