

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private AddressMethods addressMethods;
        private AdjectiveMethods adjectiveMethods;
        private AdverbMethods adverbMethods;
        private FirstNameMethods firstnameMethods;
        private LastNameMethods lastnameMethods;
        private MemberMethods memberMethods;
        private MemberAddressViewMethods memberaddressviewMethods;
        private NounMethods nounMethods;
        private StateMethods stateMethods;
        private StreetNameMethods streetnameMethods;
        private VerbMethods verbMethods;
        private ZipCodeMethods zipcodeMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.AddressMethods = new AddressMethods(this.DataManager);
                this.AdjectiveMethods = new AdjectiveMethods(this.DataManager);
                this.AdverbMethods = new AdverbMethods(this.DataManager);
                this.FirstNameMethods = new FirstNameMethods(this.DataManager);
                this.LastNameMethods = new LastNameMethods(this.DataManager);
                this.MemberMethods = new MemberMethods(this.DataManager);
                this.MemberAddressViewMethods = new MemberAddressViewMethods(this.DataManager);
                this.NounMethods = new NounMethods(this.DataManager);
                this.StateMethods = new StateMethods(this.DataManager);
                this.StreetNameMethods = new StreetNameMethods(this.DataManager);
                this.VerbMethods = new VerbMethods(this.DataManager);
                this.ZipCodeMethods = new ZipCodeMethods(this.DataManager);
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager
            public DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region AddressMethods
            public AddressMethods AddressMethods
            {
                get { return addressMethods; }
                set { addressMethods = value; }
            }
            #endregion

            #region AdjectiveMethods
            public AdjectiveMethods AdjectiveMethods
            {
                get { return adjectiveMethods; }
                set { adjectiveMethods = value; }
            }
            #endregion

            #region AdverbMethods
            public AdverbMethods AdverbMethods
            {
                get { return adverbMethods; }
                set { adverbMethods = value; }
            }
            #endregion

            #region FirstNameMethods
            public FirstNameMethods FirstNameMethods
            {
                get { return firstnameMethods; }
                set { firstnameMethods = value; }
            }
            #endregion

            #region LastNameMethods
            public LastNameMethods LastNameMethods
            {
                get { return lastnameMethods; }
                set { lastnameMethods = value; }
            }
            #endregion

            #region MemberMethods
            public MemberMethods MemberMethods
            {
                get { return memberMethods; }
                set { memberMethods = value; }
            }
            #endregion

            #region MemberAddressViewMethods
            public MemberAddressViewMethods MemberAddressViewMethods
            {
                get { return memberaddressviewMethods; }
                set { memberaddressviewMethods = value; }
            }
            #endregion

            #region NounMethods
            public NounMethods NounMethods
            {
                get { return nounMethods; }
                set { nounMethods = value; }
            }
            #endregion

            #region StateMethods
            public StateMethods StateMethods
            {
                get { return stateMethods; }
                set { stateMethods = value; }
            }
            #endregion

            #region StreetNameMethods
            public StreetNameMethods StreetNameMethods
            {
                get { return streetnameMethods; }
                set { streetnameMethods = value; }
            }
            #endregion

            #region VerbMethods
            public VerbMethods VerbMethods
            {
                get { return verbMethods; }
                set { verbMethods = value; }
            }
            #endregion

            #region ZipCodeMethods
            public ZipCodeMethods ZipCodeMethods
            {
                get { return zipcodeMethods; }
                set { zipcodeMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
