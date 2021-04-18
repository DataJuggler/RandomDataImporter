

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class AdjectiveReader
    /// <summary>
    /// This class loads a single 'Adjective' object or a list of type <Adjective>.
    /// </summary>
    public class AdjectiveReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Adjective' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Adjective' DataObject.</returns>
            public static Adjective Load(DataRow dataRow)
            {
                // Initial Value
                Adjective adjective = new Adjective();

                // Create field Integers
                int idfield = 0;
                int syllablesfield = 1;
                int wordTextfield = 2;

                try
                {
                    // Load Each field
                    adjective.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    adjective.Syllables = DataHelper.ParseInteger(dataRow.ItemArray[syllablesfield], 0);
                    adjective.WordText = DataHelper.ParseString(dataRow.ItemArray[wordTextfield]);
                }
                catch
                {
                }

                // return value
                return adjective;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Adjective' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Adjective Collection.</returns>
            public static List<Adjective> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Adjective> adjectives = new List<Adjective>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Adjective' from rows
                        Adjective adjective = Load(row);

                        // Add this object to collection
                        adjectives.Add(adjective);
                    }
                }
                catch
                {
                }

                // return value
                return adjectives;
            }
            #endregion

        #endregion

    }
    #endregion

}
