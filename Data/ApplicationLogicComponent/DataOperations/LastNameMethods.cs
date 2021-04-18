

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

    #region class LastNameMethods
    /// <summary>
    /// This class contains methods for modifying a 'LastName' object.
    /// </summary>
    public class LastNameMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'LastNameMethods' object.
        /// </summary>
        public LastNameMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteLastName(LastName)
            /// <summary>
            /// This method deletes a 'LastName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'LastName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteLastName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteLastNameStoredProcedure deleteLastNameProc = null;

                    // verify the first parameters is a(n) 'LastName'.
                    if (parameters[0].ObjectValue as LastName != null)
                    {
                        // Create LastName
                        LastName lastName = (LastName) parameters[0].ObjectValue;

                        // verify lastName exists
                        if(lastName != null)
                        {
                            // Now create deleteLastNameProc from LastNameWriter
                            // The DataWriter converts the 'LastName'
                            // to the SqlParameter[] array needed to delete a 'LastName'.
                            deleteLastNameProc = LastNameWriter.CreateDeleteLastNameStoredProcedure(lastName);
                        }
                    }

                    // Verify deleteLastNameProc exists
                    if(deleteLastNameProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.LastNameManager.DeleteLastName(deleteLastNameProc, dataConnector);

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
            /// This method fetches all 'LastName' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'LastName' to delete.
            /// <returns>A PolymorphicObject object with all  'LastNames' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<LastName> lastNameListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllLastNamesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get LastNameParameter
                    // Declare Parameter
                    LastName paramLastName = null;

                    // verify the first parameters is a(n) 'LastName'.
                    if (parameters[0].ObjectValue as LastName != null)
                    {
                        // Get LastNameParameter
                        paramLastName = (LastName) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllLastNamesProc from LastNameWriter
                    fetchAllProc = LastNameWriter.CreateFetchAllLastNamesStoredProcedure(paramLastName);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    lastNameListCollection = this.DataManager.LastNameManager.FetchAllLastNames(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(lastNameListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = lastNameListCollection;
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

            #region FindLastName(LastName)
            /// <summary>
            /// This method finds a 'LastName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'LastName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindLastName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                LastName lastName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindLastNameStoredProcedure findLastNameProc = null;

                    // verify the first parameters is a 'LastName'.
                    if (parameters[0].ObjectValue as LastName != null)
                    {
                        // Get LastNameParameter
                        LastName paramLastName = (LastName) parameters[0].ObjectValue;

                        // verify paramLastName exists
                        if(paramLastName != null)
                        {
                            // Now create findLastNameProc from LastNameWriter
                            // The DataWriter converts the 'LastName'
                            // to the SqlParameter[] array needed to find a 'LastName'.
                            findLastNameProc = LastNameWriter.CreateFindLastNameStoredProcedure(paramLastName);
                        }

                        // Verify findLastNameProc exists
                        if(findLastNameProc != null)
                        {
                            // Execute Find Stored Procedure
                            lastName = this.DataManager.LastNameManager.FindLastName(findLastNameProc, dataConnector);

                            // if dataObject exists
                            if(lastName != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = lastName;
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

            #region InsertLastName (LastName)
            /// <summary>
            /// This method inserts a 'LastName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'LastName' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertLastName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                LastName lastName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertLastNameStoredProcedure insertLastNameProc = null;

                    // verify the first parameters is a(n) 'LastName'.
                    if (parameters[0].ObjectValue as LastName != null)
                    {
                        // Create LastName Parameter
                        lastName = (LastName) parameters[0].ObjectValue;

                        // verify lastName exists
                        if(lastName != null)
                        {
                            // Now create insertLastNameProc from LastNameWriter
                            // The DataWriter converts the 'LastName'
                            // to the SqlParameter[] array needed to insert a 'LastName'.
                            insertLastNameProc = LastNameWriter.CreateInsertLastNameStoredProcedure(lastName);
                        }

                        // Verify insertLastNameProc exists
                        if(insertLastNameProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.LastNameManager.InsertLastName(insertLastNameProc, dataConnector);
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

            #region UpdateLastName (LastName)
            /// <summary>
            /// This method updates a 'LastName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'LastName' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateLastName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                LastName lastName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateLastNameStoredProcedure updateLastNameProc = null;

                    // verify the first parameters is a(n) 'LastName'.
                    if (parameters[0].ObjectValue as LastName != null)
                    {
                        // Create LastName Parameter
                        lastName = (LastName) parameters[0].ObjectValue;

                        // verify lastName exists
                        if(lastName != null)
                        {
                            // Now create updateLastNameProc from LastNameWriter
                            // The DataWriter converts the 'LastName'
                            // to the SqlParameter[] array needed to update a 'LastName'.
                            updateLastNameProc = LastNameWriter.CreateUpdateLastNameStoredProcedure(lastName);
                        }

                        // Verify updateLastNameProc exists
                        if(updateLastNameProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.LastNameManager.UpdateLastName(updateLastNameProc, dataConnector);

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
