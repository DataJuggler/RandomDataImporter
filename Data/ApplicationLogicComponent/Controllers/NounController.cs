

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

    #region class NounController
    /// <summary>
    /// This class controls a(n) 'Noun' object.
    /// </summary>
    public class NounController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'NounController' object.
        /// </summary>
        public NounController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateNounParameter
            /// <summary>
            /// This method creates the parameter for a 'Noun' data operation.
            /// </summary>
            /// <param name='noun'>The 'Noun' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateNounParameter(Noun noun)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = noun;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Noun tempNoun)
            /// <summary>
            /// Deletes a 'Noun' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Noun_Delete'.
            /// </summary>
            /// <param name='noun'>The 'Noun' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Noun tempNoun)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteNoun";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempnoun exists before attemptintg to delete
                    if(tempNoun != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteNounMethod = this.AppController.DataBridge.DataOperations.NounMethods.DeleteNoun;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateNounParameter(tempNoun);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteNounMethod, parameters);

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

            #region FetchAll(Noun tempNoun)
            /// <summary>
            /// This method fetches a collection of 'Noun' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Noun_FetchAll'.</summary>
            /// <param name='tempNoun'>A temporary Noun for passing values.</param>
            /// <returns>A collection of 'Noun' objects.</returns>
            public List<Noun> FetchAll(Noun tempNoun)
            {
                // Initial value
                List<Noun> nounList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.NounMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateNounParameter(tempNoun);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Noun> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        nounList = (List<Noun>) returnObject.ObjectValue;
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
                return nounList;
            }
            #endregion

            #region Find(Noun tempNoun)
            /// <summary>
            /// Finds a 'Noun' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Noun_Find'</param>
            /// </summary>
            /// <param name='tempNoun'>A temporary Noun for passing values.</param>
            /// <returns>A 'Noun' object if found else a null 'Noun'.</returns>
            public Noun Find(Noun tempNoun)
            {
                // Initial values
                Noun noun = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempNoun != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.NounMethods.FindNoun;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateNounParameter(tempNoun);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Noun != null))
                        {
                            // Get ReturnObject
                            noun = (Noun) returnObject.ObjectValue;
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
                return noun;
            }
            #endregion

            #region Insert(Noun noun)
            /// <summary>
            /// Insert a 'Noun' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Noun_Insert'.</param>
            /// </summary>
            /// <param name='noun'>The 'Noun' object to insert.</param>
            /// <returns>The id (int) of the new  'Noun' object that was inserted.</returns>
            public int Insert(Noun noun)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Nounexists
                    if(noun != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.NounMethods.InsertNoun;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateNounParameter(noun);

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

            #region Save(ref Noun noun)
            /// <summary>
            /// Saves a 'Noun' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='noun'>The 'Noun' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Noun noun)
            {
                // Initial value
                bool saved = false;

                // If the noun exists.
                if(noun != null)
                {
                    // Is this a new Noun
                    if(noun.IsNew)
                    {
                        // Insert new Noun
                        int newIdentity = this.Insert(noun);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            noun.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Noun
                        saved = this.Update(noun);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Noun noun)
            /// <summary>
            /// This method Updates a 'Noun' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Noun_Update'.</param>
            /// </summary>
            /// <param name='noun'>The 'Noun' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Noun noun)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(noun != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.NounMethods.UpdateNoun;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateNounParameter(noun);
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
