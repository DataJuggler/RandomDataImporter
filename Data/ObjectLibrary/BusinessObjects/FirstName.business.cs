

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class FirstName
    [Serializable]
    public partial class FirstName
    {

        #region Private Variables
        #endregion

        #region Constructor
        public FirstName()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public FirstName Clone()
            {
                // Create New Object
                FirstName newFirstName = (FirstName) this.MemberwiseClone();

                // Return Cloned Object
                return newFirstName;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
