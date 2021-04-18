

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateStateStoredProcedure
    /// <summary>
    /// This class is used to Update a 'State' object.
    /// </summary>
    public class UpdateStateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateStateStoredProcedure' object.
        /// </summary>
        public UpdateStateStoredProcedure()
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
                this.ProcedureName = "State_Update";

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
