

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class AdverbReader
    /// <summary>
    /// This class loads a single 'Adverb' object or a list of type <Adverb>.
    /// </summary>
    public class AdverbReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Adverb' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Adverb' DataObject.</returns>
            public static Adverb Load(DataRow dataRow)
            {
                // Initial Value
                Adverb adverb = new Adverb();

                // Create field Integers
                int idfield = 0;
                int syllablesfield = 1;
                int wordTextfield = 2;

                try
                {
                    // Load Each field
                    adverb.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    adverb.Syllables = DataHelper.ParseInteger(dataRow.ItemArray[syllablesfield], 0);
                    adverb.WordText = DataHelper.ParseString(dataRow.ItemArray[wordTextfield]);
                }
                catch
                {
                }

                // return value
                return adverb;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Adverb' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Adverb Collection.</returns>
            public static List<Adverb> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Adverb> adverbs = new List<Adverb>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Adverb' from rows
                        Adverb adverb = Load(row);

                        // Add this object to collection
                        adverbs.Add(adverb);
                    }
                }
                catch
                {
                }

                // return value
                return adverbs;
            }
            #endregion

        #endregion

    }
    #endregion

}
