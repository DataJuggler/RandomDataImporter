

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertMemberStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Member' object.
    /// </summary>
    public class InsertMemberStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertMemberStoredProcedure' object.
        /// </summary>
        public InsertMemberStoredProcedure()
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
                this.ProcedureName = "Member_Insert";

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
