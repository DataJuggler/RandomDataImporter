

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

    #region class StreetNameMethods
    /// <summary>
    /// This class contains methods for modifying a 'StreetName' object.
    /// </summary>
    public class StreetNameMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'StreetNameMethods' object.
        /// </summary>
        public StreetNameMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteStreetName(StreetName)
            /// <summary>
            /// This method deletes a 'StreetName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'StreetName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteStreetName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteStreetNameStoredProcedure deleteStreetNameProc = null;

                    // verify the first parameters is a(n) 'StreetName'.
                    if (parameters[0].ObjectValue as StreetName != null)
                    {
                        // Create StreetName
                        StreetName streetName = (StreetName) parameters[0].ObjectValue;

                        // verify streetName exists
                        if(streetName != null)
                        {
                            // Now create deleteStreetNameProc from StreetNameWriter
                            // The DataWriter converts the 'StreetName'
                            // to the SqlParameter[] array needed to delete a 'StreetName'.
                            deleteStreetNameProc = StreetNameWriter.CreateDeleteStreetNameStoredProcedure(streetName);
                        }
                    }

                    // Verify deleteStreetNameProc exists
                    if(deleteStreetNameProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.StreetNameManager.DeleteStreetName(deleteStreetNameProc, dataConnector);

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
            /// This method fetches all 'StreetName' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'StreetName' to delete.
            /// <returns>A PolymorphicObject object with all  'StreetNames' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<StreetName> streetNameListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllStreetNamesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get StreetNameParameter
                    // Declare Parameter
                    StreetName paramStreetName = null;

                    // verify the first parameters is a(n) 'StreetName'.
                    if (parameters[0].ObjectValue as StreetName != null)
                    {
                        // Get StreetNameParameter
                        paramStreetName = (StreetName) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllStreetNamesProc from StreetNameWriter
                    fetchAllProc = StreetNameWriter.CreateFetchAllStreetNamesStoredProcedure(paramStreetName);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    streetNameListCollection = this.DataManager.StreetNameManager.FetchAllStreetNames(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(streetNameListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = streetNameListCollection;
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

            #region FindStreetName(StreetName)
            /// <summary>
            /// This method finds a 'StreetName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'StreetName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindStreetName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                StreetName streetName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindStreetNameStoredProcedure findStreetNameProc = null;

                    // verify the first parameters is a 'StreetName'.
                    if (parameters[0].ObjectValue as StreetName != null)
                    {
                        // Get StreetNameParameter
                        StreetName paramStreetName = (StreetName) parameters[0].ObjectValue;

                        // verify paramStreetName exists
                        if(paramStreetName != null)
                        {
                            // Now create findStreetNameProc from StreetNameWriter
                            // The DataWriter converts the 'StreetName'
                            // to the SqlParameter[] array needed to find a 'StreetName'.
                            findStreetNameProc = StreetNameWriter.CreateFindStreetNameStoredProcedure(paramStreetName);
                        }

                        // Verify findStreetNameProc exists
                        if(findStreetNameProc != null)
                        {
                            // Execute Find Stored Procedure
                            streetName = this.DataManager.StreetNameManager.FindStreetName(findStreetNameProc, dataConnector);

                            // if dataObject exists
                            if(streetName != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = streetName;
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

            #region InsertStreetName (StreetName)
            /// <summary>
            /// This method inserts a 'StreetName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'StreetName' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertStreetName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                StreetName streetName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertStreetNameStoredProcedure insertStreetNameProc = null;

                    // verify the first parameters is a(n) 'StreetName'.
                    if (parameters[0].ObjectValue as StreetName != null)
                    {
                        // Create StreetName Parameter
                        streetName = (StreetName) parameters[0].ObjectValue;

                        // verify streetName exists
                        if(streetName != null)
                        {
                            // Now create insertStreetNameProc from StreetNameWriter
                            // The DataWriter converts the 'StreetName'
                            // to the SqlParameter[] array needed to insert a 'StreetName'.
                            insertStreetNameProc = StreetNameWriter.CreateInsertStreetNameStoredProcedure(streetName);
                        }

                        // Verify insertStreetNameProc exists
                        if(insertStreetNameProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.StreetNameManager.InsertStreetName(insertStreetNameProc, dataConnector);
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

            #region UpdateStreetName (StreetName)
            /// <summary>
            /// This method updates a 'StreetName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'StreetName' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateStreetName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                StreetName streetName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateStreetNameStoredProcedure updateStreetNameProc = null;

                    // verify the first parameters is a(n) 'StreetName'.
                    if (parameters[0].ObjectValue as StreetName != null)
                    {
                        // Create StreetName Parameter
                        streetName = (StreetName) parameters[0].ObjectValue;

                        // verify streetName exists
                        if(streetName != null)
                        {
                            // Now create updateStreetNameProc from StreetNameWriter
                            // The DataWriter converts the 'StreetName'
                            // to the SqlParameter[] array needed to update a 'StreetName'.
                            updateStreetNameProc = StreetNameWriter.CreateUpdateStreetNameStoredProcedure(streetName);
                        }

                        // Verify updateStreetNameProc exists
                        if(updateStreetNameProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.StreetNameManager.UpdateStreetName(updateStreetNameProc, dataConnector);

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
