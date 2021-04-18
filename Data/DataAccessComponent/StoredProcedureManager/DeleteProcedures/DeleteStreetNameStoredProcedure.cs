

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteStreetNameStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'StreetName' object.
    /// </summary>
    public class DeleteStreetNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteStreetNameStoredProcedure' object.
        /// </summary>
        public DeleteStreetNameStoredProcedure()
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
                this.ProcedureName = "StreetName_Delete";

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
