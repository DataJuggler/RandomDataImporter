

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class AddressMethods
    /// <summary>
    /// This class contains methods for modifying a 'Address' object.
    /// </summary>
    public class AddressMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'AddressMethods' object.
        /// </summary>
        public AddressMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteAddress(Address)
            /// <summary>
            /// This method deletes a 'Address' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Address' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteAddress(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteAddressStoredProcedure deleteAddressProc = null;

                    // verify the first parameters is a(n) 'Address'.
                    if (parameters[0].ObjectValue as Address != null)
                    {
                        // Create Address
                        Address address = (Address) parameters[0].ObjectValue;

                        // verify address exists
                        if(address != null)
                        {
                            // Now create deleteAddressProc from AddressWriter
                            // The DataWriter converts the 'Address'
                            // to the SqlParameter[] array needed to delete a 'Address'.
                            deleteAddressProc = AddressWriter.CreateDeleteAddressStoredProcedure(address);
                        }
                    }

                    // Verify deleteAddressProc exists
                    if(deleteAddressProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.AddressManager.DeleteAddress(deleteAddressProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'Address' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Address' to delete.
            /// <returns>A PolymorphicObject object with all  'Addresses' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Address> addressListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllAddressesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get AddressParameter
                    // Declare Parameter
                    Address paramAddress = null;

                    // verify the first parameters is a(n) 'Address'.
                    if (parameters[0].ObjectValue as Address != null)
                    {
                        // Get AddressParameter
                        paramAddress = (Address) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllAddressesProc from AddressWriter
                    fetchAllProc = AddressWriter.CreateFetchAllAddressesStoredProcedure(paramAddress);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    addressListCollection = this.DataManager.AddressManager.FetchAllAddresses(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(addressListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = addressListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindAddress(Address)
            /// <summary>
            /// This method finds a 'Address' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Address' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindAddress(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Address address = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindAddressStoredProcedure findAddressProc = null;

                    // verify the first parameters is a 'Address'.
                    if (parameters[0].ObjectValue as Address != null)
                    {
                        // Get AddressParameter
                        Address paramAddress = (Address) parameters[0].ObjectValue;

                        // verify paramAddress exists
                        if(paramAddress != null)
                        {
                            // Now create findAddressProc from AddressWriter
                            // The DataWriter converts the 'Address'
                            // to the SqlParameter[] array needed to find a 'Address'.
                            findAddressProc = AddressWriter.CreateFindAddressStoredProcedure(paramAddress);
                        }

                        // Verify findAddressProc exists
                        if(findAddressProc != null)
                        {
                            // Execute Find Stored Procedure
                            address = this.DataManager.AddressManager.FindAddress(findAddressProc, dataConnector);

                            // if dataObject exists
                            if(address != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = address;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertAddress (Address)
            /// <summary>
            /// This method inserts a 'Address' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Address' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertAddress(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Address address = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertAddressStoredProcedure insertAddressProc = null;

                    // verify the first parameters is a(n) 'Address'.
                    if (parameters[0].ObjectValue as Address != null)
                    {
                        // Create Address Parameter
                        address = (Address) parameters[0].ObjectValue;

                        // verify address exists
                        if(address != null)
                        {
                            // Now create insertAddressProc from AddressWriter
                            // The DataWriter converts the 'Address'
                            // to the SqlParameter[] array needed to insert a 'Address'.
                            insertAddressProc = AddressWriter.CreateInsertAddressStoredProcedure(address);
                        }

                        // Verify insertAddressProc exists
                        if(insertAddressProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.AddressManager.InsertAddress(insertAddressProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateAddress (Address)
            /// <summary>
            /// This method updates a 'Address' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Address' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateAddress(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Address address = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateAddressStoredProcedure updateAddressProc = null;

                    // verify the first parameters is a(n) 'Address'.
                    if (parameters[0].ObjectValue as Address != null)
                    {
                        // Create Address Parameter
                        address = (Address) parameters[0].ObjectValue;

                        // verify address exists
                        if(address != null)
                        {
                            // Now create updateAddressProc from AddressWriter
                            // The DataWriter converts the 'Address'
                            // to the SqlParameter[] array needed to update a 'Address'.
                            updateAddressProc = AddressWriter.CreateUpdateAddressStoredProcedure(address);
                        }

                        // Verify updateAddressProc exists
                        if(updateAddressProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.AddressManager.UpdateAddress(updateAddressProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
