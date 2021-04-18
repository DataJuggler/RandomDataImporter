

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

    #region class StateController
    /// <summary>
    /// This class controls a(n) 'State' object.
    /// </summary>
    public class StateController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'StateController' object.
        /// </summary>
        public StateController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateStateParameter
            /// <summary>
            /// This method creates the parameter for a 'State' data operation.
            /// </summary>
            /// <param name='state'>The 'State' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateStateParameter(State state)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = state;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(State tempState)
            /// <summary>
            /// Deletes a 'State' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'State_Delete'.
            /// </summary>
            /// <param name='state'>The 'State' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(State tempState)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteState";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempstate exists before attemptintg to delete
                    if(tempState != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteStateMethod = this.AppController.DataBridge.DataOperations.StateMethods.DeleteState;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStateParameter(tempState);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteStateMethod, parameters);

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

            #region FetchAll(State tempState)
            /// <summary>
            /// This method fetches a collection of 'State' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'State_FetchAll'.</summary>
            /// <param name='tempState'>A temporary State for passing values.</param>
            /// <returns>A collection of 'State' objects.</returns>
            public List<State> FetchAll(State tempState)
            {
                // Initial value
                List<State> stateList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.StateMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateStateParameter(tempState);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<State> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        stateList = (List<State>) returnObject.ObjectValue;
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
                return stateList;
            }
            #endregion

            #region Find(State tempState)
            /// <summary>
            /// Finds a 'State' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'State_Find'</param>
            /// </summary>
            /// <param name='tempState'>A temporary State for passing values.</param>
            /// <returns>A 'State' object if found else a null 'State'.</returns>
            public State Find(State tempState)
            {
                // Initial values
                State state = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempState != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.StateMethods.FindState;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStateParameter(tempState);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as State != null))
                        {
                            // Get ReturnObject
                            state = (State) returnObject.ObjectValue;
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
                return state;
            }
            #endregion

            #region Insert(State state)
            /// <summary>
            /// Insert a 'State' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'State_Insert'.</param>
            /// </summary>
            /// <param name='state'>The 'State' object to insert.</param>
            /// <returns>The id (int) of the new  'State' object that was inserted.</returns>
            public int Insert(State state)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Stateexists
                    if(state != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.StateMethods.InsertState;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStateParameter(state);

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

            #region Save(ref State state)
            /// <summary>
            /// Saves a 'State' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='state'>The 'State' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref State state)
            {
                // Initial value
                bool saved = false;

                // If the state exists.
                if(state != null)
                {
                    // Is this a new State
                    if(state.IsNew)
                    {
                        // Insert new State
                        int newIdentity = this.Insert(state);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            state.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update State
                        saved = this.Update(state);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(State state)
            /// <summary>
            /// This method Updates a 'State' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'State_Update'.</param>
            /// </summary>
            /// <param name='state'>The 'State' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(State state)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(state != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.StateMethods.UpdateState;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStateParameter(state);
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
