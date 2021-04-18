

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllStreetNamesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'StreetName' objects.
    /// </summary>
    public class FetchAllStreetNamesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllStreetNamesStoredProcedure' object.
        /// </summary>
        public FetchAllStreetNamesStoredProcedure()
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
                this.ProcedureName = "StreetName_FetchAll";

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
