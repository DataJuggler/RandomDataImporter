

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class VerbReader
    /// <summary>
    /// This class loads a single 'Verb' object or a list of type <Verb>.
    /// </summary>
    public class VerbReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Verb' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Verb' DataObject.</returns>
            public static Verb Load(DataRow dataRow)
            {
                // Initial Value
                Verb verb = new Verb();

                // Create field Integers
                int idfield = 0;
                int syllablesfield = 1;
                int wordTextfield = 2;

                try
                {
                    // Load Each field
                    verb.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    verb.Syllables = DataHelper.ParseInteger(dataRow.ItemArray[syllablesfield], 0);
                    verb.WordText = DataHelper.ParseString(dataRow.ItemArray[wordTextfield]);
                }
                catch
                {
                }

                // return value
                return verb;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Verb' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Verb Collection.</returns>
            public static List<Verb> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Verb> verbs = new List<Verb>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Verb' from rows
                        Verb verb = Load(row);

                        // Add this object to collection
                        verbs.Add(verb);
                    }
                }
                catch
                {
                }

                // return value
                return verbs;
            }
            #endregion

        #endregion

    }
    #endregion

}
