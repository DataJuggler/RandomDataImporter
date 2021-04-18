

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindNounStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Noun' object.
    /// </summary>
    public class FindNounStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindNounStoredProcedure' object.
        /// </summary>
        public FindNounStoredProcedure()
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
                this.ProcedureName = "Noun_Find";

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
