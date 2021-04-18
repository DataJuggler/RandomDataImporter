

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class ZipCode
    [Serializable]
    public partial class ZipCode
    {

        #region Private Variables
        #endregion

        #region Constructor
        public ZipCode()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public ZipCode Clone()
            {
                // Create New Object
                ZipCode newZipCode = (ZipCode) this.MemberwiseClone();

                // Return Cloned Object
                return newZipCode;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
