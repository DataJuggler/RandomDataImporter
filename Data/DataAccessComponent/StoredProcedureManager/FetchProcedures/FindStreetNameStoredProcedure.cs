

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindStreetNameStoredProcedure
    /// <summary>
    /// This class is used to Find a 'StreetName' object.
    /// </summary>
    public class FindStreetNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindStreetNameStoredProcedure' object.
        /// </summary>
        public FindStreetNameStoredProcedure()
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
                this.ProcedureName = "StreetName_Find";

                // Set tableName
                this.TableName = "StreetName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
