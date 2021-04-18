

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

    #region class MemberManager
    /// <summary>
    /// This class is used to manage a 'Member' object.
    /// </summary>
    public class MemberManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MemberManager' object.
        /// </summary>
        public MemberManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteMember()
            /// <summary>
            /// This method deletes a 'Member' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteMember(DeleteMemberStoredProcedure deleteMemberProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteMemberProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllMembers()
            /// <summary>
            /// This method fetches a  'List<Member>' object.
            /// This method uses the 'Members_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Member>'</returns>
            /// </summary>
            public List<Member> FetchAllMembers(FetchAllMembersStoredProcedure fetchAllMembersProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Member> memberCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allMembersDataSet = this.DataHelper.LoadDataSet(fetchAllMembersProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allMembersDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allMembersDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            memberCollection = MemberReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return memberCollection;
            }
            #endregion

            #region FindMember()
            /// <summary>
            /// This method finds a  'Member' object.
            /// This method uses the 'Member_Find' procedure.
            /// </summary>
            /// <returns>A 'Member' object.</returns>
            /// </summary>
            public Member FindMember(FindMemberStoredProcedure findMemberProc, DataConnector databaseConnector)
            {
                // Initial Value
                Member member = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet memberDataSet = this.DataHelper.LoadDataSet(findMemberProc, databaseConnector);

                    // Verify DataSet Exists
                    if(memberDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(memberDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Member
                            member = MemberReader.Load(row);
                        }
                    }
                }

                // return value
                return member;
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

            #region InsertMember()
            /// <summary>
            /// This method inserts a 'Member' object.
            /// This method uses the 'Member_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertMember(InsertMemberStoredProcedure insertMemberProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertMemberProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateMember()
            /// <summary>
            /// This method updates a 'Member'.
            /// This method uses the 'Member_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateMember(UpdateMemberStoredProcedure updateMemberProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateMemberProc, databaseConnector);
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
