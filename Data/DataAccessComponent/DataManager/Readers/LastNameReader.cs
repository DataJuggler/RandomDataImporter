

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class LastNameReader
    /// <summary>
    /// This class loads a single 'LastName' object or a list of type <LastName>.
    /// </summary>
    public class LastNameReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'LastName' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'LastName' DataObject.</returns>
            public static LastName Load(DataRow dataRow)
            {
                // Initial Value
                LastName lastName = new LastName();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;

                try
                {
                    // Load Each field
                    lastName.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    lastName.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                }
                catch
                {
                }

                // return value
                return lastName;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'LastName' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A LastName Collection.</returns>
            public static List<LastName> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<LastName> lastNames = new List<LastName>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'LastName' from rows
                        LastName lastName = Load(row);

                        // Add this object to collection
                        lastNames.Add(lastName);
                    }
                }
                catch
                {
                }

                // return value
                return lastNames;
            }
            #endregion

        #endregion

    }
    #endregion

}
