

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteAddressStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Address' object.
    /// </summary>
    public class DeleteAddressStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteAddressStoredProcedure' object.
        /// </summary>
        public DeleteAddressStoredProcedure()
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
                this.ProcedureName = "Address_Delete";

                // Set tableName
                this.TableName = "Address";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
