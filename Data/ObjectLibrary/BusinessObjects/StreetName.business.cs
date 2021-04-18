

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class StreetName
    [Serializable]
    public partial class StreetName
    {

        #region Private Variables
        #endregion

        #region Constructor
        public StreetName()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public StreetName Clone()
            {
                // Create New Object
                StreetName newStreetName = (StreetName) this.MemberwiseClone();

                // Return Cloned Object
                return newStreetName;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
