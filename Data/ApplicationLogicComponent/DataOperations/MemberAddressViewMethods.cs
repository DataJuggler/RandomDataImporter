

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class MemberAddressViewMethods
    /// <summary>
    /// This class contains methods for modifying a 'MemberAddressView' object.
    /// </summary>
    public class MemberAddressViewMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'MemberAddressViewMethods' object.
        /// </summary>
        public MemberAddressViewMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'MemberAddressView' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'MemberAddressView' to delete.
            /// <returns>A PolymorphicObject object with all  'MemberAddressViews' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<MemberAddressView> memberAddressViewListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllMemberAddressViewsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get MemberAddressViewParameter
                    // Declare Parameter
                    MemberAddressView paramMemberAddressView = null;

                    // verify the first parameters is a(n) 'MemberAddressView'.
                    if (parameters[0].ObjectValue as MemberAddressView != null)
                    {
                        // Get MemberAddressViewParameter
                        paramMemberAddressView = (MemberAddressView) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllMemberAddressViewsProc from MemberAddressViewWriter
                    fetchAllProc = MemberAddressViewWriter.CreateFetchAllMemberAddressViewsStoredProcedure(paramMemberAddressView);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    memberAddressViewListCollection = this.DataManager.MemberAddressViewManager.FetchAllMemberAddressViews(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(memberAddressViewListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = memberAddressViewListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
