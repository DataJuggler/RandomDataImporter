

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

    #region class VerbMethods
    /// <summary>
    /// This class contains methods for modifying a 'Verb' object.
    /// </summary>
    public class VerbMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'VerbMethods' object.
        /// </summary>
        public VerbMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteVerb(Verb)
            /// <summary>
            /// This method deletes a 'Verb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Verb' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteVerb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteVerbStoredProcedure deleteVerbProc = null;

                    // verify the first parameters is a(n) 'Verb'.
                    if (parameters[0].ObjectValue as Verb != null)
                    {
                        // Create Verb
                        Verb verb = (Verb) parameters[0].ObjectValue;

                        // verify verb exists
                        if(verb != null)
                        {
                            // Now create deleteVerbProc from VerbWriter
                            // The DataWriter converts the 'Verb'
                            // to the SqlParameter[] array needed to delete a 'Verb'.
                            deleteVerbProc = VerbWriter.CreateDeleteVerbStoredProcedure(verb);
                        }
                    }

                    // Verify deleteVerbProc exists
                    if(deleteVerbProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.VerbManager.DeleteVerb(deleteVerbProc, dataConnector);

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
            /// This method fetches all 'Verb' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Verb' to delete.
            /// <returns>A PolymorphicObject object with all  'Verbs' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Verb> verbListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllVerbsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get VerbParameter
                    // Declare Parameter
                    Verb paramVerb = null;

                    // verify the first parameters is a(n) 'Verb'.
                    if (parameters[0].ObjectValue as Verb != null)
                    {
                        // Get VerbParameter
                        paramVerb = (Verb) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllVerbsProc from VerbWriter
                    fetchAllProc = VerbWriter.CreateFetchAllVerbsStoredProcedure(paramVerb);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    verbListCollection = this.DataManager.VerbManager.FetchAllVerbs(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(verbListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = verbListCollection;
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

            #region FindVerb(Verb)
            /// <summary>
            /// This method finds a 'Verb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Verb' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindVerb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Verb verb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindVerbStoredProcedure findVerbProc = null;

                    // verify the first parameters is a 'Verb'.
                    if (parameters[0].ObjectValue as Verb != null)
                    {
                        // Get VerbParameter
                        Verb paramVerb = (Verb) parameters[0].ObjectValue;

                        // verify paramVerb exists
                        if(paramVerb != null)
                        {
                            // Now create findVerbProc from VerbWriter
                            // The DataWriter converts the 'Verb'
                            // to the SqlParameter[] array needed to find a 'Verb'.
                            findVerbProc = VerbWriter.CreateFindVerbStoredProcedure(paramVerb);
                        }

                        // Verify findVerbProc exists
                        if(findVerbProc != null)
                        {
                            // Execute Find Stored Procedure
                            verb = this.DataManager.VerbManager.FindVerb(findVerbProc, dataConnector);

                            // if dataObject exists
                            if(verb != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = verb;
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

            #region InsertVerb (Verb)
            /// <summary>
            /// This method inserts a 'Verb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Verb' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertVerb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Verb verb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertVerbStoredProcedure insertVerbProc = null;

                    // verify the first parameters is a(n) 'Verb'.
                    if (parameters[0].ObjectValue as Verb != null)
                    {
                        // Create Verb Parameter
                        verb = (Verb) parameters[0].ObjectValue;

                        // verify verb exists
                        if(verb != null)
                        {
                            // Now create insertVerbProc from VerbWriter
                            // The DataWriter converts the 'Verb'
                            // to the SqlParameter[] array needed to insert a 'Verb'.
                            insertVerbProc = VerbWriter.CreateInsertVerbStoredProcedure(verb);
                        }

                        // Verify insertVerbProc exists
                        if(insertVerbProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.VerbManager.InsertVerb(insertVerbProc, dataConnector);
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

            #region UpdateVerb (Verb)
            /// <summary>
            /// This method updates a 'Verb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Verb' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateVerb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Verb verb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateVerbStoredProcedure updateVerbProc = null;

                    // verify the first parameters is a(n) 'Verb'.
                    if (parameters[0].ObjectValue as Verb != null)
                    {
                        // Create Verb Parameter
                        verb = (Verb) parameters[0].ObjectValue;

                        // verify verb exists
                        if(verb != null)
                        {
                            // Now create updateVerbProc from VerbWriter
                            // The DataWriter converts the 'Verb'
                            // to the SqlParameter[] array needed to update a 'Verb'.
                            updateVerbProc = VerbWriter.CreateUpdateVerbStoredProcedure(verb);
                        }

                        // Verify updateVerbProc exists
                        if(updateVerbProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.VerbManager.UpdateVerb(updateVerbProc, dataConnector);

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
