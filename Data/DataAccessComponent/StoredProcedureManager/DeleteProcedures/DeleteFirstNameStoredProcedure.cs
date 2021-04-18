

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteFirstNameStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'FirstName' object.
    /// </summary>
    public class DeleteFirstNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteFirstNameStoredProcedure' object.
        /// </summary>
        public DeleteFirstNameStoredProcedure()
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
                this.ProcedureName = "FirstName_Delete";

                // Set tableName
                this.TableName = "FirstName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
