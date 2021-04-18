

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteZipCodeStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'ZipCode' object.
    /// </summary>
    public class DeleteZipCodeStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteZipCodeStoredProcedure' object.
        /// </summary>
        public DeleteZipCodeStoredProcedure()
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
                this.ProcedureName = "ZipCode_Delete";

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
