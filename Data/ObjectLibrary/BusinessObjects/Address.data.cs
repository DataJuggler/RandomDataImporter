

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Address
    public partial class Address
    {

        #region Private Variables
        private string city;
        private int id;
        private int memberId;
        private int stateId;
        private string streetAddress;
        private string unit;
        private string zipCode;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

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

            #region int Id
            public int Id
            {
                get
                {
                    return id;
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

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
