

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

    #region class FirstNameMethods
    /// <summary>
    /// This class contains methods for modifying a 'FirstName' object.
    /// </summary>
    public class FirstNameMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'FirstNameMethods' object.
        /// </summary>
        public FirstNameMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteFirstName(FirstName)
            /// <summary>
            /// This method deletes a 'FirstName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'FirstName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteFirstName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteFirstNameStoredProcedure deleteFirstNameProc = null;

                    // verify the first parameters is a(n) 'FirstName'.
                    if (parameters[0].ObjectValue as FirstName != null)
                    {
                        // Create FirstName
                        FirstName firstName = (FirstName) parameters[0].ObjectValue;

                        // verify firstName exists
                        if(firstName != null)
                        {
                            // Now create deleteFirstNameProc from FirstNameWriter
                            // The DataWriter converts the 'FirstName'
                            // to the SqlParameter[] array needed to delete a 'FirstName'.
                            deleteFirstNameProc = FirstNameWriter.CreateDeleteFirstNameStoredProcedure(firstName);
                        }
                    }

                    // Verify deleteFirstNameProc exists
                    if(deleteFirstNameProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.FirstNameManager.DeleteFirstName(deleteFirstNameProc, dataConnector);

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
            /// This method fetches all 'FirstName' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'FirstName' to delete.
            /// <returns>A PolymorphicObject object with all  'FirstNames' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<FirstName> firstNameListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllFirstNamesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get FirstNameParameter
                    // Declare Parameter
                    FirstName paramFirstName = null;

                    // verify the first parameters is a(n) 'FirstName'.
                    if (parameters[0].ObjectValue as FirstName != null)
                    {
                        // Get FirstNameParameter
                        paramFirstName = (FirstName) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllFirstNamesProc from FirstNameWriter
                    fetchAllProc = FirstNameWriter.CreateFetchAllFirstNamesStoredProcedure(paramFirstName);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    firstNameListCollection = this.DataManager.FirstNameManager.FetchAllFirstNames(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(firstNameListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = firstNameListCollection;
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

            #region FindFirstName(FirstName)
            /// <summary>
            /// This method finds a 'FirstName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'FirstName' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindFirstName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                FirstName firstName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindFirstNameStoredProcedure findFirstNameProc = null;

                    // verify the first parameters is a 'FirstName'.
                    if (parameters[0].ObjectValue as FirstName != null)
                    {
                        // Get FirstNameParameter
                        FirstName paramFirstName = (FirstName) parameters[0].ObjectValue;

                        // verify paramFirstName exists
                        if(paramFirstName != null)
                        {
                            // Now create findFirstNameProc from FirstNameWriter
                            // The DataWriter converts the 'FirstName'
                            // to the SqlParameter[] array needed to find a 'FirstName'.
                            findFirstNameProc = FirstNameWriter.CreateFindFirstNameStoredProcedure(paramFirstName);
                        }

                        // Verify findFirstNameProc exists
                        if(findFirstNameProc != null)
                        {
                            // Execute Find Stored Procedure
                            firstName = this.DataManager.FirstNameManager.FindFirstName(findFirstNameProc, dataConnector);

                            // if dataObject exists
                            if(firstName != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = firstName;
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

            #region InsertFirstName (FirstName)
            /// <summary>
            /// This method inserts a 'FirstName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'FirstName' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertFirstName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                FirstName firstName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertFirstNameStoredProcedure insertFirstNameProc = null;

                    // verify the first parameters is a(n) 'FirstName'.
                    if (parameters[0].ObjectValue as FirstName != null)
                    {
                        // Create FirstName Parameter
                        firstName = (FirstName) parameters[0].ObjectValue;

                        // verify firstName exists
                        if(firstName != null)
                        {
                            // Now create insertFirstNameProc from FirstNameWriter
                            // The DataWriter converts the 'FirstName'
                            // to the SqlParameter[] array needed to insert a 'FirstName'.
                            insertFirstNameProc = FirstNameWriter.CreateInsertFirstNameStoredProcedure(firstName);
                        }

                        // Verify insertFirstNameProc exists
                        if(insertFirstNameProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.FirstNameManager.InsertFirstName(insertFirstNameProc, dataConnector);
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

            #region UpdateFirstName (FirstName)
            /// <summary>
            /// This method updates a 'FirstName' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'FirstName' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateFirstName(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                FirstName firstName = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateFirstNameStoredProcedure updateFirstNameProc = null;

                    // verify the first parameters is a(n) 'FirstName'.
                    if (parameters[0].ObjectValue as FirstName != null)
                    {
                        // Create FirstName Parameter
                        firstName = (FirstName) parameters[0].ObjectValue;

                        // verify firstName exists
                        if(firstName != null)
                        {
                            // Now create updateFirstNameProc from FirstNameWriter
                            // The DataWriter converts the 'FirstName'
                            // to the SqlParameter[] array needed to update a 'FirstName'.
                            updateFirstNameProc = FirstNameWriter.CreateUpdateFirstNameStoredProcedure(firstName);
                        }

                        // Verify updateFirstNameProc exists
                        if(updateFirstNameProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.FirstNameManager.UpdateFirstName(updateFirstNameProc, dataConnector);

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
