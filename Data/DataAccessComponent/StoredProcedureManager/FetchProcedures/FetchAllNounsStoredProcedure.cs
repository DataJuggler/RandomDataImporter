

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllNounsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Noun' objects.
    /// </summary>
    public class FetchAllNounsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllNounsStoredProcedure' object.
        /// </summary>
        public FetchAllNounsStoredProcedure()
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
                this.ProcedureName = "Noun_FetchAll";

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
