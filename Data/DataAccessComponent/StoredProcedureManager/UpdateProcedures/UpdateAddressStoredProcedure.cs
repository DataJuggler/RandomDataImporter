

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateAddressStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Address' object.
    /// </summary>
    public class UpdateAddressStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateAddressStoredProcedure' object.
        /// </summary>
        public UpdateAddressStoredProcedure()
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
                this.ProcedureName = "Address_Update";

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
