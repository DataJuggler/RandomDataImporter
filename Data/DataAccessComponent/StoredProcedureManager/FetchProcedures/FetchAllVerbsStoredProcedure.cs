

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllVerbsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Verb' objects.
    /// </summary>
    public class FetchAllVerbsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllVerbsStoredProcedure' object.
        /// </summary>
        public FetchAllVerbsStoredProcedure()
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
                this.ProcedureName = "Verb_FetchAll";

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
