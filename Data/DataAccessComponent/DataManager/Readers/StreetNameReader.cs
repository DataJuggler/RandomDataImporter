

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class StreetNameReader
    /// <summary>
    /// This class loads a single 'StreetName' object or a list of type <StreetName>.
    /// </summary>
    public class StreetNameReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'StreetName' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'StreetName' DataObject.</returns>
            public static StreetName Load(DataRow dataRow)
            {
                // Initial Value
                StreetName streetName = new StreetName();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;

                try
                {
                    // Load Each field
                    streetName.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    streetName.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                }
                catch
                {
                }

                // return value
                return streetName;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'StreetName' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A StreetName Collection.</returns>
            public static List<StreetName> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<StreetName> streetNames = new List<StreetName>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'StreetName' from rows
                        StreetName streetName = Load(row);

                        // Add this object to collection
                        streetNames.Add(streetName);
                    }
                }
                catch
                {
                }

                // return value
                return streetNames;
            }
            #endregion

        #endregion

    }
    #endregion

}
