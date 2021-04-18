

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindMemberStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Member' object.
    /// </summary>
    public class FindMemberStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindMemberStoredProcedure' object.
        /// </summary>
        public FindMemberStoredProcedure()
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
                this.ProcedureName = "Member_Find";

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
