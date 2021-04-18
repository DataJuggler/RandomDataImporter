

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class ControllerManager
    /// <summary>
    /// This class manages the child controllers for this application.
    /// </summary>
    public class ControllerManager
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        private AddressController addressController;
        private AdjectiveController adjectiveController;
        private AdverbController adverbController;
        private FirstNameController firstnameController;
        private LastNameController lastnameController;
        private MemberController memberController;
        private MemberAddressViewController memberaddressviewController;
        private NounController nounController;
        private StateController stateController;
        private StreetNameController streetnameController;
        private VerbController verbController;
        private ZipCodeController zipcodeController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ControllerManager' object.
        /// </summary>
        public ControllerManager(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;

            // Create Child Controllers
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child Controllers
            /// </summary>
            private void Init()
            {
                // Create Child Controllers
                this.AddressController = new AddressController(this.ErrorProcessor, this.AppController);
                this.AdjectiveController = new AdjectiveController(this.ErrorProcessor, this.AppController);
                this.AdverbController = new AdverbController(this.ErrorProcessor, this.AppController);
                this.FirstNameController = new FirstNameController(this.ErrorProcessor, this.AppController);
                this.LastNameController = new LastNameController(this.ErrorProcessor, this.AppController);
                this.MemberController = new MemberController(this.ErrorProcessor, this.AppController);
                this.MemberAddressViewController = new MemberAddressViewController(this.ErrorProcessor, this.AppController);
                this.NounController = new NounController(this.ErrorProcessor, this.AppController);
                this.StateController = new StateController(this.ErrorProcessor, this.AppController);
                this.StreetNameController = new StreetNameController(this.ErrorProcessor, this.AppController);
                this.VerbController = new VerbController(this.ErrorProcessor, this.AppController);
                this.ZipCodeController = new ZipCodeController(this.ErrorProcessor, this.AppController);
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

            #region AddressController
            public AddressController AddressController
            {
                get { return addressController; }
                set { addressController = value; }
            }
            #endregion

            #region AdjectiveController
            public AdjectiveController AdjectiveController
            {
                get { return adjectiveController; }
                set { adjectiveController = value; }
            }
            #endregion

            #region AdverbController
            public AdverbController AdverbController
            {
                get { return adverbController; }
                set { adverbController = value; }
            }
            #endregion

            #region FirstNameController
            public FirstNameController FirstNameController
            {
                get { return firstnameController; }
                set { firstnameController = value; }
            }
            #endregion

            #region LastNameController
            public LastNameController LastNameController
            {
                get { return lastnameController; }
                set { lastnameController = value; }
            }
            #endregion

            #region MemberController
            public MemberController MemberController
            {
                get { return memberController; }
                set { memberController = value; }
            }
            #endregion

            #region MemberAddressViewController
            public MemberAddressViewController MemberAddressViewController
            {
                get { return memberaddressviewController; }
                set { memberaddressviewController = value; }
            }
            #endregion

            #region NounController
            public NounController NounController
            {
                get { return nounController; }
                set { nounController = value; }
            }
            #endregion

            #region StateController
            public StateController StateController
            {
                get { return stateController; }
                set { stateController = value; }
            }
            #endregion

            #region StreetNameController
            public StreetNameController StreetNameController
            {
                get { return streetnameController; }
                set { streetnameController = value; }
            }
            #endregion

            #region VerbController
            public VerbController VerbController
            {
                get { return verbController; }
                set { verbController = value; }
            }
            #endregion

            #region ZipCodeController
            public ZipCodeController ZipCodeController
            {
                get { return zipcodeController; }
                set { zipcodeController = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
