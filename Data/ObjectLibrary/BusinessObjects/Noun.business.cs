

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Noun
    [Serializable]
    public partial class Noun
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Noun()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Noun Clone()
            {
                // Create New Object
                Noun newNoun = (Noun) this.MemberwiseClone();

                // Return Cloned Object
                return newNoun;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
