

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

    #region class MemberAddressViewManager
    /// <summary>
    /// This class is used to manage a 'MemberAddressView' object.
    /// </summary>
    public class MemberAddressViewManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MemberAddressViewManager' object.
        /// </summary>
        public MemberAddressViewManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region FetchAllMemberAddressViews()
            /// <summary>
            /// This method fetches a  'List<MemberAddressView>' object.
            /// This method uses the 'MemberAddressViews_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<MemberAddressView>'</returns>
            /// </summary>
            public List<MemberAddressView> FetchAllMemberAddressViews(FetchAllMemberAddressViewsStoredProcedure fetchAllMemberAddressViewsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<MemberAddressView> memberAddressViewCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allMemberAddressViewsDataSet = this.DataHelper.LoadDataSet(fetchAllMemberAddressViewsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allMemberAddressViewsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allMemberAddressViewsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            memberAddressViewCollection = MemberAddressViewReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return memberAddressViewCollection;
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
