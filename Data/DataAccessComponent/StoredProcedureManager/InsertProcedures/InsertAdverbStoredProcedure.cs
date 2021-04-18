

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertAdverbStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Adverb' object.
    /// </summary>
    public class InsertAdverbStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertAdverbStoredProcedure' object.
        /// </summary>
        public InsertAdverbStoredProcedure()
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
                this.ProcedureName = "Adverb_Insert";

                // Set tableName
                this.TableName = "Adverb";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
