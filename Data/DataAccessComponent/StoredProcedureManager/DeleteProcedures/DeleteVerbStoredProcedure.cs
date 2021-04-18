

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteVerbStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Verb' object.
    /// </summary>
    public class DeleteVerbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteVerbStoredProcedure' object.
        /// </summary>
        public DeleteVerbStoredProcedure()
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
                this.ProcedureName = "Verb_Delete";

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
