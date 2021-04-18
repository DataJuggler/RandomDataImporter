

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Verb
    public partial class Verb
    {

        #region Private Variables
        private int id;
        private int syllables;
        private string wordText;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region int Syllables
            public int Syllables
            {
                get
                {
                    return syllables;
                }
                set
                {
                    syllables = value;
                }
            }
            #endregion

            #region string WordText
            public string WordText
            {
                get
                {
                    return wordText;
                }
                set
                {
                    wordText = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
