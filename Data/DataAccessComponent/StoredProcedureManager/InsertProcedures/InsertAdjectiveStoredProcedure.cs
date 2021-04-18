

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertAdjectiveStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Adjective' object.
    /// </summary>
    public class InsertAdjectiveStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertAdjectiveStoredProcedure' object.
        /// </summary>
        public InsertAdjectiveStoredProcedure()
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
                this.ProcedureName = "Adjective_Insert";

                // Set tableName
                this.TableName = "Adjective";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
