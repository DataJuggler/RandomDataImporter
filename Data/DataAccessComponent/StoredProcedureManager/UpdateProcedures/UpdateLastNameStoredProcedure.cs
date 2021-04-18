

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateLastNameStoredProcedure
    /// <summary>
    /// This class is used to Update a 'LastName' object.
    /// </summary>
    public class UpdateLastNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateLastNameStoredProcedure' object.
        /// </summary>
        public UpdateLastNameStoredProcedure()
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
                this.ProcedureName = "LastName_Update";

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
