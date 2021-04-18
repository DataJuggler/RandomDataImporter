

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteAdverbStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Adverb' object.
    /// </summary>
    public class DeleteAdverbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteAdverbStoredProcedure' object.
        /// </summary>
        public DeleteAdverbStoredProcedure()
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
                this.ProcedureName = "Adverb_Delete";

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
