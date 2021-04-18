

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllMembersStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Member' objects.
    /// </summary>
    public class FetchAllMembersStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllMembersStoredProcedure' object.
        /// </summary>
        public FetchAllMembersStoredProcedure()
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
                this.ProcedureName = "Member_FetchAll";

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
