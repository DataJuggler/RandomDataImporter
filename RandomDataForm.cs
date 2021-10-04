

#region using statements

using DataGateway;
using DataJuggler.RandomShuffler;
using DataJuggler.UltimateHelper;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace RandomDataImporter
{

    #region class RandomDataForm
    /// <summary>
    /// This form is used to generate random data.
    /// </summary>
    public partial class RandomDataForm : Form
    {
        
        #region Private Variables
        private List<FirstName> firstNames;
        private List<LastName> lastNames;
        private List<Verb> verbs;
        private List<Adjective> adjectives;
        private List<Noun> nouns;
        private RandomShuffler shuffler;
        private RandomShuffler shuffler2;
        private RandomShuffler shuffler3;
        private RandomShuffler shuffler4;
        private RandomShuffler shuffler5;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'RandomDataForm' object.
        /// </summary>
        public RandomDataForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region GetDataButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GetDataButton' is clicked.
            /// </summary>
            private void GetDataButton_Click(object sender, EventArgs e)
            {
                // Erase
                this.ResultsTextBox.Text = "Generating random data, please wait...";

                // Refresh everything
                this.Refresh();
                Application.DoEvents();

                // Create a new Gateway instance
                Gateway gateway = new Gateway(MainForm.ConnectionName);
                
                // if the FirstNames do not exist
                if (!this.HasFirstNames)
                {
                    // Load the FirstNames
                    this.FirstNames = gateway.LoadFirstNames();
                }

                // if the LastNames do not exist
                if (!this.HasLastNames)
                {
                    // Load the LastNames
                    this.LastNames = gateway.LoadLastNames();
                }

                // if the Verbs do not exist                
                if (!this.HasVerbs)
                {
                    // Load the Verbs
                    this.Verbs = gateway.LoadVerbs();
                }

                // if the Adjectives do not exist                
                if (!this.HasAdjectives)
                {
                    // Load the Adjectives
                    this.Adjectives = gateway.LoadAdjectives();
                }

                // if the Nouns do not exist                
                if (!this.HasNouns)
                {
                    // Load the Nouns
                    this.Nouns = gateway.LoadNouns();
                }

                // if all the lists exist
                if ((ListHelper.HasOneOrMoreItems(FirstNames, LastNames, Adjectives)) && (ListHelper.HasOneOrMoreItems(Verbs, Nouns)))
                {
                    // Create the shufflers if they don't exist
                    if (!HasShuffler)
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        Shuffler = new RandomShuffler(0, firstNames.Count, 5);
                    }

                    // if the Shffler2 doesn't exist
                    if (!HasShuffler2)
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        Shuffler2 = new RandomShuffler(0, lastNames.Count, 5);
                    }

                    // if the Shffler3 doesn't exist
                    if (!HasShuffler3)
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        Shuffler3 = new RandomShuffler(0, Verbs.Count, 5);
                    }

                    // if the Shffler4 doesn't exist
                    if (!HasShuffler4)
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        Shuffler4 = new RandomShuffler(0, Adjectives.Count, 5);
                    }

                    // if the Shffler5 doesn't exist
                    if (!HasShuffler5)
                    {
                        // Create a new instance of a 'RandomShuffler' object.
                        Shuffler5 = new RandomShuffler(0, Nouns.Count, 5);
                    }
                    
                    // Display the character name
                    this.ResultsTextBox.Text = "Random Characters/Plot: " + Environment.NewLine;
                    
                    // iterate up to 10 names
                    for (int x = 0; x < 10; x++)
                    {
                        // Pull the next items
                        int firstNameIndex = shuffler.PullNextItem();
                        int lastNameIndex = shuffler2.PullNextItem();
                        int verbIndex = shuffler3.PullNextItem();
                        int adjectiveIndex = shuffler4.PullNextItem();
                        int nounIndex = shuffler5.PullNextItem();
                        
                        // Set the first and last name
                        string firstName = firstNames[firstNameIndex].Name;
                        string lastName = lastNames[lastNameIndex].Name;
                        string verb = Verbs[verbIndex].WordText;
                        string adjective = Adjectives[adjectiveIndex].WordText;
                        string noun = Nouns[nounIndex].WordText;
                        
                        // Add to the text
                        this.ResultsTextBox.Text += firstName + " " + lastName + " " + verb + " " + adjective + " " + noun;

                        // if not the last item
                        if (x < 9)
                        {
                            // Display the character name
                            this.ResultsTextBox.Text += Environment.NewLine;
                        }                        
                    }
                }
            }
            #endregion

            #region UpdateEmailButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'UpdateEmailButton' is clicked.
            /// </summary>
            private void UpdateEmailButton_Click(object sender, EventArgs e)
            {
                Gateway gateway = new Gateway("RandomData");

                // load all the members
                List<Member> members = gateway.LoadMembers();

                // If the members collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(members))
                {
                    Graph.Visible = true;
                    Graph.Maximum = members.Count;

                    // local
                    Member tempMember = null;
                    bool saved = false;

                    // save each member
                    foreach (Member member in members)
                    {
                        // Clone this member
                        tempMember = member.Clone();

                        // Set the email to a gmail
                        tempMember.EmailAddress = member.FirstName.ToLower() + "." + member.LastName.ToLower() + "@gmail.com";

                        // Save this member
                        saved = gateway.SaveMember(ref tempMember);

                        // if the value for saved is true
                        if (saved)
                        {
                            // Update the graph
                            Graph.Value++;
                        }
                    }
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region Adjectives
            /// <summary>
            /// This property gets or sets the value for 'Adjectives'.
            /// </summary>
            public List<Adjective> Adjectives
            {
                get { return adjectives; }
                set { adjectives = value; }
            }
            #endregion
            
            #region FirstNames
            /// <summary>
            /// This property gets or sets the value for 'FirstNames'.
            /// </summary>
            public List<FirstName> FirstNames
            {
                get { return firstNames; }
                set { firstNames = value; }
            }
            #endregion
            
            #region HasAdjectives
            /// <summary>
            /// This property returns true if this object has an 'Adjectives'.
            /// </summary>
            public bool HasAdjectives
            {
                get
                {
                    // initial value
                    bool hasAdjectives = (this.Adjectives != null);
                    
                    // return value
                    return hasAdjectives;
                }
            }
            #endregion
            
            #region HasFirstNames
            /// <summary>
            /// This property returns true if this object has a 'FirstNames'.
            /// </summary>
            public bool HasFirstNames
            {
                get
                {
                    // initial value
                    bool hasFirstNames = (this.FirstNames != null);
                    
                    // return value
                    return hasFirstNames;
                }
            }
            #endregion
            
            #region HasLastNames
            /// <summary>
            /// This property returns true if this object has a 'LastNames'.
            /// </summary>
            public bool HasLastNames
            {
                get
                {
                    // initial value
                    bool hasLastNames = (this.LastNames != null);
                    
                    // return value
                    return hasLastNames;
                }
            }
            #endregion
            
            #region HasNouns
            /// <summary>
            /// This property returns true if this object has a 'Nouns'.
            /// </summary>
            public bool HasNouns
            {
                get
                {
                    // initial value
                    bool hasNouns = (this.Nouns != null);
                    
                    // return value
                    return hasNouns;
                }
            }
            #endregion
            
            #region HasShuffler
            /// <summary>
            /// This property returns true if this object has a 'Shuffler'.
            /// </summary>
            public bool HasShuffler
            {
                get
                {
                    // initial value
                    bool hasShuffler = (this.Shuffler != null);
                    
                    // return value
                    return hasShuffler;
                }
            }
            #endregion
            
            #region HasShuffler2
            /// <summary>
            /// This property returns true if this object has a 'Shuffler2'.
            /// </summary>
            public bool HasShuffler2
            {
                get
                {
                    // initial value
                    bool hasShuffler2 = (this.Shuffler2 != null);
                    
                    // return value
                    return hasShuffler2;
                }
            }
            #endregion
            
            #region HasShuffler3
            /// <summary>
            /// This property returns true if this object has a 'Shuffler3'.
            /// </summary>
            public bool HasShuffler3
            {
                get
                {
                    // initial value
                    bool hasShuffler3 = (this.Shuffler3 != null);
                    
                    // return value
                    return hasShuffler3;
                }
            }
            #endregion
            
            #region HasShuffler4
            /// <summary>
            /// This property returns true if this object has a 'Shuffler4'.
            /// </summary>
            public bool HasShuffler4
            {
                get
                {
                    // initial value
                    bool hasShuffler4 = (this.Shuffler4 != null);
                    
                    // return value
                    return hasShuffler4;
                }
            }
            #endregion
            
            #region HasShuffler5
            /// <summary>
            /// This property returns true if this object has a 'Shuffler5'.
            /// </summary>
            public bool HasShuffler5
            {
                get
                {
                    // initial value
                    bool hasShuffler5 = (this.Shuffler5 != null);
                    
                    // return value
                    return hasShuffler5;
                }
            }
            #endregion
            
            #region HasVerbs
            /// <summary>
            /// This property returns true if this object has a 'Verbs'.
            /// </summary>
            public bool HasVerbs
            {
                get
                {
                    // initial value
                    bool hasVerbs = (this.Verbs != null);
                    
                    // return value
                    return hasVerbs;
                }
            }
            #endregion
            
            #region LastNames
            /// <summary>
            /// This property gets or sets the value for 'LastNames'.
            /// </summary>
            public List<LastName> LastNames
            {
                get { return lastNames; }
                set { lastNames = value; }
            }
            #endregion
            
            #region Nouns
            /// <summary>
            /// This property gets or sets the value for 'Nouns'.
            /// </summary>
            public List<Noun> Nouns
            {
                get { return nouns; }
                set { nouns = value; }
            }
            #endregion
            
            #region Shuffler
            /// <summary>
            /// This property gets or sets the value for 'Shuffler'.
            /// </summary>
            public RandomShuffler Shuffler
            {
                get { return shuffler; }
                set { shuffler = value; }
            }
            #endregion
            
            #region Shuffler2
            /// <summary>
            /// This property gets or sets the value for 'Shuffler2'.
            /// </summary>
            public RandomShuffler Shuffler2
            {
                get { return shuffler2; }
                set { shuffler2 = value; }
            }
            #endregion
            
            #region Shuffler3
            /// <summary>
            /// This property gets or sets the value for 'Shuffler3'.
            /// </summary>
            public RandomShuffler Shuffler3
            {
                get { return shuffler3; }
                set { shuffler3 = value; }
            }
            #endregion
            
            #region Shuffler4
            /// <summary>
            /// This property gets or sets the value for 'Shuffler4'.
            /// </summary>
            public RandomShuffler Shuffler4
            {
                get { return shuffler4; }
                set { shuffler4 = value; }
            }
            #endregion
            
            #region Shuffler5
            /// <summary>
            /// This property gets or sets the value for 'Shuffler5'.
            /// </summary>
            public RandomShuffler Shuffler5
            {
                get { return shuffler5; }
                set { shuffler5 = value; }
            }
            #endregion
            
            #region Verbs
            /// <summary>
            /// This property gets or sets the value for 'Verbs'.
            /// </summary>
            public List<Verb> Verbs
            {
                get { return verbs; }
                set { verbs = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
