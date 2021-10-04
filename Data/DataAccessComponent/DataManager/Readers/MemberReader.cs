

#region using statements

using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class MemberReader
    /// <summary>
    /// This class loads a single 'Member' object or a list of type <Member>.
    /// </summary>
    public class MemberReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Member' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Member' DataObject.</returns>
            public static Member Load(DataRow dataRow)
            {
                // Initial Value
                Member member = new Member();

                // Create field Integers
                int activefield = 0;
                int emailAddressfield = 1;
                int firstNamefield = 2;
                int idfield = 3;
                int lastNamefield = 4;

                try
                {
                    // Load Each field
                    member.Active = DataHelper.ParseBoolean(dataRow.ItemArray[activefield], false);
                    member.EmailAddress = DataHelper.ParseString(dataRow.ItemArray[emailAddressfield]);
                    member.FirstName = DataHelper.ParseString(dataRow.ItemArray[firstNamefield]);
                    member.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    member.LastName = DataHelper.ParseString(dataRow.ItemArray[lastNamefield]);
                }
                catch
                {
                }

                // return value
                return member;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Member' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Member Collection.</returns>
            public static List<Member> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Member> members = new List<Member>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Member' from rows
                        Member member = Load(row);

                        // Add this object to collection
                        members.Add(member);
                    }
                }
                catch
                {
                }

                // return value
                return members;
            }
            #endregion

        #endregion

    }
    #endregion

}
