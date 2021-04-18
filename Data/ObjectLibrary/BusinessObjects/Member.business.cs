

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Member
    [Serializable]
    public partial class Member
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Member()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Member Clone()
            {
                // Create New Object
                Member newMember = (Member) this.MemberwiseClone();

                // Return Cloned Object
                return newMember;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
