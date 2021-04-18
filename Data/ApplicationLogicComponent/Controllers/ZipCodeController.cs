

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

    #region class ZipCodeController
    /// <summary>
    /// This class controls a(n) 'ZipCode' object.
    /// </summary>
    public class ZipCodeController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'ZipCodeController' object.
        /// </summary>
        public ZipCodeController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateZipCodeParameter
            /// <summary>
            /// This method creates the parameter for a 'ZipCode' data operation.
            /// </summary>
            /// <param name='zipcode'>The 'ZipCode' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateZipCodeParameter(ZipCode zipCode)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = zipCode;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(ZipCode tempZipCode)
            /// <summary>
            /// Deletes a 'ZipCode' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'ZipCode_Delete'.
            /// </summary>
            /// <param name='zipcode'>The 'ZipCode' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(ZipCode tempZipCode)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteZipCode";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempzipCode exists before attemptintg to delete
                    if(tempZipCode != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteZipCodeMethod = this.AppController.DataBridge.DataOperations.ZipCodeMethods.DeleteZipCode;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateZipCodeParameter(tempZipCode);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteZipCodeMethod, parameters);

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

            #region FetchAll(ZipCode tempZipCode)
            /// <summary>
            /// This method fetches a collection of 'ZipCode' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'ZipCode_FetchAll'.</summary>
            /// <param name='tempZipCode'>A temporary ZipCode for passing values.</param>
            /// <returns>A collection of 'ZipCode' objects.</returns>
            public List<ZipCode> FetchAll(ZipCode tempZipCode)
            {
                // Initial value
                List<ZipCode> zipCodeList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.ZipCodeMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateZipCodeParameter(tempZipCode);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<ZipCode> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        zipCodeList = (List<ZipCode>) returnObject.ObjectValue;
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
                return zipCodeList;
            }
            #endregion

            #region Find(ZipCode tempZipCode)
            /// <summary>
            /// Finds a 'ZipCode' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'ZipCode_Find'</param>
            /// </summary>
            /// <param name='tempZipCode'>A temporary ZipCode for passing values.</param>
            /// <returns>A 'ZipCode' object if found else a null 'ZipCode'.</returns>
            public ZipCode Find(ZipCode tempZipCode)
            {
                // Initial values
                ZipCode zipCode = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempZipCode != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.ZipCodeMethods.FindZipCode;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateZipCodeParameter(tempZipCode);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as ZipCode != null))
                        {
                            // Get ReturnObject
                            zipCode = (ZipCode) returnObject.ObjectValue;
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
                return zipCode;
            }
            #endregion

            #region Insert(ZipCode zipCode)
            /// <summary>
            /// Insert a 'ZipCode' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'ZipCode_Insert'.</param>
            /// </summary>
            /// <param name='zipCode'>The 'ZipCode' object to insert.</param>
            /// <returns>The id (int) of the new  'ZipCode' object that was inserted.</returns>
            public int Insert(ZipCode zipCode)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If ZipCodeexists
                    if(zipCode != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.ZipCodeMethods.InsertZipCode;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateZipCodeParameter(zipCode);

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

            #region Save(ref ZipCode zipCode)
            /// <summary>
            /// Saves a 'ZipCode' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='zipCode'>The 'ZipCode' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref ZipCode zipCode)
            {
                // Initial value
                bool saved = false;

                // If the zipCode exists.
                if(zipCode != null)
                {
                    // Is this a new ZipCode
                    if(zipCode.IsNew)
                    {
                        // Insert new ZipCode
                        int newIdentity = this.Insert(zipCode);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            zipCode.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update ZipCode
                        saved = this.Update(zipCode);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(ZipCode zipCode)
            /// <summary>
            /// This method Updates a 'ZipCode' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'ZipCode_Update'.</param>
            /// </summary>
            /// <param name='zipCode'>The 'ZipCode' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(ZipCode zipCode)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(zipCode != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.ZipCodeMethods.UpdateZipCode;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateZipCodeParameter(zipCode);
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
