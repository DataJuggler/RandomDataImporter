

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertLastNameStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'LastName' object.
    /// </summary>
    public class InsertLastNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertLastNameStoredProcedure' object.
        /// </summary>
        public InsertLastNameStoredProcedure()
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
                this.ProcedureName = "LastName_Insert";

                // Set tableName
                this.TableName = "LastName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
