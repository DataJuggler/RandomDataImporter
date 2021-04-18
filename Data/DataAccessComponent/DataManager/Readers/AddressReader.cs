

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class AddressReader
    /// <summary>
    /// This class loads a single 'Address' object or a list of type <Address>.
    /// </summary>
    public class AddressReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Address' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Address' DataObject.</returns>
            public static Address Load(DataRow dataRow)
            {
                // Initial Value
                Address address = new Address();

                // Create field Integers
                int cityfield = 0;
                int idfield = 1;
                int memberIdfield = 2;
                int stateIdfield = 3;
                int streetAddressfield = 4;
                int unitfield = 5;
                int zipCodefield = 6;

                try
                {
                    // Load Each field
                    address.City = DataHelper.ParseString(dataRow.ItemArray[cityfield]);
                    address.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    address.MemberId = DataHelper.ParseInteger(dataRow.ItemArray[memberIdfield], 0);
                    address.StateId = DataHelper.ParseInteger(dataRow.ItemArray[stateIdfield], 0);
                    address.StreetAddress = DataHelper.ParseString(dataRow.ItemArray[streetAddressfield]);
                    address.Unit = DataHelper.ParseString(dataRow.ItemArray[unitfield]);
                    address.ZipCode = DataHelper.ParseString(dataRow.ItemArray[zipCodefield]);
                }
                catch
                {
                }

                // return value
                return address;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Address' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Address Collection.</returns>
            public static List<Address> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Address> addresses = new List<Address>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Address' from rows
                        Address addres = Load(row);

                        // Add this object to collection
                        addresses.Add(addres);
                    }
                }
                catch
                {
                }

                // return value
                return addresses;
            }
            #endregion

        #endregion

    }
    #endregion

}
