

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

    #region class StateMethods
    /// <summary>
    /// This class contains methods for modifying a 'State' object.
    /// </summary>
    public class StateMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'StateMethods' object.
        /// </summary>
        public StateMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteState(State)
            /// <summary>
            /// This method deletes a 'State' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'State' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteState(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteStateStoredProcedure deleteStateProc = null;

                    // verify the first parameters is a(n) 'State'.
                    if (parameters[0].ObjectValue as State != null)
                    {
                        // Create State
                        State state = (State) parameters[0].ObjectValue;

                        // verify state exists
                        if(state != null)
                        {
                            // Now create deleteStateProc from StateWriter
                            // The DataWriter converts the 'State'
                            // to the SqlParameter[] array needed to delete a 'State'.
                            deleteStateProc = StateWriter.CreateDeleteStateStoredProcedure(state);
                        }
                    }

                    // Verify deleteStateProc exists
                    if(deleteStateProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.StateManager.DeleteState(deleteStateProc, dataConnector);

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
            /// This method fetches all 'State' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'State' to delete.
            /// <returns>A PolymorphicObject object with all  'States' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<State> stateListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllStatesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get StateParameter
                    // Declare Parameter
                    State paramState = null;

                    // verify the first parameters is a(n) 'State'.
                    if (parameters[0].ObjectValue as State != null)
                    {
                        // Get StateParameter
                        paramState = (State) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllStatesProc from StateWriter
                    fetchAllProc = StateWriter.CreateFetchAllStatesStoredProcedure(paramState);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    stateListCollection = this.DataManager.StateManager.FetchAllStates(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(stateListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = stateListCollection;
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

            #region FindState(State)
            /// <summary>
            /// This method finds a 'State' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'State' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindState(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                State state = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindStateStoredProcedure findStateProc = null;

                    // verify the first parameters is a 'State'.
                    if (parameters[0].ObjectValue as State != null)
                    {
                        // Get StateParameter
                        State paramState = (State) parameters[0].ObjectValue;

                        // verify paramState exists
                        if(paramState != null)
                        {
                            // Now create findStateProc from StateWriter
                            // The DataWriter converts the 'State'
                            // to the SqlParameter[] array needed to find a 'State'.
                            findStateProc = StateWriter.CreateFindStateStoredProcedure(paramState);
                        }

                        // Verify findStateProc exists
                        if(findStateProc != null)
                        {
                            // Execute Find Stored Procedure
                            state = this.DataManager.StateManager.FindState(findStateProc, dataConnector);

                            // if dataObject exists
                            if(state != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = state;
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

            #region InsertState (State)
            /// <summary>
            /// This method inserts a 'State' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'State' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertState(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                State state = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertStateStoredProcedure insertStateProc = null;

                    // verify the first parameters is a(n) 'State'.
                    if (parameters[0].ObjectValue as State != null)
                    {
                        // Create State Parameter
                        state = (State) parameters[0].ObjectValue;

                        // verify state exists
                        if(state != null)
                        {
                            // Now create insertStateProc from StateWriter
                            // The DataWriter converts the 'State'
                            // to the SqlParameter[] array needed to insert a 'State'.
                            insertStateProc = StateWriter.CreateInsertStateStoredProcedure(state);
                        }

                        // Verify insertStateProc exists
                        if(insertStateProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.StateManager.InsertState(insertStateProc, dataConnector);
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

            #region UpdateState (State)
            /// <summary>
            /// This method updates a 'State' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'State' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateState(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                State state = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateStateStoredProcedure updateStateProc = null;

                    // verify the first parameters is a(n) 'State'.
                    if (parameters[0].ObjectValue as State != null)
                    {
                        // Create State Parameter
                        state = (State) parameters[0].ObjectValue;

                        // verify state exists
                        if(state != null)
                        {
                            // Now create updateStateProc from StateWriter
                            // The DataWriter converts the 'State'
                            // to the SqlParameter[] array needed to update a 'State'.
                            updateStateProc = StateWriter.CreateUpdateStateStoredProcedure(state);
                        }

                        // Verify updateStateProc exists
                        if(updateStateProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.StateManager.UpdateState(updateStateProc, dataConnector);

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
