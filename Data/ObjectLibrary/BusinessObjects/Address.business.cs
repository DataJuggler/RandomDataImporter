

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Address
    [Serializable]
    public partial class Address
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Address()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Address Clone()
            {
                // Create New Object
                Address newAddress = (Address) this.MemberwiseClone();

                // Return Cloned Object
                return newAddress;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
