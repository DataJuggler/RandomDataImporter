

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class MemberController
    /// <summary>
    /// This class controls a(n) 'Member' object.
    /// </summary>
    public class MemberController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'MemberController' object.
        /// </summary>
        public MemberController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateMemberParameter
            /// <summary>
            /// This method creates the parameter for a 'Member' data operation.
            /// </summary>
            /// <param name='member'>The 'Member' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateMemberParameter(Member member)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = member;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Member tempMember)
            /// <summary>
            /// Deletes a 'Member' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Member_Delete'.
            /// </summary>
            /// <param name='member'>The 'Member' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Member tempMember)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteMember";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempmember exists before attemptintg to delete
                    if(tempMember != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteMemberMethod = this.AppController.DataBridge.DataOperations.MemberMethods.DeleteMember;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateMemberParameter(tempMember);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteMemberMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(Member tempMember)
            /// <summary>
            /// This method fetches a collection of 'Member' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Member_FetchAll'.</summary>
            /// <param name='tempMember'>A temporary Member for passing values.</param>
            /// <returns>A collection of 'Member' objects.</returns>
            public List<Member> FetchAll(Member tempMember)
            {
                // Initial value
                List<Member> memberList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.MemberMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateMemberParameter(tempMember);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Member> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        memberList = (List<Member>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return memberList;
            }
            #endregion

            #region Find(Member tempMember)
            /// <summary>
            /// Finds a 'Member' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Member_Find'</param>
            /// </summary>
            /// <param name='tempMember'>A temporary Member for passing values.</param>
            /// <returns>A 'Member' object if found else a null 'Member'.</returns>
            public Member Find(Member tempMember)
            {
                // Initial values
                Member member = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempMember != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.MemberMethods.FindMember;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateMemberParameter(tempMember);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Member != null))
                        {
                            // Get ReturnObject
                            member = (Member) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return member;
            }
            #endregion

            #region Insert(Member member)
            /// <summary>
            /// Insert a 'Member' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Member_Insert'.</param>
            /// </summary>
            /// <param name='member'>The 'Member' object to insert.</param>
            /// <returns>The id (int) of the new  'Member' object that was inserted.</returns>
            public int Insert(Member member)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Memberexists
                    if(member != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.MemberMethods.InsertMember;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateMemberParameter(member);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref Member member)
            /// <summary>
            /// Saves a 'Member' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='member'>The 'Member' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Member member)
            {
                // Initial value
                bool saved = false;

                // If the member exists.
                if(member != null)
                {
                    // Is this a new Member
                    if(member.IsNew)
                    {
                        // Insert new Member
                        int newIdentity = this.Insert(member);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            member.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Member
                        saved = this.Update(member);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Member member)
            /// <summary>
            /// This method Updates a 'Member' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Member_Update'.</param>
            /// </summary>
            /// <param name='member'>The 'Member' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Member member)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(member != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.MemberMethods.UpdateMember;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateMemberParameter(member);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
