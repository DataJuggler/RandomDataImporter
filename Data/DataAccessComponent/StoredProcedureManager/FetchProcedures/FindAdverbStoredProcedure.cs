

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindAdverbStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Adverb' object.
    /// </summary>
    public class FindAdverbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindAdverbStoredProcedure' object.
        /// </summary>
        public FindAdverbStoredProcedure()
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
                this.ProcedureName = "Adverb_Find";

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
