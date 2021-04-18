

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllAddressesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Address' objects.
    /// </summary>
    public class FetchAllAddressesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllAddressesStoredProcedure' object.
        /// </summary>
        public FetchAllAddressesStoredProcedure()
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
                this.ProcedureName = "Address_FetchAll";

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
