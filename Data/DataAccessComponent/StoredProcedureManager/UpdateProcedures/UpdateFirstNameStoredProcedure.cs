

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateFirstNameStoredProcedure
    /// <summary>
    /// This class is used to Update a 'FirstName' object.
    /// </summary>
    public class UpdateFirstNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateFirstNameStoredProcedure' object.
        /// </summary>
        public UpdateFirstNameStoredProcedure()
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
                this.ProcedureName = "FirstName_Update";

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
