

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

    #region class AdjectiveMethods
    /// <summary>
    /// This class contains methods for modifying a 'Adjective' object.
    /// </summary>
    public class AdjectiveMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'AdjectiveMethods' object.
        /// </summary>
        public AdjectiveMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteAdjective(Adjective)
            /// <summary>
            /// This method deletes a 'Adjective' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adjective' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteAdjective(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteAdjectiveStoredProcedure deleteAdjectiveProc = null;

                    // verify the first parameters is a(n) 'Adjective'.
                    if (parameters[0].ObjectValue as Adjective != null)
                    {
                        // Create Adjective
                        Adjective adjective = (Adjective) parameters[0].ObjectValue;

                        // verify adjective exists
                        if(adjective != null)
                        {
                            // Now create deleteAdjectiveProc from AdjectiveWriter
                            // The DataWriter converts the 'Adjective'
                            // to the SqlParameter[] array needed to delete a 'Adjective'.
                            deleteAdjectiveProc = AdjectiveWriter.CreateDeleteAdjectiveStoredProcedure(adjective);
                        }
                    }

                    // Verify deleteAdjectiveProc exists
                    if(deleteAdjectiveProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.AdjectiveManager.DeleteAdjective(deleteAdjectiveProc, dataConnector);

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
            /// This method fetches all 'Adjective' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adjective' to delete.
            /// <returns>A PolymorphicObject object with all  'Adjectives' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Adjective> adjectiveListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllAdjectivesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get AdjectiveParameter
                    // Declare Parameter
                    Adjective paramAdjective = null;

                    // verify the first parameters is a(n) 'Adjective'.
                    if (parameters[0].ObjectValue as Adjective != null)
                    {
                        // Get AdjectiveParameter
                        paramAdjective = (Adjective) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllAdjectivesProc from AdjectiveWriter
                    fetchAllProc = AdjectiveWriter.CreateFetchAllAdjectivesStoredProcedure(paramAdjective);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    adjectiveListCollection = this.DataManager.AdjectiveManager.FetchAllAdjectives(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(adjectiveListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = adjectiveListCollection;
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

            #region FindAdjective(Adjective)
            /// <summary>
            /// This method finds a 'Adjective' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adjective' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindAdjective(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adjective adjective = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindAdjectiveStoredProcedure findAdjectiveProc = null;

                    // verify the first parameters is a 'Adjective'.
                    if (parameters[0].ObjectValue as Adjective != null)
                    {
                        // Get AdjectiveParameter
                        Adjective paramAdjective = (Adjective) parameters[0].ObjectValue;

                        // verify paramAdjective exists
                        if(paramAdjective != null)
                        {
                            // Now create findAdjectiveProc from AdjectiveWriter
                            // The DataWriter converts the 'Adjective'
                            // to the SqlParameter[] array needed to find a 'Adjective'.
                            findAdjectiveProc = AdjectiveWriter.CreateFindAdjectiveStoredProcedure(paramAdjective);
                        }

                        // Verify findAdjectiveProc exists
                        if(findAdjectiveProc != null)
                        {
                            // Execute Find Stored Procedure
                            adjective = this.DataManager.AdjectiveManager.FindAdjective(findAdjectiveProc, dataConnector);

                            // if dataObject exists
                            if(adjective != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = adjective;
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

            #region InsertAdjective (Adjective)
            /// <summary>
            /// This method inserts a 'Adjective' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adjective' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertAdjective(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adjective adjective = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertAdjectiveStoredProcedure insertAdjectiveProc = null;

                    // verify the first parameters is a(n) 'Adjective'.
                    if (parameters[0].ObjectValue as Adjective != null)
                    {
                        // Create Adjective Parameter
                        adjective = (Adjective) parameters[0].ObjectValue;

                        // verify adjective exists
                        if(adjective != null)
                        {
                            // Now create insertAdjectiveProc from AdjectiveWriter
                            // The DataWriter converts the 'Adjective'
                            // to the SqlParameter[] array needed to insert a 'Adjective'.
                            insertAdjectiveProc = AdjectiveWriter.CreateInsertAdjectiveStoredProcedure(adjective);
                        }

                        // Verify insertAdjectiveProc exists
                        if(insertAdjectiveProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.AdjectiveManager.InsertAdjective(insertAdjectiveProc, dataConnector);
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

            #region UpdateAdjective (Adjective)
            /// <summary>
            /// This method updates a 'Adjective' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adjective' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateAdjective(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adjective adjective = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateAdjectiveStoredProcedure updateAdjectiveProc = null;

                    // verify the first parameters is a(n) 'Adjective'.
                    if (parameters[0].ObjectValue as Adjective != null)
                    {
                        // Create Adjective Parameter
                        adjective = (Adjective) parameters[0].ObjectValue;

                        // verify adjective exists
                        if(adjective != null)
                        {
                            // Now create updateAdjectiveProc from AdjectiveWriter
                            // The DataWriter converts the 'Adjective'
                            // to the SqlParameter[] array needed to update a 'Adjective'.
                            updateAdjectiveProc = AdjectiveWriter.CreateUpdateAdjectiveStoredProcedure(adjective);
                        }

                        // Verify updateAdjectiveProc exists
                        if(updateAdjectiveProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.AdjectiveManager.UpdateAdjective(updateAdjectiveProc, dataConnector);

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
