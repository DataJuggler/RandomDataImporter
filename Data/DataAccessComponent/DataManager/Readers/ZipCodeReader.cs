

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class ZipCodeReader
    /// <summary>
    /// This class loads a single 'ZipCode' object or a list of type <ZipCode>.
    /// </summary>
    public class ZipCodeReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'ZipCode' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'ZipCode' DataObject.</returns>
            public static ZipCode Load(DataRow dataRow)
            {
                // Initial Value
                ZipCode zipCode = new ZipCode();

                // Create field Integers
                int cityNamefield = 0;
                int idfield = 1;
                int namefield = 2;
                int stateIdfield = 3;

                try
                {
                    // Load Each field
                    zipCode.CityName = DataHelper.ParseString(dataRow.ItemArray[cityNamefield]);
                    zipCode.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    zipCode.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    zipCode.StateId = DataHelper.ParseInteger(dataRow.ItemArray[stateIdfield], 0);
                }
                catch
                {
                }

                // return value
                return zipCode;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'ZipCode' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A ZipCode Collection.</returns>
            public static List<ZipCode> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<ZipCode> zipCodes = new List<ZipCode>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'ZipCode' from rows
                        ZipCode zipCode = Load(row);

                        // Add this object to collection
                        zipCodes.Add(zipCode);
                    }
                }
                catch
                {
                }

                // return value
                return zipCodes;
            }
            #endregion

        #endregion

    }
    #endregion

}
