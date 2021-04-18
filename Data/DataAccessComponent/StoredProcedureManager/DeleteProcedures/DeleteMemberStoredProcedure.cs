

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteMemberStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Member' object.
    /// </summary>
    public class DeleteMemberStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteMemberStoredProcedure' object.
        /// </summary>
        public DeleteMemberStoredProcedure()
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
                this.ProcedureName = "Member_Delete";

                // Set tableName
                this.TableName = "Member";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
