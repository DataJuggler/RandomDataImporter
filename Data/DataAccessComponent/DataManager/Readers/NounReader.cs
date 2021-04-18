

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class NounReader
    /// <summary>
    /// This class loads a single 'Noun' object or a list of type <Noun>.
    /// </summary>
    public class NounReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Noun' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Noun' DataObject.</returns>
            public static Noun Load(DataRow dataRow)
            {
                // Initial Value
                Noun noun = new Noun();

                // Create field Integers
                int idfield = 0;
                int syllablesfield = 1;
                int wordTextfield = 2;

                try
                {
                    // Load Each field
                    noun.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    noun.Syllables = DataHelper.ParseInteger(dataRow.ItemArray[syllablesfield], 0);
                    noun.WordText = DataHelper.ParseString(dataRow.ItemArray[wordTextfield]);
                }
                catch
                {
                }

                // return value
                return noun;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Noun' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Noun Collection.</returns>
            public static List<Noun> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Noun> nouns = new List<Noun>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Noun' from rows
                        Noun noun = Load(row);

                        // Add this object to collection
                        nouns.Add(noun);
                    }
                }
                catch
                {
                }

                // return value
                return nouns;
            }
            #endregion

        #endregion

    }
    #endregion

}
