

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertAddressStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Address' object.
    /// </summary>
    public class InsertAddressStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertAddressStoredProcedure' object.
        /// </summary>
        public InsertAddressStoredProcedure()
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
                this.ProcedureName = "Address_Insert";

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
