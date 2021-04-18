

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertVerbStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Verb' object.
    /// </summary>
    public class InsertVerbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertVerbStoredProcedure' object.
        /// </summary>
        public InsertVerbStoredProcedure()
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
                this.ProcedureName = "Verb_Insert";

                // Set tableName
                this.TableName = "Verb";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
