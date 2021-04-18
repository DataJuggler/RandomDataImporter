

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindVerbStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Verb' object.
    /// </summary>
    public class FindVerbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindVerbStoredProcedure' object.
        /// </summary>
        public FindVerbStoredProcedure()
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
                this.ProcedureName = "Verb_Find";

                // Set tableName
                this.TableName = "Verb";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
