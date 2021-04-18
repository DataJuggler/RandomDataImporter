

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateAdverbStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Adverb' object.
    /// </summary>
    public class UpdateAdverbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateAdverbStoredProcedure' object.
        /// </summary>
        public UpdateAdverbStoredProcedure()
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
                this.ProcedureName = "Adverb_Update";

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
