

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertZipCodeStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'ZipCode' object.
    /// </summary>
    public class InsertZipCodeStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertZipCodeStoredProcedure' object.
        /// </summary>
        public InsertZipCodeStoredProcedure()
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
                this.ProcedureName = "ZipCode_Insert";

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
