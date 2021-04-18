

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class StateReader
    /// <summary>
    /// This class loads a single 'State' object or a list of type <State>.
    /// </summary>
    public class StateReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'State' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'State' DataObject.</returns>
            public static State Load(DataRow dataRow)
            {
                // Initial Value
                State state = new State();

                // Create field Integers
                int codefield = 0;
                int idfield = 1;
                int namefield = 2;

                try
                {
                    // Load Each field
                    state.Code = DataHelper.ParseString(dataRow.ItemArray[codefield]);
                    state.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    state.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                }
                catch
                {
                }

                // return value
                return state;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'State' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A State Collection.</returns>
            public static List<State> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<State> states = new List<State>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'State' from rows
                        State state = Load(row);

                        // Add this object to collection
                        states.Add(state);
                    }
                }
                catch
                {
                }

                // return value
                return states;
            }
            #endregion

        #endregion

    }
    #endregion

}
