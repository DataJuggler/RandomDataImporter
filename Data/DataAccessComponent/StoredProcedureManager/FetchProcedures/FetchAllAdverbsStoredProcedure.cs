

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllAdverbsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Adverb' objects.
    /// </summary>
    public class FetchAllAdverbsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllAdverbsStoredProcedure' object.
        /// </summary>
        public FetchAllAdverbsStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "Adverb_FetchAll";

                // Set tableName
                this.TableName = "Adverb";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
