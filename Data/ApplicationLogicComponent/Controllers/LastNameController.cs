

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

    #region class LastNameController
    /// <summary>
    /// This class controls a(n) 'LastName' object.
    /// </summary>
    public class LastNameController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'LastNameController' object.
        /// </summary>
        public LastNameController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateLastNameParameter
            /// <summary>
            /// This method creates the parameter for a 'LastName' data operation.
            /// </summary>
            /// <param name='lastname'>The 'LastName' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateLastNameParameter(LastName lastName)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = lastName;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(LastName tempLastName)
            /// <summary>
            /// Deletes a 'LastName' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'LastName_Delete'.
            /// </summary>
            /// <param name='lastname'>The 'LastName' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(LastName tempLastName)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteLastName";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify templastName exists before attemptintg to delete
                    if(tempLastName != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteLastNameMethod = this.AppController.DataBridge.DataOperations.LastNameMethods.DeleteLastName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLastNameParameter(tempLastName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteLastNameMethod, parameters);

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

            #region FetchAll(LastName tempLastName)
            /// <summary>
            /// This method fetches a collection of 'LastName' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'LastName_FetchAll'.</summary>
            /// <param name='tempLastName'>A temporary LastName for passing values.</param>
            /// <returns>A collection of 'LastName' objects.</returns>
            public List<LastName> FetchAll(LastName tempLastName)
            {
                // Initial value
                List<LastName> lastNameList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.LastNameMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateLastNameParameter(tempLastName);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<LastName> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        lastNameList = (List<LastName>) returnObject.ObjectValue;
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
                return lastNameList;
            }
            #endregion

            #region Find(LastName tempLastName)
            /// <summary>
            /// Finds a 'LastName' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'LastName_Find'</param>
            /// </summary>
            /// <param name='tempLastName'>A temporary LastName for passing values.</param>
            /// <returns>A 'LastName' object if found else a null 'LastName'.</returns>
            public LastName Find(LastName tempLastName)
            {
                // Initial values
                LastName lastName = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempLastName != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.LastNameMethods.FindLastName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLastNameParameter(tempLastName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as LastName != null))
                        {
                            // Get ReturnObject
                            lastName = (LastName) returnObject.ObjectValue;
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
                return lastName;
            }
            #endregion

            #region Insert(LastName lastName)
            /// <summary>
            /// Insert a 'LastName' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'LastName_Insert'.</param>
            /// </summary>
            /// <param name='lastName'>The 'LastName' object to insert.</param>
            /// <returns>The id (int) of the new  'LastName' object that was inserted.</returns>
            public int Insert(LastName lastName)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If LastNameexists
                    if(lastName != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.LastNameMethods.InsertLastName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLastNameParameter(lastName);

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

            #region Save(ref LastName lastName)
            /// <summary>
            /// Saves a 'LastName' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='lastName'>The 'LastName' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref LastName lastName)
            {
                // Initial value
                bool saved = false;

                // If the lastName exists.
                if(lastName != null)
                {
                    // Is this a new LastName
                    if(lastName.IsNew)
                    {
                        // Insert new LastName
                        int newIdentity = this.Insert(lastName);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            lastName.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update LastName
                        saved = this.Update(lastName);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(LastName lastName)
            /// <summary>
            /// This method Updates a 'LastName' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'LastName_Update'.</param>
            /// </summary>
            /// <param name='lastName'>The 'LastName' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(LastName lastName)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(lastName != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.LastNameMethods.UpdateLastName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateLastNameParameter(lastName);
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
