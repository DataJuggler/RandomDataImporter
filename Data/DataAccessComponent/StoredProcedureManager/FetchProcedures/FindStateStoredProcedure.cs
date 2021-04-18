

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindStateStoredProcedure
    /// <summary>
    /// This class is used to Find a 'State' object.
    /// </summary>
    public class FindStateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindStateStoredProcedure' object.
        /// </summary>
        public FindStateStoredProcedure()
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
                this.ProcedureName = "State_Find";

                // Set tableName
                this.TableName = "State";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
