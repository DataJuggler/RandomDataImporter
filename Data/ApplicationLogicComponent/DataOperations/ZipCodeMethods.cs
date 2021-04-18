

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

    #region class ZipCodeMethods
    /// <summary>
    /// This class contains methods for modifying a 'ZipCode' object.
    /// </summary>
    public class ZipCodeMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ZipCodeMethods' object.
        /// </summary>
        public ZipCodeMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteZipCode(ZipCode)
            /// <summary>
            /// This method deletes a 'ZipCode' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ZipCode' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteZipCode(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteZipCodeStoredProcedure deleteZipCodeProc = null;

                    // verify the first parameters is a(n) 'ZipCode'.
                    if (parameters[0].ObjectValue as ZipCode != null)
                    {
                        // Create ZipCode
                        ZipCode zipCode = (ZipCode) parameters[0].ObjectValue;

                        // verify zipCode exists
                        if(zipCode != null)
                        {
                            // Now create deleteZipCodeProc from ZipCodeWriter
                            // The DataWriter converts the 'ZipCode'
                            // to the SqlParameter[] array needed to delete a 'ZipCode'.
                            deleteZipCodeProc = ZipCodeWriter.CreateDeleteZipCodeStoredProcedure(zipCode);
                        }
                    }

                    // Verify deleteZipCodeProc exists
                    if(deleteZipCodeProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.ZipCodeManager.DeleteZipCode(deleteZipCodeProc, dataConnector);

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
            /// This method fetches all 'ZipCode' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ZipCode' to delete.
            /// <returns>A PolymorphicObject object with all  'ZipCodes' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<ZipCode> zipCodeListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllZipCodesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get ZipCodeParameter
                    // Declare Parameter
                    ZipCode paramZipCode = null;

                    // verify the first parameters is a(n) 'ZipCode'.
                    if (parameters[0].ObjectValue as ZipCode != null)
                    {
                        // Get ZipCodeParameter
                        paramZipCode = (ZipCode) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllZipCodesProc from ZipCodeWriter
                    fetchAllProc = ZipCodeWriter.CreateFetchAllZipCodesStoredProcedure(paramZipCode);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    zipCodeListCollection = this.DataManager.ZipCodeManager.FetchAllZipCodes(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(zipCodeListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = zipCodeListCollection;
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

            #region FindZipCode(ZipCode)
            /// <summary>
            /// This method finds a 'ZipCode' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ZipCode' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindZipCode(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ZipCode zipCode = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindZipCodeStoredProcedure findZipCodeProc = null;

                    // verify the first parameters is a 'ZipCode'.
                    if (parameters[0].ObjectValue as ZipCode != null)
                    {
                        // Get ZipCodeParameter
                        ZipCode paramZipCode = (ZipCode) parameters[0].ObjectValue;

                        // verify paramZipCode exists
                        if(paramZipCode != null)
                        {
                            // Now create findZipCodeProc from ZipCodeWriter
                            // The DataWriter converts the 'ZipCode'
                            // to the SqlParameter[] array needed to find a 'ZipCode'.
                            findZipCodeProc = ZipCodeWriter.CreateFindZipCodeStoredProcedure(paramZipCode);
                        }

                        // Verify findZipCodeProc exists
                        if(findZipCodeProc != null)
                        {
                            // Execute Find Stored Procedure
                            zipCode = this.DataManager.ZipCodeManager.FindZipCode(findZipCodeProc, dataConnector);

                            // if dataObject exists
                            if(zipCode != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = zipCode;
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

            #region InsertZipCode (ZipCode)
            /// <summary>
            /// This method inserts a 'ZipCode' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ZipCode' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertZipCode(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ZipCode zipCode = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertZipCodeStoredProcedure insertZipCodeProc = null;

                    // verify the first parameters is a(n) 'ZipCode'.
                    if (parameters[0].ObjectValue as ZipCode != null)
                    {
                        // Create ZipCode Parameter
                        zipCode = (ZipCode) parameters[0].ObjectValue;

                        // verify zipCode exists
                        if(zipCode != null)
                        {
                            // Now create insertZipCodeProc from ZipCodeWriter
                            // The DataWriter converts the 'ZipCode'
                            // to the SqlParameter[] array needed to insert a 'ZipCode'.
                            insertZipCodeProc = ZipCodeWriter.CreateInsertZipCodeStoredProcedure(zipCode);
                        }

                        // Verify insertZipCodeProc exists
                        if(insertZipCodeProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.ZipCodeManager.InsertZipCode(insertZipCodeProc, dataConnector);
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

            #region UpdateZipCode (ZipCode)
            /// <summary>
            /// This method updates a 'ZipCode' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ZipCode' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateZipCode(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ZipCode zipCode = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateZipCodeStoredProcedure updateZipCodeProc = null;

                    // verify the first parameters is a(n) 'ZipCode'.
                    if (parameters[0].ObjectValue as ZipCode != null)
                    {
                        // Create ZipCode Parameter
                        zipCode = (ZipCode) parameters[0].ObjectValue;

                        // verify zipCode exists
                        if(zipCode != null)
                        {
                            // Now create updateZipCodeProc from ZipCodeWriter
                            // The DataWriter converts the 'ZipCode'
                            // to the SqlParameter[] array needed to update a 'ZipCode'.
                            updateZipCodeProc = ZipCodeWriter.CreateUpdateZipCodeStoredProcedure(zipCode);
                        }

                        // Verify updateZipCodeProc exists
                        if(updateZipCodeProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.ZipCodeManager.UpdateZipCode(updateZipCodeProc, dataConnector);

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
