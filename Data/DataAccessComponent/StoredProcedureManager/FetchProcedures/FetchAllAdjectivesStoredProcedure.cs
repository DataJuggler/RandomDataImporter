

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllAdjectivesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Adjective' objects.
    /// </summary>
    public class FetchAllAdjectivesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllAdjectivesStoredProcedure' object.
        /// </summary>
        public FetchAllAdjectivesStoredProcedure()
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
                this.ProcedureName = "Adjective_FetchAll";

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
