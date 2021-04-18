

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

    #region class StreetNameController
    /// <summary>
    /// This class controls a(n) 'StreetName' object.
    /// </summary>
    public class StreetNameController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'StreetNameController' object.
        /// </summary>
        public StreetNameController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateStreetNameParameter
            /// <summary>
            /// This method creates the parameter for a 'StreetName' data operation.
            /// </summary>
            /// <param name='streetname'>The 'StreetName' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateStreetNameParameter(StreetName streetName)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = streetName;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(StreetName tempStreetName)
            /// <summary>
            /// Deletes a 'StreetName' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'StreetName_Delete'.
            /// </summary>
            /// <param name='streetname'>The 'StreetName' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(StreetName tempStreetName)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteStreetName";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempstreetName exists before attemptintg to delete
                    if(tempStreetName != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteStreetNameMethod = this.AppController.DataBridge.DataOperations.StreetNameMethods.DeleteStreetName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStreetNameParameter(tempStreetName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteStreetNameMethod, parameters);

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

            #region FetchAll(StreetName tempStreetName)
            /// <summary>
            /// This method fetches a collection of 'StreetName' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'StreetName_FetchAll'.</summary>
            /// <param name='tempStreetName'>A temporary StreetName for passing values.</param>
            /// <returns>A collection of 'StreetName' objects.</returns>
            public List<StreetName> FetchAll(StreetName tempStreetName)
            {
                // Initial value
                List<StreetName> streetNameList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.StreetNameMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateStreetNameParameter(tempStreetName);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<StreetName> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        streetNameList = (List<StreetName>) returnObject.ObjectValue;
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
                return streetNameList;
            }
            #endregion

            #region Find(StreetName tempStreetName)
            /// <summary>
            /// Finds a 'StreetName' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'StreetName_Find'</param>
            /// </summary>
            /// <param name='tempStreetName'>A temporary StreetName for passing values.</param>
            /// <returns>A 'StreetName' object if found else a null 'StreetName'.</returns>
            public StreetName Find(StreetName tempStreetName)
            {
                // Initial values
                StreetName streetName = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempStreetName != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.StreetNameMethods.FindStreetName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStreetNameParameter(tempStreetName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as StreetName != null))
                        {
                            // Get ReturnObject
                            streetName = (StreetName) returnObject.ObjectValue;
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
                return streetName;
            }
            #endregion

            #region Insert(StreetName streetName)
            /// <summary>
            /// Insert a 'StreetName' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'StreetName_Insert'.</param>
            /// </summary>
            /// <param name='streetName'>The 'StreetName' object to insert.</param>
            /// <returns>The id (int) of the new  'StreetName' object that was inserted.</returns>
            public int Insert(StreetName streetName)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If StreetNameexists
                    if(streetName != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.StreetNameMethods.InsertStreetName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStreetNameParameter(streetName);

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

            #region Save(ref StreetName streetName)
            /// <summary>
            /// Saves a 'StreetName' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='streetName'>The 'StreetName' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref StreetName streetName)
            {
                // Initial value
                bool saved = false;

                // If the streetName exists.
                if(streetName != null)
                {
                    // Is this a new StreetName
                    if(streetName.IsNew)
                    {
                        // Insert new StreetName
                        int newIdentity = this.Insert(streetName);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            streetName.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update StreetName
                        saved = this.Update(streetName);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(StreetName streetName)
            /// <summary>
            /// This method Updates a 'StreetName' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'StreetName_Update'.</param>
            /// </summary>
            /// <param name='streetName'>The 'StreetName' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(StreetName streetName)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(streetName != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.StreetNameMethods.UpdateStreetName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateStreetNameParameter(streetName);
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
