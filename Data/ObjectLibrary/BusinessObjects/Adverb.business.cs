

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Adverb
    [Serializable]
    public partial class Adverb
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Adverb()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Adverb Clone()
            {
                // Create New Object
                Adverb newAdverb = (Adverb) this.MemberwiseClone();

                // Return Cloned Object
                return newAdverb;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
