

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertStateStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'State' object.
    /// </summary>
    public class InsertStateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertStateStoredProcedure' object.
        /// </summary>
        public InsertStateStoredProcedure()
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
                this.ProcedureName = "State_Insert";

                // Set tableName
                this.TableName = "State";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
