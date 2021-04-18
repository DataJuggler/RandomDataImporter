

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertFirstNameStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'FirstName' object.
    /// </summary>
    public class InsertFirstNameStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertFirstNameStoredProcedure' object.
        /// </summary>
        public InsertFirstNameStoredProcedure()
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
                this.ProcedureName = "FirstName_Insert";

                // Set tableName
                this.TableName = "FirstName";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
