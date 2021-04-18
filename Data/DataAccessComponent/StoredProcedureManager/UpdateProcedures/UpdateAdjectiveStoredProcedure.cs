

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateAdjectiveStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Adjective' object.
    /// </summary>
    public class UpdateAdjectiveStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateAdjectiveStoredProcedure' object.
        /// </summary>
        public UpdateAdjectiveStoredProcedure()
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
                this.ProcedureName = "Adjective_Update";

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
