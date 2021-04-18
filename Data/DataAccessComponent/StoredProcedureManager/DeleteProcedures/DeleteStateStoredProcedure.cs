

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteStateStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'State' object.
    /// </summary>
    public class DeleteStateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteStateStoredProcedure' object.
        /// </summary>
        public DeleteStateStoredProcedure()
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
                this.ProcedureName = "State_Delete";

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
