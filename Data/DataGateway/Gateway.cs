
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteAddress(int id, Address tempAddress = null)
            /// <summary>
            /// This method is used to delete Address objects.
            /// </summary>
            /// <param name="id">Delete the Address with this id</param>
            /// <param name="tempAddress">Pass in a tempAddress to perform a custom delete.</param>
            public bool DeleteAddress(int id, Address tempAddress = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAddress does not exist
                    if (tempAddress == null)
                    {
                        // create a temp Address
                        tempAddress = new Address();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAddress.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.AddressController.Delete(tempAddress);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteAdjective(int id, Adjective tempAdjective = null)
            /// <summary>
            /// This method is used to delete Adjective objects.
            /// </summary>
            /// <param name="id">Delete the Adjective with this id</param>
            /// <param name="tempAdjective">Pass in a tempAdjective to perform a custom delete.</param>
            public bool DeleteAdjective(int id, Adjective tempAdjective = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdjective does not exist
                    if (tempAdjective == null)
                    {
                        // create a temp Adjective
                        tempAdjective = new Adjective();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdjective.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.AdjectiveController.Delete(tempAdjective);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteAdverb(int id, Adverb tempAdverb = null)
            /// <summary>
            /// This method is used to delete Adverb objects.
            /// </summary>
            /// <param name="id">Delete the Adverb with this id</param>
            /// <param name="tempAdverb">Pass in a tempAdverb to perform a custom delete.</param>
            public bool DeleteAdverb(int id, Adverb tempAdverb = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdverb does not exist
                    if (tempAdverb == null)
                    {
                        // create a temp Adverb
                        tempAdverb = new Adverb();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdverb.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.AdverbController.Delete(tempAdverb);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteFirstName(int id, FirstName tempFirstName = null)
            /// <summary>
            /// This method is used to delete FirstName objects.
            /// </summary>
            /// <param name="id">Delete the FirstName with this id</param>
            /// <param name="tempFirstName">Pass in a tempFirstName to perform a custom delete.</param>
            public bool DeleteFirstName(int id, FirstName tempFirstName = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFirstName does not exist
                    if (tempFirstName == null)
                    {
                        // create a temp FirstName
                        tempFirstName = new FirstName();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempFirstName.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.FirstNameController.Delete(tempFirstName);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteLastName(int id, LastName tempLastName = null)
            /// <summary>
            /// This method is used to delete LastName objects.
            /// </summary>
            /// <param name="id">Delete the LastName with this id</param>
            /// <param name="tempLastName">Pass in a tempLastName to perform a custom delete.</param>
            public bool DeleteLastName(int id, LastName tempLastName = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempLastName does not exist
                    if (tempLastName == null)
                    {
                        // create a temp LastName
                        tempLastName = new LastName();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempLastName.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.LastNameController.Delete(tempLastName);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteMember(int id, Member tempMember = null)
            /// <summary>
            /// This method is used to delete Member objects.
            /// </summary>
            /// <param name="id">Delete the Member with this id</param>
            /// <param name="tempMember">Pass in a tempMember to perform a custom delete.</param>
            public bool DeleteMember(int id, Member tempMember = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempMember does not exist
                    if (tempMember == null)
                    {
                        // create a temp Member
                        tempMember = new Member();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempMember.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.MemberController.Delete(tempMember);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteNoun(int id, Noun tempNoun = null)
            /// <summary>
            /// This method is used to delete Noun objects.
            /// </summary>
            /// <param name="id">Delete the Noun with this id</param>
            /// <param name="tempNoun">Pass in a tempNoun to perform a custom delete.</param>
            public bool DeleteNoun(int id, Noun tempNoun = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempNoun does not exist
                    if (tempNoun == null)
                    {
                        // create a temp Noun
                        tempNoun = new Noun();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempNoun.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.NounController.Delete(tempNoun);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteState(int id, State tempState = null)
            /// <summary>
            /// This method is used to delete State objects.
            /// </summary>
            /// <param name="id">Delete the State with this id</param>
            /// <param name="tempState">Pass in a tempState to perform a custom delete.</param>
            public bool DeleteState(int id, State tempState = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempState does not exist
                    if (tempState == null)
                    {
                        // create a temp State
                        tempState = new State();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempState.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.StateController.Delete(tempState);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteStreetName(int id, StreetName tempStreetName = null)
            /// <summary>
            /// This method is used to delete StreetName objects.
            /// </summary>
            /// <param name="id">Delete the StreetName with this id</param>
            /// <param name="tempStreetName">Pass in a tempStreetName to perform a custom delete.</param>
            public bool DeleteStreetName(int id, StreetName tempStreetName = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempStreetName does not exist
                    if (tempStreetName == null)
                    {
                        // create a temp StreetName
                        tempStreetName = new StreetName();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempStreetName.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.StreetNameController.Delete(tempStreetName);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteVerb(int id, Verb tempVerb = null)
            /// <summary>
            /// This method is used to delete Verb objects.
            /// </summary>
            /// <param name="id">Delete the Verb with this id</param>
            /// <param name="tempVerb">Pass in a tempVerb to perform a custom delete.</param>
            public bool DeleteVerb(int id, Verb tempVerb = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVerb does not exist
                    if (tempVerb == null)
                    {
                        // create a temp Verb
                        tempVerb = new Verb();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVerb.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.VerbController.Delete(tempVerb);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteZipCode(int id, ZipCode tempZipCode = null)
            /// <summary>
            /// This method is used to delete ZipCode objects.
            /// </summary>
            /// <param name="id">Delete the ZipCode with this id</param>
            /// <param name="tempZipCode">Pass in a tempZipCode to perform a custom delete.</param>
            public bool DeleteZipCode(int id, ZipCode tempZipCode = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempZipCode does not exist
                    if (tempZipCode == null)
                    {
                        // create a temp ZipCode
                        tempZipCode = new ZipCode();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempZipCode.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ZipCodeController.Delete(tempZipCode);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindAddress(int id, Address tempAddress = null)
            /// <summary>
            /// This method is used to find 'Address' objects.
            /// </summary>
            /// <param name="id">Find the Address with this id</param>
            /// <param name="tempAddress">Pass in a tempAddress to perform a custom find.</param>
            public Address FindAddress(int id, Address tempAddress = null)
            {
                // initial value
                Address address = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAddress does not exist
                    if (tempAddress == null)
                    {
                        // create a temp Address
                        tempAddress = new Address();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAddress.UpdateIdentity(id);
                    }

                    // perform the find
                    address = this.AppController.ControllerManager.AddressController.Find(tempAddress);
                }

                // return value
                return address;
            }
            #endregion

            #region FindAdjective(int id, Adjective tempAdjective = null)
            /// <summary>
            /// This method is used to find 'Adjective' objects.
            /// </summary>
            /// <param name="id">Find the Adjective with this id</param>
            /// <param name="tempAdjective">Pass in a tempAdjective to perform a custom find.</param>
            public Adjective FindAdjective(int id, Adjective tempAdjective = null)
            {
                // initial value
                Adjective adjective = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdjective does not exist
                    if (tempAdjective == null)
                    {
                        // create a temp Adjective
                        tempAdjective = new Adjective();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdjective.UpdateIdentity(id);
                    }

                    // perform the find
                    adjective = this.AppController.ControllerManager.AdjectiveController.Find(tempAdjective);
                }

                // return value
                return adjective;
            }
            #endregion

            #region FindAdverb(int id, Adverb tempAdverb = null)
            /// <summary>
            /// This method is used to find 'Adverb' objects.
            /// </summary>
            /// <param name="id">Find the Adverb with this id</param>
            /// <param name="tempAdverb">Pass in a tempAdverb to perform a custom find.</param>
            public Adverb FindAdverb(int id, Adverb tempAdverb = null)
            {
                // initial value
                Adverb adverb = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdverb does not exist
                    if (tempAdverb == null)
                    {
                        // create a temp Adverb
                        tempAdverb = new Adverb();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempAdverb.UpdateIdentity(id);
                    }

                    // perform the find
                    adverb = this.AppController.ControllerManager.AdverbController.Find(tempAdverb);
                }

                // return value
                return adverb;
            }
            #endregion

            #region FindFirstName(int id, FirstName tempFirstName = null)
            /// <summary>
            /// This method is used to find 'FirstName' objects.
            /// </summary>
            /// <param name="id">Find the FirstName with this id</param>
            /// <param name="tempFirstName">Pass in a tempFirstName to perform a custom find.</param>
            public FirstName FindFirstName(int id, FirstName tempFirstName = null)
            {
                // initial value
                FirstName firstName = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFirstName does not exist
                    if (tempFirstName == null)
                    {
                        // create a temp FirstName
                        tempFirstName = new FirstName();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempFirstName.UpdateIdentity(id);
                    }

                    // perform the find
                    firstName = this.AppController.ControllerManager.FirstNameController.Find(tempFirstName);
                }

                // return value
                return firstName;
            }
            #endregion

            #region FindLastName(int id, LastName tempLastName = null)
            /// <summary>
            /// This method is used to find 'LastName' objects.
            /// </summary>
            /// <param name="id">Find the LastName with this id</param>
            /// <param name="tempLastName">Pass in a tempLastName to perform a custom find.</param>
            public LastName FindLastName(int id, LastName tempLastName = null)
            {
                // initial value
                LastName lastName = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempLastName does not exist
                    if (tempLastName == null)
                    {
                        // create a temp LastName
                        tempLastName = new LastName();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempLastName.UpdateIdentity(id);
                    }

                    // perform the find
                    lastName = this.AppController.ControllerManager.LastNameController.Find(tempLastName);
                }

                // return value
                return lastName;
            }
            #endregion

            #region FindMember(int id, Member tempMember = null)
            /// <summary>
            /// This method is used to find 'Member' objects.
            /// </summary>
            /// <param name="id">Find the Member with this id</param>
            /// <param name="tempMember">Pass in a tempMember to perform a custom find.</param>
            public Member FindMember(int id, Member tempMember = null)
            {
                // initial value
                Member member = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempMember does not exist
                    if (tempMember == null)
                    {
                        // create a temp Member
                        tempMember = new Member();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempMember.UpdateIdentity(id);
                    }

                    // perform the find
                    member = this.AppController.ControllerManager.MemberController.Find(tempMember);
                }

                // return value
                return member;
            }
            #endregion

            #region FindNoun(int id, Noun tempNoun = null)
            /// <summary>
            /// This method is used to find 'Noun' objects.
            /// </summary>
            /// <param name="id">Find the Noun with this id</param>
            /// <param name="tempNoun">Pass in a tempNoun to perform a custom find.</param>
            public Noun FindNoun(int id, Noun tempNoun = null)
            {
                // initial value
                Noun noun = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempNoun does not exist
                    if (tempNoun == null)
                    {
                        // create a temp Noun
                        tempNoun = new Noun();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempNoun.UpdateIdentity(id);
                    }

                    // perform the find
                    noun = this.AppController.ControllerManager.NounController.Find(tempNoun);
                }

                // return value
                return noun;
            }
            #endregion

            #region FindState(int id, State tempState = null)
            /// <summary>
            /// This method is used to find 'State' objects.
            /// </summary>
            /// <param name="id">Find the State with this id</param>
            /// <param name="tempState">Pass in a tempState to perform a custom find.</param>
            public State FindState(int id, State tempState = null)
            {
                // initial value
                State state = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempState does not exist
                    if (tempState == null)
                    {
                        // create a temp State
                        tempState = new State();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempState.UpdateIdentity(id);
                    }

                    // perform the find
                    state = this.AppController.ControllerManager.StateController.Find(tempState);
                }

                // return value
                return state;
            }
            #endregion

            #region FindStreetName(int id, StreetName tempStreetName = null)
            /// <summary>
            /// This method is used to find 'StreetName' objects.
            /// </summary>
            /// <param name="id">Find the StreetName with this id</param>
            /// <param name="tempStreetName">Pass in a tempStreetName to perform a custom find.</param>
            public StreetName FindStreetName(int id, StreetName tempStreetName = null)
            {
                // initial value
                StreetName streetName = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempStreetName does not exist
                    if (tempStreetName == null)
                    {
                        // create a temp StreetName
                        tempStreetName = new StreetName();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempStreetName.UpdateIdentity(id);
                    }

                    // perform the find
                    streetName = this.AppController.ControllerManager.StreetNameController.Find(tempStreetName);
                }

                // return value
                return streetName;
            }
            #endregion

            #region FindVerb(int id, Verb tempVerb = null)
            /// <summary>
            /// This method is used to find 'Verb' objects.
            /// </summary>
            /// <param name="id">Find the Verb with this id</param>
            /// <param name="tempVerb">Pass in a tempVerb to perform a custom find.</param>
            public Verb FindVerb(int id, Verb tempVerb = null)
            {
                // initial value
                Verb verb = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempVerb does not exist
                    if (tempVerb == null)
                    {
                        // create a temp Verb
                        tempVerb = new Verb();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempVerb.UpdateIdentity(id);
                    }

                    // perform the find
                    verb = this.AppController.ControllerManager.VerbController.Find(tempVerb);
                }

                // return value
                return verb;
            }
            #endregion

            #region FindZipCode(int id, ZipCode tempZipCode = null)
            /// <summary>
            /// This method is used to find 'ZipCode' objects.
            /// </summary>
            /// <param name="id">Find the ZipCode with this id</param>
            /// <param name="tempZipCode">Pass in a tempZipCode to perform a custom find.</param>
            public ZipCode FindZipCode(int id, ZipCode tempZipCode = null)
            {
                // initial value
                ZipCode zipCode = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempZipCode does not exist
                    if (tempZipCode == null)
                    {
                        // create a temp ZipCode
                        tempZipCode = new ZipCode();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempZipCode.UpdateIdentity(id);
                    }

                    // perform the find
                    zipCode = this.AppController.ControllerManager.ZipCodeController.Find(tempZipCode);
                }

                // return value
                return zipCode;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadAddresses(Address tempAddress = null)
            /// <summary>
            /// This method loads a collection of 'Address' objects.
            /// </summary>
            public List<Address> LoadAddresses(Address tempAddress = null)
            {
                // initial value
                List<Address> addresses = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    addresses = this.AppController.ControllerManager.AddressController.FetchAll(tempAddress);
                }

                // return value
                return addresses;
            }
            #endregion

            #region LoadAdjectives(Adjective tempAdjective = null)
            /// <summary>
            /// This method loads a collection of 'Adjective' objects.
            /// </summary>
            public List<Adjective> LoadAdjectives(Adjective tempAdjective = null)
            {
                // initial value
                List<Adjective> adjectives = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    adjectives = this.AppController.ControllerManager.AdjectiveController.FetchAll(tempAdjective);
                }

                // return value
                return adjectives;
            }
            #endregion

            #region LoadAdverbs(Adverb tempAdverb = null)
            /// <summary>
            /// This method loads a collection of 'Adverb' objects.
            /// </summary>
            public List<Adverb> LoadAdverbs(Adverb tempAdverb = null)
            {
                // initial value
                List<Adverb> adverbs = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    adverbs = this.AppController.ControllerManager.AdverbController.FetchAll(tempAdverb);
                }

                // return value
                return adverbs;
            }
            #endregion

            #region LoadFirstNames(FirstName tempFirstName = null)
            /// <summary>
            /// This method loads a collection of 'FirstName' objects.
            /// </summary>
            public List<FirstName> LoadFirstNames(FirstName tempFirstName = null)
            {
                // initial value
                List<FirstName> firstNames = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    firstNames = this.AppController.ControllerManager.FirstNameController.FetchAll(tempFirstName);
                }

                // return value
                return firstNames;
            }
            #endregion

            #region LoadLastNames(LastName tempLastName = null)
            /// <summary>
            /// This method loads a collection of 'LastName' objects.
            /// </summary>
            public List<LastName> LoadLastNames(LastName tempLastName = null)
            {
                // initial value
                List<LastName> lastNames = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    lastNames = this.AppController.ControllerManager.LastNameController.FetchAll(tempLastName);
                }

                // return value
                return lastNames;
            }
            #endregion

            #region LoadMemberAddressViews(MemberAddressView tempMemberAddressView = null)
            /// <summary>
            /// This method loads a collection of 'MemberAddressView' objects.
            /// </summary>
            public List<MemberAddressView> LoadMemberAddressViews(MemberAddressView tempMemberAddressView = null)
            {
                // initial value
                List<MemberAddressView> memberAddressViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    memberAddressViews = this.AppController.ControllerManager.MemberAddressViewController.FetchAll(tempMemberAddressView);
                }

                // return value
                return memberAddressViews;
            }
            #endregion

            #region LoadMembers(Member tempMember = null)
            /// <summary>
            /// This method loads a collection of 'Member' objects.
            /// </summary>
            public List<Member> LoadMembers(Member tempMember = null)
            {
                // initial value
                List<Member> members = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    members = this.AppController.ControllerManager.MemberController.FetchAll(tempMember);
                }

                // return value
                return members;
            }
            #endregion

            #region LoadNouns(Noun tempNoun = null)
            /// <summary>
            /// This method loads a collection of 'Noun' objects.
            /// </summary>
            public List<Noun> LoadNouns(Noun tempNoun = null)
            {
                // initial value
                List<Noun> nouns = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    nouns = this.AppController.ControllerManager.NounController.FetchAll(tempNoun);
                }

                // return value
                return nouns;
            }
            #endregion

            #region LoadStates(State tempState = null)
            /// <summary>
            /// This method loads a collection of 'State' objects.
            /// </summary>
            public List<State> LoadStates(State tempState = null)
            {
                // initial value
                List<State> states = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    states = this.AppController.ControllerManager.StateController.FetchAll(tempState);
                }

                // return value
                return states;
            }
            #endregion

            #region LoadStreetNames(StreetName tempStreetName = null)
            /// <summary>
            /// This method loads a collection of 'StreetName' objects.
            /// </summary>
            public List<StreetName> LoadStreetNames(StreetName tempStreetName = null)
            {
                // initial value
                List<StreetName> streetNames = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    streetNames = this.AppController.ControllerManager.StreetNameController.FetchAll(tempStreetName);
                }

                // return value
                return streetNames;
            }
            #endregion

            #region LoadVerbs(Verb tempVerb = null)
            /// <summary>
            /// This method loads a collection of 'Verb' objects.
            /// </summary>
            public List<Verb> LoadVerbs(Verb tempVerb = null)
            {
                // initial value
                List<Verb> verbs = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    verbs = this.AppController.ControllerManager.VerbController.FetchAll(tempVerb);
                }

                // return value
                return verbs;
            }
            #endregion

            #region LoadZipCodes(ZipCode tempZipCode = null)
            /// <summary>
            /// This method loads a collection of 'ZipCode' objects.
            /// </summary>
            public List<ZipCode> LoadZipCodes(ZipCode tempZipCode = null)
            {
                // initial value
                List<ZipCode> zipCodes = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    zipCodes = this.AppController.ControllerManager.ZipCodeController.FetchAll(tempZipCode);
                }

                // return value
                return zipCodes;
            }
            #endregion

            #region SaveAddress(ref Address address)
            /// <summary>
            /// This method is used to save 'Address' objects.
            /// </summary>
            /// <param name="address">The Address to save.</param>
            public bool SaveAddress(ref Address address)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.AddressController.Save(ref address);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveAdjective(ref Adjective adjective)
            /// <summary>
            /// This method is used to save 'Adjective' objects.
            /// </summary>
            /// <param name="adjective">The Adjective to save.</param>
            public bool SaveAdjective(ref Adjective adjective)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.AdjectiveController.Save(ref adjective);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveAdverb(ref Adverb adverb)
            /// <summary>
            /// This method is used to save 'Adverb' objects.
            /// </summary>
            /// <param name="adverb">The Adverb to save.</param>
            public bool SaveAdverb(ref Adverb adverb)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.AdverbController.Save(ref adverb);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveFirstName(ref FirstName firstName)
            /// <summary>
            /// This method is used to save 'FirstName' objects.
            /// </summary>
            /// <param name="firstName">The FirstName to save.</param>
            public bool SaveFirstName(ref FirstName firstName)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.FirstNameController.Save(ref firstName);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveLastName(ref LastName lastName)
            /// <summary>
            /// This method is used to save 'LastName' objects.
            /// </summary>
            /// <param name="lastName">The LastName to save.</param>
            public bool SaveLastName(ref LastName lastName)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.LastNameController.Save(ref lastName);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveMember(ref Member member)
            /// <summary>
            /// This method is used to save 'Member' objects.
            /// </summary>
            /// <param name="member">The Member to save.</param>
            public bool SaveMember(ref Member member)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.MemberController.Save(ref member);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveNoun(ref Noun noun)
            /// <summary>
            /// This method is used to save 'Noun' objects.
            /// </summary>
            /// <param name="noun">The Noun to save.</param>
            public bool SaveNoun(ref Noun noun)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.NounController.Save(ref noun);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveState(ref State state)
            /// <summary>
            /// This method is used to save 'State' objects.
            /// </summary>
            /// <param name="state">The State to save.</param>
            public bool SaveState(ref State state)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.StateController.Save(ref state);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveStreetName(ref StreetName streetName)
            /// <summary>
            /// This method is used to save 'StreetName' objects.
            /// </summary>
            /// <param name="streetName">The StreetName to save.</param>
            public bool SaveStreetName(ref StreetName streetName)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.StreetNameController.Save(ref streetName);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveVerb(ref Verb verb)
            /// <summary>
            /// This method is used to save 'Verb' objects.
            /// </summary>
            /// <param name="verb">The Verb to save.</param>
            public bool SaveVerb(ref Verb verb)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.VerbController.Save(ref verb);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveZipCode(ref ZipCode zipCode)
            /// <summary>
            /// This method is used to save 'ZipCode' objects.
            /// </summary>
            /// <param name="zipCode">The ZipCode to save.</param>
            public bool SaveZipCode(ref ZipCode zipCode)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ZipCodeController.Save(ref zipCode);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

