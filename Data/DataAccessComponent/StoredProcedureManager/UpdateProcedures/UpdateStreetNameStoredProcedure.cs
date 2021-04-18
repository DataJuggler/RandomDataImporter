

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateStreetNameStoredProcedure
    /// <summary>
    /// This class is used to Update a 'StreetName' object.
    /// </summary>
    public class UpdateStreetNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateStreetNameStoredProcedure' object.
        /// </summary>
        public UpdateStreetNameStoredProcedure()
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
                this.ProcedureName = "StreetName_Update";

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
