

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

    #region class AdverbMethods
    /// <summary>
    /// This class contains methods for modifying a 'Adverb' object.
    /// </summary>
    public class AdverbMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'AdverbMethods' object.
        /// </summary>
        public AdverbMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteAdverb(Adverb)
            /// <summary>
            /// This method deletes a 'Adverb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adverb' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteAdverb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteAdverbStoredProcedure deleteAdverbProc = null;

                    // verify the first parameters is a(n) 'Adverb'.
                    if (parameters[0].ObjectValue as Adverb != null)
                    {
                        // Create Adverb
                        Adverb adverb = (Adverb) parameters[0].ObjectValue;

                        // verify adverb exists
                        if(adverb != null)
                        {
                            // Now create deleteAdverbProc from AdverbWriter
                            // The DataWriter converts the 'Adverb'
                            // to the SqlParameter[] array needed to delete a 'Adverb'.
                            deleteAdverbProc = AdverbWriter.CreateDeleteAdverbStoredProcedure(adverb);
                        }
                    }

                    // Verify deleteAdverbProc exists
                    if(deleteAdverbProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.AdverbManager.DeleteAdverb(deleteAdverbProc, dataConnector);

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
            /// This method fetches all 'Adverb' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adverb' to delete.
            /// <returns>A PolymorphicObject object with all  'Adverbs' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Adverb> adverbListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllAdverbsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get AdverbParameter
                    // Declare Parameter
                    Adverb paramAdverb = null;

                    // verify the first parameters is a(n) 'Adverb'.
                    if (parameters[0].ObjectValue as Adverb != null)
                    {
                        // Get AdverbParameter
                        paramAdverb = (Adverb) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllAdverbsProc from AdverbWriter
                    fetchAllProc = AdverbWriter.CreateFetchAllAdverbsStoredProcedure(paramAdverb);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    adverbListCollection = this.DataManager.AdverbManager.FetchAllAdverbs(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(adverbListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = adverbListCollection;
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

            #region FindAdverb(Adverb)
            /// <summary>
            /// This method finds a 'Adverb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adverb' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindAdverb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adverb adverb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindAdverbStoredProcedure findAdverbProc = null;

                    // verify the first parameters is a 'Adverb'.
                    if (parameters[0].ObjectValue as Adverb != null)
                    {
                        // Get AdverbParameter
                        Adverb paramAdverb = (Adverb) parameters[0].ObjectValue;

                        // verify paramAdverb exists
                        if(paramAdverb != null)
                        {
                            // Now create findAdverbProc from AdverbWriter
                            // The DataWriter converts the 'Adverb'
                            // to the SqlParameter[] array needed to find a 'Adverb'.
                            findAdverbProc = AdverbWriter.CreateFindAdverbStoredProcedure(paramAdverb);
                        }

                        // Verify findAdverbProc exists
                        if(findAdverbProc != null)
                        {
                            // Execute Find Stored Procedure
                            adverb = this.DataManager.AdverbManager.FindAdverb(findAdverbProc, dataConnector);

                            // if dataObject exists
                            if(adverb != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = adverb;
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

            #region InsertAdverb (Adverb)
            /// <summary>
            /// This method inserts a 'Adverb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adverb' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertAdverb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adverb adverb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertAdverbStoredProcedure insertAdverbProc = null;

                    // verify the first parameters is a(n) 'Adverb'.
                    if (parameters[0].ObjectValue as Adverb != null)
                    {
                        // Create Adverb Parameter
                        adverb = (Adverb) parameters[0].ObjectValue;

                        // verify adverb exists
                        if(adverb != null)
                        {
                            // Now create insertAdverbProc from AdverbWriter
                            // The DataWriter converts the 'Adverb'
                            // to the SqlParameter[] array needed to insert a 'Adverb'.
                            insertAdverbProc = AdverbWriter.CreateInsertAdverbStoredProcedure(adverb);
                        }

                        // Verify insertAdverbProc exists
                        if(insertAdverbProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.AdverbManager.InsertAdverb(insertAdverbProc, dataConnector);
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

            #region UpdateAdverb (Adverb)
            /// <summary>
            /// This method updates a 'Adverb' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Adverb' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateAdverb(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Adverb adverb = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateAdverbStoredProcedure updateAdverbProc = null;

                    // verify the first parameters is a(n) 'Adverb'.
                    if (parameters[0].ObjectValue as Adverb != null)
                    {
                        // Create Adverb Parameter
                        adverb = (Adverb) parameters[0].ObjectValue;

                        // verify adverb exists
                        if(adverb != null)
                        {
                            // Now create updateAdverbProc from AdverbWriter
                            // The DataWriter converts the 'Adverb'
                            // to the SqlParameter[] array needed to update a 'Adverb'.
                            updateAdverbProc = AdverbWriter.CreateUpdateAdverbStoredProcedure(adverb);
                        }

                        // Verify updateAdverbProc exists
                        if(updateAdverbProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.AdverbManager.UpdateAdverb(updateAdverbProc, dataConnector);

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
