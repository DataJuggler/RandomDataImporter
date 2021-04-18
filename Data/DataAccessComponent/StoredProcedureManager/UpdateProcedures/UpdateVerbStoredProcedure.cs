

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateVerbStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Verb' object.
    /// </summary>
    public class UpdateVerbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateVerbStoredProcedure' object.
        /// </summary>
        public UpdateVerbStoredProcedure()
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
                this.ProcedureName = "Verb_Update";

                // Set tableName
                this.TableName = "Verb";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
