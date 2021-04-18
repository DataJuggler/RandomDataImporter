

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

    #region class AdjectiveController
    /// <summary>
    /// This class controls a(n) 'Adjective' object.
    /// </summary>
    public class AdjectiveController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'AdjectiveController' object.
        /// </summary>
        public AdjectiveController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateAdjectiveParameter
            /// <summary>
            /// This method creates the parameter for a 'Adjective' data operation.
            /// </summary>
            /// <param name='adjective'>The 'Adjective' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateAdjectiveParameter(Adjective adjective)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = adjective;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Adjective tempAdjective)
            /// <summary>
            /// Deletes a 'Adjective' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Adjective_Delete'.
            /// </summary>
            /// <param name='adjective'>The 'Adjective' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Adjective tempAdjective)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteAdjective";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempadjective exists before attemptintg to delete
                    if(tempAdjective != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteAdjectiveMethod = this.AppController.DataBridge.DataOperations.AdjectiveMethods.DeleteAdjective;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdjectiveParameter(tempAdjective);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteAdjectiveMethod, parameters);

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

            #region FetchAll(Adjective tempAdjective)
            /// <summary>
            /// This method fetches a collection of 'Adjective' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Adjective_FetchAll'.</summary>
            /// <param name='tempAdjective'>A temporary Adjective for passing values.</param>
            /// <returns>A collection of 'Adjective' objects.</returns>
            public List<Adjective> FetchAll(Adjective tempAdjective)
            {
                // Initial value
                List<Adjective> adjectiveList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.AdjectiveMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateAdjectiveParameter(tempAdjective);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Adjective> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        adjectiveList = (List<Adjective>) returnObject.ObjectValue;
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
                return adjectiveList;
            }
            #endregion

            #region Find(Adjective tempAdjective)
            /// <summary>
            /// Finds a 'Adjective' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Adjective_Find'</param>
            /// </summary>
            /// <param name='tempAdjective'>A temporary Adjective for passing values.</param>
            /// <returns>A 'Adjective' object if found else a null 'Adjective'.</returns>
            public Adjective Find(Adjective tempAdjective)
            {
                // Initial values
                Adjective adjective = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempAdjective != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.AdjectiveMethods.FindAdjective;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdjectiveParameter(tempAdjective);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Adjective != null))
                        {
                            // Get ReturnObject
                            adjective = (Adjective) returnObject.ObjectValue;
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
                return adjective;
            }
            #endregion

            #region Insert(Adjective adjective)
            /// <summary>
            /// Insert a 'Adjective' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Adjective_Insert'.</param>
            /// </summary>
            /// <param name='adjective'>The 'Adjective' object to insert.</param>
            /// <returns>The id (int) of the new  'Adjective' object that was inserted.</returns>
            public int Insert(Adjective adjective)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Adjectiveexists
                    if(adjective != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.AdjectiveMethods.InsertAdjective;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdjectiveParameter(adjective);

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

            #region Save(ref Adjective adjective)
            /// <summary>
            /// Saves a 'Adjective' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='adjective'>The 'Adjective' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Adjective adjective)
            {
                // Initial value
                bool saved = false;

                // If the adjective exists.
                if(adjective != null)
                {
                    // Is this a new Adjective
                    if(adjective.IsNew)
                    {
                        // Insert new Adjective
                        int newIdentity = this.Insert(adjective);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            adjective.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Adjective
                        saved = this.Update(adjective);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Adjective adjective)
            /// <summary>
            /// This method Updates a 'Adjective' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Adjective_Update'.</param>
            /// </summary>
            /// <param name='adjective'>The 'Adjective' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Adjective adjective)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(adjective != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.AdjectiveMethods.UpdateAdjective;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAdjectiveParameter(adjective);
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
