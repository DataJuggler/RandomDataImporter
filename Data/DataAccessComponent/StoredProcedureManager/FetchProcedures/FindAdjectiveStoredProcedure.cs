

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindAdjectiveStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Adjective' object.
    /// </summary>
    public class FindAdjectiveStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindAdjectiveStoredProcedure' object.
        /// </summary>
        public FindAdjectiveStoredProcedure()
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
                this.ProcedureName = "Adjective_Find";

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
