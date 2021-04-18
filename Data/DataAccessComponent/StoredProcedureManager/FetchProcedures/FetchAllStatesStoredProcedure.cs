

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllStatesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'State' objects.
    /// </summary>
    public class FetchAllStatesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllStatesStoredProcedure' object.
        /// </summary>
        public FetchAllStatesStoredProcedure()
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
                this.ProcedureName = "State_FetchAll";

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
