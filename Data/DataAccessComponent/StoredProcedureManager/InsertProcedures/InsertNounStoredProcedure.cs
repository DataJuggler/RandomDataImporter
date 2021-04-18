

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertNounStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Noun' object.
    /// </summary>
    public class InsertNounStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertNounStoredProcedure' object.
        /// </summary>
        public InsertNounStoredProcedure()
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
                this.ProcedureName = "Noun_Insert";

                // Set tableName
                this.TableName = "Noun";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
