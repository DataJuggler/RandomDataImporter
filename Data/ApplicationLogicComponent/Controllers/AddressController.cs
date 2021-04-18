

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

    #region class AddressController
    /// <summary>
    /// This class controls a(n) 'Address' object.
    /// </summary>
    public class AddressController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'AddressController' object.
        /// </summary>
        public AddressController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateAddressParameter
            /// <summary>
            /// This method creates the parameter for a 'Address' data operation.
            /// </summary>
            /// <param name='address'>The 'Address' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateAddressParameter(Address address)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = address;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Address tempAddress)
            /// <summary>
            /// Deletes a 'Address' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Address_Delete'.
            /// </summary>
            /// <param name='address'>The 'Address' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Address tempAddress)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteAddress";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempaddress exists before attemptintg to delete
                    if(tempAddress != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteAddressMethod = this.AppController.DataBridge.DataOperations.AddressMethods.DeleteAddress;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAddressParameter(tempAddress);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteAddressMethod, parameters);

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

            #region FetchAll(Address tempAddress)
            /// <summary>
            /// This method fetches a collection of 'Address' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Address_FetchAll'.</summary>
            /// <param name='tempAddress'>A temporary Address for passing values.</param>
            /// <returns>A collection of 'Address' objects.</returns>
            public List<Address> FetchAll(Address tempAddress)
            {
                // Initial value
                List<Address> addressList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.AddressMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateAddressParameter(tempAddress);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Address> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        addressList = (List<Address>) returnObject.ObjectValue;
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
                return addressList;
            }
            #endregion

            #region Find(Address tempAddress)
            /// <summary>
            /// Finds a 'Address' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Address_Find'</param>
            /// </summary>
            /// <param name='tempAddress'>A temporary Address for passing values.</param>
            /// <returns>A 'Address' object if found else a null 'Address'.</returns>
            public Address Find(Address tempAddress)
            {
                // Initial values
                Address address = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempAddress != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.AddressMethods.FindAddress;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAddressParameter(tempAddress);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Address != null))
                        {
                            // Get ReturnObject
                            address = (Address) returnObject.ObjectValue;
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
                return address;
            }
            #endregion

            #region Insert(Address address)
            /// <summary>
            /// Insert a 'Address' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Address_Insert'.</param>
            /// </summary>
            /// <param name='address'>The 'Address' object to insert.</param>
            /// <returns>The id (int) of the new  'Address' object that was inserted.</returns>
            public int Insert(Address address)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Addressexists
                    if(address != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.AddressMethods.InsertAddress;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAddressParameter(address);

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

            #region Save(ref Address address)
            /// <summary>
            /// Saves a 'Address' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='address'>The 'Address' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Address address)
            {
                // Initial value
                bool saved = false;

                // If the address exists.
                if(address != null)
                {
                    // Is this a new Address
                    if(address.IsNew)
                    {
                        // Insert new Address
                        int newIdentity = this.Insert(address);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            address.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Address
                        saved = this.Update(address);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Address address)
            /// <summary>
            /// This method Updates a 'Address' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Address_Update'.</param>
            /// </summary>
            /// <param name='address'>The 'Address' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Address address)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(address != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.AddressMethods.UpdateAddress;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateAddressParameter(address);
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
