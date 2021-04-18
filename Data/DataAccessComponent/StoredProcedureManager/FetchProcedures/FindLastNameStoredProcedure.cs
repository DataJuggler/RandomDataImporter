

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindLastNameStoredProcedure
    /// <summary>
    /// This class is used to Find a 'LastName' object.
    /// </summary>
    public class FindLastNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindLastNameStoredProcedure' object.
        /// </summary>
        public FindLastNameStoredProcedure()
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
                this.ProcedureName = "LastName_Find";

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
