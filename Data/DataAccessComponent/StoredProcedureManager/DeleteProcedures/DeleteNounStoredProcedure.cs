

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteNounStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Noun' object.
    /// </summary>
    public class DeleteNounStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteNounStoredProcedure' object.
        /// </summary>
        public DeleteNounStoredProcedure()
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
                this.ProcedureName = "Noun_Delete";

                // Set tableName
                this.TableName = "Noun";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
