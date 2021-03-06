

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateZipCodeStoredProcedure
    /// <summary>
    /// This class is used to Update a 'ZipCode' object.
    /// </summary>
    public class UpdateZipCodeStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateZipCodeStoredProcedure' object.
        /// </summary>
        public UpdateZipCodeStoredProcedure()
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
                this.ProcedureName = "ZipCode_Update";

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
