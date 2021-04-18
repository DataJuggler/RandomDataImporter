

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class MemberAddressView
    public partial class MemberAddressView
    {

        #region Private Variables
        private int addressId;
        private string city;
        private string firstName;
        private string lastName;
        private int memberId;
        private string stateCode;
        private int stateId;
        private string stateName;
        private string streetAddress;
        private string unit;
        private string zipCode;
        #endregion

        #region Methods


        #endregion

        #region Properties

            #region int AddressId
            public int AddressId
            {
                get
                {
                    return addressId;
                }
                set
                {
                    addressId = value;
                }
            }
            #endregion

            #region string City
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }
            #endregion

            #region string FirstName
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            #endregion

            #region string LastName
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            #endregion

            #region int MemberId
            public int MemberId
            {
                get
                {
                    return memberId;
                }
                set
                {
                    memberId = value;
                }
            }
            #endregion

            #region string StateCode
            public string StateCode
            {
                get
                {
                    return stateCode;
                }
                set
                {
                    stateCode = value;
                }
            }
            #endregion

            #region int StateId
            public int StateId
            {
                get
                {
                    return stateId;
                }
                set
                {
                    stateId = value;
                }
            }
            #endregion

            #region string StateName
            public string StateName
            {
                get
                {
                    return stateName;
                }
                set
                {
                    stateName = value;
                }
            }
            #endregion

            #region string StreetAddress
            public string StreetAddress
            {
                get
                {
                    return streetAddress;
                }
                set
                {
                    streetAddress = value;
                }
            }
            #endregion

            #region string Unit
            public string Unit
            {
                get
                {
                    return unit;
                }
                set
                {
                    unit = value;
                }
            }
            #endregion

            #region string ZipCode
            public string ZipCode
            {
                get
                {
                    return zipCode;
                }
                set
                {
                    zipCode = value;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
