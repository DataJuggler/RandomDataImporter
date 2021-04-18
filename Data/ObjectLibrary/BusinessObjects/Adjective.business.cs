

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Adjective
    [Serializable]
    public partial class Adjective
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Adjective()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Adjective Clone()
            {
                // Create New Object
                Adjective newAdjective = (Adjective) this.MemberwiseClone();

                // Return Cloned Object
                return newAdjective;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
