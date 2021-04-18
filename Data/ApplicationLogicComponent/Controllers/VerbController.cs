

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

    #region class VerbController
    /// <summary>
    /// This class controls a(n) 'Verb' object.
    /// </summary>
    public class VerbController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'VerbController' object.
        /// </summary>
        public VerbController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateVerbParameter
            /// <summary>
            /// This method creates the parameter for a 'Verb' data operation.
            /// </summary>
            /// <param name='verb'>The 'Verb' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateVerbParameter(Verb verb)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = verb;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Verb tempVerb)
            /// <summary>
            /// Deletes a 'Verb' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Verb_Delete'.
            /// </summary>
            /// <param name='verb'>The 'Verb' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Verb tempVerb)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteVerb";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempverb exists before attemptintg to delete
                    if(tempVerb != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteVerbMethod = this.AppController.DataBridge.DataOperations.VerbMethods.DeleteVerb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVerbParameter(tempVerb);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteVerbMethod, parameters);

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

            #region FetchAll(Verb tempVerb)
            /// <summary>
            /// This method fetches a collection of 'Verb' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Verb_FetchAll'.</summary>
            /// <param name='tempVerb'>A temporary Verb for passing values.</param>
            /// <returns>A collection of 'Verb' objects.</returns>
            public List<Verb> FetchAll(Verb tempVerb)
            {
                // Initial value
                List<Verb> verbList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.VerbMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateVerbParameter(tempVerb);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Verb> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        verbList = (List<Verb>) returnObject.ObjectValue;
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
                return verbList;
            }
            #endregion

            #region Find(Verb tempVerb)
            /// <summary>
            /// Finds a 'Verb' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Verb_Find'</param>
            /// </summary>
            /// <param name='tempVerb'>A temporary Verb for passing values.</param>
            /// <returns>A 'Verb' object if found else a null 'Verb'.</returns>
            public Verb Find(Verb tempVerb)
            {
                // Initial values
                Verb verb = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempVerb != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.VerbMethods.FindVerb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVerbParameter(tempVerb);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Verb != null))
                        {
                            // Get ReturnObject
                            verb = (Verb) returnObject.ObjectValue;
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
                return verb;
            }
            #endregion

            #region Insert(Verb verb)
            /// <summary>
            /// Insert a 'Verb' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Verb_Insert'.</param>
            /// </summary>
            /// <param name='verb'>The 'Verb' object to insert.</param>
            /// <returns>The id (int) of the new  'Verb' object that was inserted.</returns>
            public int Insert(Verb verb)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Verbexists
                    if(verb != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.VerbMethods.InsertVerb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVerbParameter(verb);

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

            #region Save(ref Verb verb)
            /// <summary>
            /// Saves a 'Verb' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='verb'>The 'Verb' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Verb verb)
            {
                // Initial value
                bool saved = false;

                // If the verb exists.
                if(verb != null)
                {
                    // Is this a new Verb
                    if(verb.IsNew)
                    {
                        // Insert new Verb
                        int newIdentity = this.Insert(verb);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            verb.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Verb
                        saved = this.Update(verb);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Verb verb)
            /// <summary>
            /// This method Updates a 'Verb' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Verb_Update'.</param>
            /// </summary>
            /// <param name='verb'>The 'Verb' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Verb verb)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(verb != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.VerbMethods.UpdateVerb;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateVerbParameter(verb);
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
