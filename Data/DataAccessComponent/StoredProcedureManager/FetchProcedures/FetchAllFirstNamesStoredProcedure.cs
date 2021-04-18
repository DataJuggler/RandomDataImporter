

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllFirstNamesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'FirstName' objects.
    /// </summary>
    public class FetchAllFirstNamesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllFirstNamesStoredProcedure' object.
        /// </summary>
        public FetchAllFirstNamesStoredProcedure()
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
                this.ProcedureName = "FirstName_FetchAll";

                // Set tableName
                this.TableName = "FirstName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
