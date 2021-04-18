

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindAddressStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Address' object.
    /// </summary>
    public class FindAddressStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindAddressStoredProcedure' object.
        /// </summary>
        public FindAddressStoredProcedure()
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
                this.ProcedureName = "Address_Find";

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
