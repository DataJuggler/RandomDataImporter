

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertStreetNameStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'StreetName' object.
    /// </summary>
    public class InsertStreetNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertStreetNameStoredProcedure' object.
        /// </summary>
        public InsertStreetNameStoredProcedure()
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
                this.ProcedureName = "StreetName_Insert";

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
