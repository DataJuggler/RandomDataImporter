

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteAdjectiveStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Adjective' object.
    /// </summary>
    public class DeleteAdjectiveStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteAdjectiveStoredProcedure' object.
        /// </summary>
        public DeleteAdjectiveStoredProcedure()
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
                this.ProcedureName = "Adjective_Delete";

                // Set tableName
                this.TableName = "Adjective";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
