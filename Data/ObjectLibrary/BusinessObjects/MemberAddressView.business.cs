

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class MemberAddressView
    [Serializable]
    public partial class MemberAddressView
    {

        #region Private Variables
        #endregion

        #region Constructor
        public MemberAddressView()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public MemberAddressView Clone()
            {
                // Create New Object
                MemberAddressView newMemberAddressView = (MemberAddressView) this.MemberwiseClone();

                // Return Cloned Object
                return newMemberAddressView;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
