

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class MemberAddressViewReader
    /// <summary>
    /// This class loads a single 'MemberAddressView' object or a list of type <MemberAddressView>.
    /// </summary>
    public class MemberAddressViewReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'MemberAddressView' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'MemberAddressView' DataObject.</returns>
            public static MemberAddressView Load(DataRow dataRow)
            {
                // Initial Value
                MemberAddressView memberAddressView = new MemberAddressView();

                // Create field Integers
                int addressIdfield = 0;
                int cityfield = 1;
                int firstNamefield = 2;
                int lastNamefield = 3;
                int memberIdfield = 4;
                int stateCodefield = 5;
                int stateIdfield = 6;
                int stateNamefield = 7;
                int streetAddressfield = 8;
                int unitfield = 9;
                int zipCodefield = 10;

                try
                {
                    // Load Each field
                    memberAddressView.AddressId = DataHelper.ParseInteger(dataRow.ItemArray[addressIdfield], 0);
                    memberAddressView.City = DataHelper.ParseString(dataRow.ItemArray[cityfield]);
                    memberAddressView.FirstName = DataHelper.ParseString(dataRow.ItemArray[firstNamefield]);
                    memberAddressView.LastName = DataHelper.ParseString(dataRow.ItemArray[lastNamefield]);
                    memberAddressView.MemberId = DataHelper.ParseInteger(dataRow.ItemArray[memberIdfield], 0);
                    memberAddressView.StateCode = DataHelper.ParseString(dataRow.ItemArray[stateCodefield]);
                    memberAddressView.StateId = DataHelper.ParseInteger(dataRow.ItemArray[stateIdfield], 0);
                    memberAddressView.StateName = DataHelper.ParseString(dataRow.ItemArray[stateNamefield]);
                    memberAddressView.StreetAddress = DataHelper.ParseString(dataRow.ItemArray[streetAddressfield]);
                    memberAddressView.Unit = DataHelper.ParseString(dataRow.ItemArray[unitfield]);
                    memberAddressView.ZipCode = DataHelper.ParseString(dataRow.ItemArray[zipCodefield]);
                }
                catch
                {
                }

                // return value
                return memberAddressView;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'MemberAddressView' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A MemberAddressView Collection.</returns>
            public static List<MemberAddressView> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<MemberAddressView> memberAddressViews = new List<MemberAddressView>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'MemberAddressView' from rows
                        MemberAddressView memberAddressView = Load(row);

                        // Add this object to collection
                        memberAddressViews.Add(memberAddressView);
                    }
                }
                catch
                {
                }

                // return value
                return memberAddressViews;
            }
            #endregion

        #endregion

    }
    #endregion

}
