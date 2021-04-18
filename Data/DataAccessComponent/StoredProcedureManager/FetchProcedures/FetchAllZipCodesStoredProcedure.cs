

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllZipCodesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'ZipCode' objects.
    /// </summary>
    public class FetchAllZipCodesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllZipCodesStoredProcedure' object.
        /// </summary>
        public FetchAllZipCodesStoredProcedure()
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
                this.ProcedureName = "ZipCode_FetchAll";

                // Set tableName
                this.TableName = "ZipCode";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
