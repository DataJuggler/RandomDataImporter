

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateNounStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Noun' object.
    /// </summary>
    public class UpdateNounStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateNounStoredProcedure' object.
        /// </summary>
        public UpdateNounStoredProcedure()
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
                this.ProcedureName = "Noun_Update";

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
