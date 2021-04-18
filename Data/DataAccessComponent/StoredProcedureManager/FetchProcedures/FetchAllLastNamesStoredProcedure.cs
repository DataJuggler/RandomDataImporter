

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllLastNamesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'LastName' objects.
    /// </summary>
    public class FetchAllLastNamesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllLastNamesStoredProcedure' object.
        /// </summary>
        public FetchAllLastNamesStoredProcedure()
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
                this.ProcedureName = "LastName_FetchAll";

                // Set tableName
                this.TableName = "LastName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
