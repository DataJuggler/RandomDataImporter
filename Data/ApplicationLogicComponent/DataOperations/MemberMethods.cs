

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

    #region class MemberMethods
    /// <summary>
    /// This class contains methods for modifying a 'Member' object.
    /// </summary>
    public class MemberMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'MemberMethods' object.
        /// </summary>
        public MemberMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteMember(Member)
            /// <summary>
            /// This method deletes a 'Member' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Member' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteMember(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteMemberStoredProcedure deleteMemberProc = null;

                    // verify the first parameters is a(n) 'Member'.
                    if (parameters[0].ObjectValue as Member != null)
                    {
                        // Create Member
                        Member member = (Member) parameters[0].ObjectValue;

                        // verify member exists
                        if(member != null)
                        {
                            // Now create deleteMemberProc from MemberWriter
                            // The DataWriter converts the 'Member'
                            // to the SqlParameter[] array needed to delete a 'Member'.
                            deleteMemberProc = MemberWriter.CreateDeleteMemberStoredProcedure(member);
                        }
                    }

                    // Verify deleteMemberProc exists
                    if(deleteMemberProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.MemberManager.DeleteMember(deleteMemberProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
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

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'Member' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Member' to delete.
            /// <returns>A PolymorphicObject object with all  'Members' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Member> memberListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllMembersStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get MemberParameter
                    // Declare Parameter
                    Member paramMember = null;

                    // verify the first parameters is a(n) 'Member'.
                    if (parameters[0].ObjectValue as Member != null)
                    {
                        // Get MemberParameter
                        paramMember = (Member) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllMembersProc from MemberWriter
                    fetchAllProc = MemberWriter.CreateFetchAllMembersStoredProcedure(paramMember);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    memberListCollection = this.DataManager.MemberManager.FetchAllMembers(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(memberListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = memberListCollection;
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

            #region FindMember(Member)
            /// <summary>
            /// This method finds a 'Member' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Member' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindMember(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Member member = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindMemberStoredProcedure findMemberProc = null;

                    // verify the first parameters is a 'Member'.
                    if (parameters[0].ObjectValue as Member != null)
                    {
                        // Get MemberParameter
                        Member paramMember = (Member) parameters[0].ObjectValue;

                        // verify paramMember exists
                        if(paramMember != null)
                        {
                            // Now create findMemberProc from MemberWriter
                            // The DataWriter converts the 'Member'
                            // to the SqlParameter[] array needed to find a 'Member'.
                            findMemberProc = MemberWriter.CreateFindMemberStoredProcedure(paramMember);
                        }

                        // Verify findMemberProc exists
                        if(findMemberProc != null)
                        {
                            // Execute Find Stored Procedure
                            member = this.DataManager.MemberManager.FindMember(findMemberProc, dataConnector);

                            // if dataObject exists
                            if(member != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = member;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertMember (Member)
            /// <summary>
            /// This method inserts a 'Member' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Member' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertMember(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Member member = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertMemberStoredProcedure insertMemberProc = null;

                    // verify the first parameters is a(n) 'Member'.
                    if (parameters[0].ObjectValue as Member != null)
                    {
                        // Create Member Parameter
                        member = (Member) parameters[0].ObjectValue;

                        // verify member exists
                        if(member != null)
                        {
                            // Now create insertMemberProc from MemberWriter
                            // The DataWriter converts the 'Member'
                            // to the SqlParameter[] array needed to insert a 'Member'.
                            insertMemberProc = MemberWriter.CreateInsertMemberStoredProcedure(member);
                        }

                        // Verify insertMemberProc exists
                        if(insertMemberProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.MemberManager.InsertMember(insertMemberProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateMember (Member)
            /// <summary>
            /// This method updates a 'Member' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Member' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateMember(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Member member = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateMemberStoredProcedure updateMemberProc = null;

                    // verify the first parameters is a(n) 'Member'.
                    if (parameters[0].ObjectValue as Member != null)
                    {
                        // Create Member Parameter
                        member = (Member) parameters[0].ObjectValue;

                        // verify member exists
                        if(member != null)
                        {
                            // Now create updateMemberProc from MemberWriter
                            // The DataWriter converts the 'Member'
                            // to the SqlParameter[] array needed to update a 'Member'.
                            updateMemberProc = MemberWriter.CreateUpdateMemberStoredProcedure(member);
                        }

                        // Verify updateMemberProc exists
                        if(updateMemberProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.MemberManager.UpdateMember(updateMemberProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
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
