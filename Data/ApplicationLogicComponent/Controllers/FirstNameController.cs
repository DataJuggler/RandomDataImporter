

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

    #region class FirstNameController
    /// <summary>
    /// This class controls a(n) 'FirstName' object.
    /// </summary>
    public class FirstNameController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'FirstNameController' object.
        /// </summary>
        public FirstNameController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateFirstNameParameter
            /// <summary>
            /// This method creates the parameter for a 'FirstName' data operation.
            /// </summary>
            /// <param name='firstname'>The 'FirstName' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateFirstNameParameter(FirstName firstName)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = firstName;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(FirstName tempFirstName)
            /// <summary>
            /// Deletes a 'FirstName' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'FirstName_Delete'.
            /// </summary>
            /// <param name='firstname'>The 'FirstName' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(FirstName tempFirstName)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteFirstName";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempfirstName exists before attemptintg to delete
                    if(tempFirstName != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteFirstNameMethod = this.AppController.DataBridge.DataOperations.FirstNameMethods.DeleteFirstName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFirstNameParameter(tempFirstName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteFirstNameMethod, parameters);

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

            #region FetchAll(FirstName tempFirstName)
            /// <summary>
            /// This method fetches a collection of 'FirstName' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'FirstName_FetchAll'.</summary>
            /// <param name='tempFirstName'>A temporary FirstName for passing values.</param>
            /// <returns>A collection of 'FirstName' objects.</returns>
            public List<FirstName> FetchAll(FirstName tempFirstName)
            {
                // Initial value
                List<FirstName> firstNameList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.FirstNameMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateFirstNameParameter(tempFirstName);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<FirstName> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        firstNameList = (List<FirstName>) returnObject.ObjectValue;
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
                return firstNameList;
            }
            #endregion

            #region Find(FirstName tempFirstName)
            /// <summary>
            /// Finds a 'FirstName' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'FirstName_Find'</param>
            /// </summary>
            /// <param name='tempFirstName'>A temporary FirstName for passing values.</param>
            /// <returns>A 'FirstName' object if found else a null 'FirstName'.</returns>
            public FirstName Find(FirstName tempFirstName)
            {
                // Initial values
                FirstName firstName = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempFirstName != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.FirstNameMethods.FindFirstName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFirstNameParameter(tempFirstName);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as FirstName != null))
                        {
                            // Get ReturnObject
                            firstName = (FirstName) returnObject.ObjectValue;
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
                return firstName;
            }
            #endregion

            #region Insert(FirstName firstName)
            /// <summary>
            /// Insert a 'FirstName' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'FirstName_Insert'.</param>
            /// </summary>
            /// <param name='firstName'>The 'FirstName' object to insert.</param>
            /// <returns>The id (int) of the new  'FirstName' object that was inserted.</returns>
            public int Insert(FirstName firstName)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If FirstNameexists
                    if(firstName != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.FirstNameMethods.InsertFirstName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFirstNameParameter(firstName);

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

            #region Save(ref FirstName firstName)
            /// <summary>
            /// Saves a 'FirstName' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='firstName'>The 'FirstName' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref FirstName firstName)
            {
                // Initial value
                bool saved = false;

                // If the firstName exists.
                if(firstName != null)
                {
                    // Is this a new FirstName
                    if(firstName.IsNew)
                    {
                        // Insert new FirstName
                        int newIdentity = this.Insert(firstName);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            firstName.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update FirstName
                        saved = this.Update(firstName);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(FirstName firstName)
            /// <summary>
            /// This method Updates a 'FirstName' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'FirstName_Update'.</param>
            /// </summary>
            /// <param name='firstName'>The 'FirstName' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(FirstName firstName)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(firstName != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.FirstNameMethods.UpdateFirstName;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateFirstNameParameter(firstName);
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
