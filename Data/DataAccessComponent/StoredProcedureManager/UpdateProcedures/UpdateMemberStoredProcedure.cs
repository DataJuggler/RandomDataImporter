

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateMemberStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Member' object.
    /// </summary>
    public class UpdateMemberStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateMemberStoredProcedure' object.
        /// </summary>
        public UpdateMemberStoredProcedure()
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
                this.ProcedureName = "Member_Update";

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
