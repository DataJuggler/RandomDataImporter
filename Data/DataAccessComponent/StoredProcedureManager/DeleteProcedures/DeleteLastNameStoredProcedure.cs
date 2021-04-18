

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteLastNameStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'LastName' object.
    /// </summary>
    public class DeleteLastNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteLastNameStoredProcedure' object.
        /// </summary>
        public DeleteLastNameStoredProcedure()
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
                this.ProcedureName = "LastName_Delete";

                // Set tableName
                this.TableName = "LastName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
