

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Verb
    [Serializable]
    public partial class Verb
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Verb()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Verb Clone()
            {
                // Create New Object
                Verb newVerb = (Verb) this.MemberwiseClone();

                // Return Cloned Object
                return newVerb;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
