

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

    #region class NounMethods
    /// <summary>
    /// This class contains methods for modifying a 'Noun' object.
    /// </summary>
    public class NounMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'NounMethods' object.
        /// </summary>
        public NounMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteNoun(Noun)
            /// <summary>
            /// This method deletes a 'Noun' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Noun' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteNoun(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteNounStoredProcedure deleteNounProc = null;

                    // verify the first parameters is a(n) 'Noun'.
                    if (parameters[0].ObjectValue as Noun != null)
                    {
                        // Create Noun
                        Noun noun = (Noun) parameters[0].ObjectValue;

                        // verify noun exists
                        if(noun != null)
                        {
                            // Now create deleteNounProc from NounWriter
                            // The DataWriter converts the 'Noun'
                            // to the SqlParameter[] array needed to delete a 'Noun'.
                            deleteNounProc = NounWriter.CreateDeleteNounStoredProcedure(noun);
                        }
                    }

                    // Verify deleteNounProc exists
                    if(deleteNounProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.NounManager.DeleteNoun(deleteNounProc, dataConnector);

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
            /// This method fetches all 'Noun' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Noun' to delete.
            /// <returns>A PolymorphicObject object with all  'Nouns' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Noun> nounListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllNounsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get NounParameter
                    // Declare Parameter
                    Noun paramNoun = null;

                    // verify the first parameters is a(n) 'Noun'.
                    if (parameters[0].ObjectValue as Noun != null)
                    {
                        // Get NounParameter
                        paramNoun = (Noun) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllNounsProc from NounWriter
                    fetchAllProc = NounWriter.CreateFetchAllNounsStoredProcedure(paramNoun);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    nounListCollection = this.DataManager.NounManager.FetchAllNouns(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(nounListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = nounListCollection;
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

            #region FindNoun(Noun)
            /// <summary>
            /// This method finds a 'Noun' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Noun' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindNoun(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Noun noun = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindNounStoredProcedure findNounProc = null;

                    // verify the first parameters is a 'Noun'.
                    if (parameters[0].ObjectValue as Noun != null)
                    {
                        // Get NounParameter
                        Noun paramNoun = (Noun) parameters[0].ObjectValue;

                        // verify paramNoun exists
                        if(paramNoun != null)
                        {
                            // Now create findNounProc from NounWriter
                            // The DataWriter converts the 'Noun'
                            // to the SqlParameter[] array needed to find a 'Noun'.
                            findNounProc = NounWriter.CreateFindNounStoredProcedure(paramNoun);
                        }

                        // Verify findNounProc exists
                        if(findNounProc != null)
                        {
                            // Execute Find Stored Procedure
                            noun = this.DataManager.NounManager.FindNoun(findNounProc, dataConnector);

                            // if dataObject exists
                            if(noun != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = noun;
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

            #region InsertNoun (Noun)
            /// <summary>
            /// This method inserts a 'Noun' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Noun' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertNoun(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Noun noun = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertNounStoredProcedure insertNounProc = null;

                    // verify the first parameters is a(n) 'Noun'.
                    if (parameters[0].ObjectValue as Noun != null)
                    {
                        // Create Noun Parameter
                        noun = (Noun) parameters[0].ObjectValue;

                        // verify noun exists
                        if(noun != null)
                        {
                            // Now create insertNounProc from NounWriter
                            // The DataWriter converts the 'Noun'
                            // to the SqlParameter[] array needed to insert a 'Noun'.
                            insertNounProc = NounWriter.CreateInsertNounStoredProcedure(noun);
                        }

                        // Verify insertNounProc exists
                        if(insertNounProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.NounManager.InsertNoun(insertNounProc, dataConnector);
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

            #region UpdateNoun (Noun)
            /// <summary>
            /// This method updates a 'Noun' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Noun' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateNoun(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Noun noun = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateNounStoredProcedure updateNounProc = null;

                    // verify the first parameters is a(n) 'Noun'.
                    if (parameters[0].ObjectValue as Noun != null)
                    {
                        // Create Noun Parameter
                        noun = (Noun) parameters[0].ObjectValue;

                        // verify noun exists
                        if(noun != null)
                        {
                            // Now create updateNounProc from NounWriter
                            // The DataWriter converts the 'Noun'
                            // to the SqlParameter[] array needed to update a 'Noun'.
                            updateNounProc = NounWriter.CreateUpdateNounStoredProcedure(noun);
                        }

                        // Verify updateNounProc exists
                        if(updateNounProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.NounManager.UpdateNoun(updateNounProc, dataConnector);

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
