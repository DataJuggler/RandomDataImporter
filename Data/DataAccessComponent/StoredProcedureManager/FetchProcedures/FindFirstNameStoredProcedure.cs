

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindFirstNameStoredProcedure
    /// <summary>
    /// This class is used to Find a 'FirstName' object.
    /// </summary>
    public class FindFirstNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindFirstNameStoredProcedure' object.
        /// </summary>
        public FindFirstNameStoredProcedure()
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
                this.ProcedureName = "FirstName_Find";

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
