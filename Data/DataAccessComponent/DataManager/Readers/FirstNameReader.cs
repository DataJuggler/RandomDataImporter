

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class FirstNameReader
    /// <summary>
    /// This class loads a single 'FirstName' object or a list of type <FirstName>.
    /// </summary>
    public class FirstNameReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'FirstName' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'FirstName' DataObject.</returns>
            public static FirstName Load(DataRow dataRow)
            {
                // Initial Value
                FirstName firstName = new FirstName();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;

                try
                {
                    // Load Each field
                    firstName.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    firstName.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                }
                catch
                {
                }

                // return value
                return firstName;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'FirstName' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A FirstName Collection.</returns>
            public static List<FirstName> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<FirstName> firstNames = new List<FirstName>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'FirstName' from rows
                        FirstName firstName = Load(row);

                        // Add this object to collection
                        firstNames.Add(firstName);
                    }
                }
                catch
                {
                }

                // return value
                return firstNames;
            }
            #endregion

        #endregion

    }
    #endregion

}
