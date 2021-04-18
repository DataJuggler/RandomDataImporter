

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

    #region class AdverbController
    /// <summary>
    /// This class controls a(n) 'Adverb' object.
    /// </summary>
    public class AdverbController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'AdverbController' object.
        /// </summary>
        public AdverbController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateAdverbParameter
            /// <summary>
            /// This method creates the parameter for a 'Adverb' data operation.
            /// </summary>
            /// <param name='adverb'>The 'Adverb' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateAdverbParameter(Adverb adverb)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = adverb;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Adverb tempAdverb)
            /// <summary>
            /// Deletes a 'Adverb' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Adverb_Delete'.
            /// </summary>
            /// <param name='adverb'>The 'Adverb' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Adverb tempAdverb)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteAdverb";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempadverb exists before attemptintg to delete
                    if(tempAdverb != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteAdverbMethod = this.AppController.DataBridge.DataOperations.AdverbMethods.DeleteAdverb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdverbParameter(tempAdverb);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteAdverbMethod, parameters);

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

            #region FetchAll(Adverb tempAdverb)
            /// <summary>
            /// This method fetches a collection of 'Adverb' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Adverb_FetchAll'.</summary>
            /// <param name='tempAdverb'>A temporary Adverb for passing values.</param>
            /// <returns>A collection of 'Adverb' objects.</returns>
            public List<Adverb> FetchAll(Adverb tempAdverb)
            {
                // Initial value
                List<Adverb> adverbList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.AdverbMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateAdverbParameter(tempAdverb);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Adverb> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        adverbList = (List<Adverb>) returnObject.ObjectValue;
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
                return adverbList;
            }
            #endregion

            #region Find(Adverb tempAdverb)
            /// <summary>
            /// Finds a 'Adverb' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Adverb_Find'</param>
            /// </summary>
            /// <param name='tempAdverb'>A temporary Adverb for passing values.</param>
            /// <returns>A 'Adverb' object if found else a null 'Adverb'.</returns>
            public Adverb Find(Adverb tempAdverb)
            {
                // Initial values
                Adverb adverb = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempAdverb != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.AdverbMethods.FindAdverb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdverbParameter(tempAdverb);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Adverb != null))
                        {
                            // Get ReturnObject
                            adverb = (Adverb) returnObject.ObjectValue;
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
                return adverb;
            }
            #endregion

            #region Insert(Adverb adverb)
            /// <summary>
            /// Insert a 'Adverb' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Adverb_Insert'.</param>
            /// </summary>
            /// <param name='adverb'>The 'Adverb' object to insert.</param>
            /// <returns>The id (int) of the new  'Adverb' object that was inserted.</returns>
            public int Insert(Adverb adverb)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Adverbexists
                    if(adverb != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.AdverbMethods.InsertAdverb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdverbParameter(adverb);

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

            #region Save(ref Adverb adverb)
            /// <summary>
            /// Saves a 'Adverb' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='adverb'>The 'Adverb' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Adverb adverb)
            {
                // Initial value
                bool saved = false;

                // If the adverb exists.
                if(adverb != null)
                {
                    // Is this a new Adverb
                    if(adverb.IsNew)
                    {
                        // Insert new Adverb
                        int newIdentity = this.Insert(adverb);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            adverb.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Adverb
                        saved = this.Update(adverb);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Adverb adverb)
            /// <summary>
            /// This method Updates a 'Adverb' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Adverb_Update'.</param>
            /// </summary>
            /// <param name='adverb'>The 'Adverb' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Adverb adverb)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(adverb != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.AdverbMethods.UpdateAdverb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdverbParameter(adverb);
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
