

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class LastName
    [Serializable]
    public partial class LastName
    {

        #region Private Variables
        #endregion

        #region Constructor
        public LastName()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public LastName Clone()
            {
                // Create New Object
                LastName newLastName = (LastName) this.MemberwiseClone();

                // Return Cloned Object
                return newLastName;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
