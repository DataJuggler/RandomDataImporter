

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;
using ObjectLibrary.BusinessObjects;
using DataGateway;
using ApplicationLogicComponent;

#endregion

namespace RandomDataImporter
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this application.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private const string AdjectiveFilePath1 = @"..\..\..\Input\adjectives\1syllableadjectives.txt";
        private const string AdjectiveFilePath2 = @"..\..\..\Input\adjectives\2syllableadjectives.txt";
        private const string AdjectiveFilePath3 = @"..\..\..\Input\adjectives\3syllableadjectives.txt";
        private const string AdjectiveFilePath4 = @"..\..\..\Input\adjectives\4syllableadjectives.txt";
        private const string AdverbFilePath1 = @"..\..\..\Input\adverbs\1syllableadverbs.txt";
        private const string AdverbFilePath2 = @"..\..\..\Input\adverbs\2syllableadverbs.txt";
        private const string AdverbFilePath3 = @"..\..\..\Input\adverbs\3syllableadverbs.txt";
        private const string AdverbFilePath4 = @"..\..\..\Input\adverbs\4syllableadverbs.txt";
        private const string NounFilePath1 = @"..\..\..\Input\nouns\1syllablenouns.txt";
        private const string NounFilePath2 = @"..\..\..\Input\nouns\2syllablenouns.txt";
        private const string NounFilePath3 = @"..\..\..\Input\nouns\3syllablenouns.txt";
        private const string NounFilePath4 = @"..\..\..\Input\nouns\4syllablenouns.txt";
        private const string VerbFilePath1 = @"..\..\..\Input\verbs\1syllableverbs.txt";
        private const string VerbFilePath2 = @"..\..\..\Input\verbs\2syllableverbs.txt";
        private const string VerbFilePath3 = @"..\..\..\Input\verbs\3syllableverbs.txt";
        private const string VerbFilePath4 = @"..\..\..\Input\verbs\4syllableverbs.txt";
        public const string ConnectionName = "RandomData";
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
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
            
            #region ImportAdjectivesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportAdjectivesButton' is clicked.
            /// </summary>
            private void ImportAdjectivesButton_Click(object sender, EventArgs e)
            {
                // Import the Adjectives
                ImportAdjectives();  
            }
            #endregion
            
            #region ImportAdverbsButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportAdverbsButton' is clicked.
            /// </summary>
            private void ImportAdverbsButton_Click(object sender, EventArgs e)
            {
                // Import the adverbs
                ImportAdverbs();
            }
            #endregion
            
            #region ImportNounsButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportNounsButton' is clicked.
            /// </summary>
            private void ImportNounsButton_Click(object sender, EventArgs e)
            {
                // Import the nouns
                ImportNouns();
            }
            #endregion
            
            #region ImportVerbsButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportVerbsButton' is clicked.
            /// </summary>
            private void ImportVerbsButton_Click(object sender, EventArgs e)
            {   
                // Import the verbs
                ImportVerbs();    
            }
            #endregion

        #endregion

        #region Methods

            #region ImportAdjectives()
            /// <summary>
            /// This method Imports Adjectives
            /// </summary>
            public void ImportAdjectives()
            {
                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(ConnectionName);

                // starting with one syllable adjectives
                int syllables = 1;

                // Read the entire file
                string fileText = File.ReadAllText(AdjectiveFilePath1);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdjectiveGraph.Maximum = textLines.Count;
                        AdjectiveGraph.Minimum = 0;
                        AdjectiveGraph.Value = 0;
                        AdjectiveStatusLabel.Text = "Begin importing adjectives: One Syllable";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // fixing issue of last word being blank
                            if (TextHelper.Exists(line.Text))
                            {
                                // Create a new instance of an 'Adjective' object.
                                Adjective adjective = new Adjective();

                                // Set the text
                                adjective.WordText = line.Text;

                                // Set the syllables
                                adjective.Syllables = syllables;

                                // perform the save
                                bool saved = gateway.SaveAdjective(ref adjective);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // Increment the value for AdjectiveGraph
                                    AdjectiveGraph.Value++;
                                }
                            }
                        }
                    }

                    // Show a finished message for a second
                    AdjectiveStatusLabel.Text = "Finished importing adjectives: One Syllable.";
                }

                // Two syllable adjectives
                syllables = 2;

                // Read the entire file
                fileText = File.ReadAllText(AdjectiveFilePath2);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdjectiveGraph.Maximum = textLines.Count;
                        AdjectiveGraph.Minimum = 0;
                        AdjectiveGraph.Value = 0;
                        AdjectiveStatusLabel.Text = "Begin importing adjectives: Two Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adjective' object.
                            Adjective adjective = new Adjective();

                            // Set the text
                            adjective.WordText = line.Text;

                            // Set the syllables
                            adjective.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdjective(ref adjective);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdjectiveGraph
                                AdjectiveGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdjectiveStatusLabel.Text = "Finished importing adjectives: Two Syllables.";

                // Three syllable adjectives
                syllables = 3;

                // Read the entire file
                fileText = File.ReadAllText(AdjectiveFilePath3);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdjectiveGraph.Maximum = textLines.Count;
                        AdjectiveGraph.Minimum = 0;
                        AdjectiveGraph.Value = 0;
                        AdjectiveStatusLabel.Text = "Begin importing adjectives: Three Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adjective' object.
                            Adjective adjective = new Adjective();

                            // Set the text
                            adjective.WordText = line.Text;

                            // Set the syllables
                            adjective.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdjective(ref adjective);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdjectiveGraph
                                AdjectiveGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdjectiveStatusLabel.Text = "Finished importing adjectives: Three Syllables.";

                // Four syllable adjectives
                syllables = 4;

                // Read the entire file
                fileText = File.ReadAllText(AdjectiveFilePath4);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdjectiveGraph.Maximum = textLines.Count;
                        AdjectiveGraph.Minimum = 0;
                        AdjectiveGraph.Value = 0;
                        AdjectiveStatusLabel.Text = "Begin importing adjectives: Four Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adjective' object.
                            Adjective adjective = new Adjective();

                            // Set the text
                            adjective.WordText = line.Text;

                            // Set the syllables
                            adjective.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdjective(ref adjective);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdjectiveGraph
                                AdjectiveGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdjectiveStatusLabel.Text = "Finished importing adjectives: Four Syllables.";
            }
            #endregion

            #region ImportAdverbs()
            /// <summary>
            /// This method Imports Adverbs
            /// </summary>
            public void ImportAdverbs()
            {
                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(ConnectionName);

                // starting with one syllable adverbs
                int syllables = 1;

                // Read the entire file
                string fileText = File.ReadAllText(AdverbFilePath1);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdverbsGraph.Maximum = textLines.Count;
                        AdverbsGraph.Minimum = 0;
                        AdverbsGraph.Value = 0;
                        AdverbStatusLabel.Text = "Begin importing adverbs: One Syllable";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // fixing issue of last word being blank
                            if (TextHelper.Exists(line.Text))
                            {
                                // Create a new instance of an 'Adverb' object.
                                Adverb adverb = new Adverb();

                                // Set the text
                                adverb.WordText = line.Text;

                                // Set the syllables
                                adverb.Syllables = syllables;

                                // perform the save
                                bool saved = gateway.SaveAdverb(ref adverb);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // Increment the value for AdverbGraph
                                    AdverbsGraph.Value++;
                                }
                            }
                        }
                    }

                    // Show a finished message for a second
                    AdverbStatusLabel.Text = "Finished importing adverbs: One Syllable.";
                }

                // Two syllable adverbs
                syllables = 2;

                // Read the entire file
                fileText = File.ReadAllText(AdverbFilePath2);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdverbsGraph.Maximum = textLines.Count;
                        AdverbsGraph.Minimum = 0;
                        AdverbsGraph.Value = 0;
                        AdverbStatusLabel.Text = "Begin importing adverbs: Two Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adverb' object.
                            Adverb adverb = new Adverb();

                            // Set the text
                            adverb.WordText = line.Text;

                            // Set the syllables
                            adverb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdverb(ref adverb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdverbGraph
                                AdverbsGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdverbStatusLabel.Text = "Finished importing adverbs: Two Syllables.";

                // Three syllable adverbs
                syllables = 3;

                // Read the entire file
                fileText = File.ReadAllText(AdverbFilePath3);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdverbsGraph.Maximum = textLines.Count;
                        AdverbsGraph.Minimum = 0;
                        AdverbsGraph.Value = 0;
                        AdverbStatusLabel.Text = "Begin importing adverbs: Three Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adverb' object.
                            Adverb adverb = new Adverb();

                            // Set the text
                            adverb.WordText = line.Text;

                            // Set the syllables
                            adverb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdverb(ref adverb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdverbGraph
                                AdverbsGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdverbStatusLabel.Text = "Finished importing adverbs: Three Syllables.";

                // Four syllable adverbs
                syllables = 4;

                // Read the entire file
                fileText = File.ReadAllText(AdverbFilePath4);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        AdverbsGraph.Maximum = textLines.Count;
                        AdverbsGraph.Minimum = 0;
                        AdverbsGraph.Value = 0;
                        AdverbStatusLabel.Text = "Begin importing adverbs: Four Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Adverb' object.
                            Adverb adverb = new Adverb();

                            // Set the text
                            adverb.WordText = line.Text;

                            // Set the syllables
                            adverb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveAdverb(ref adverb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for AdverbGraph
                                AdverbsGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                AdverbStatusLabel.Text = "Finished importing adverbs: Four Syllables.";
            }
            #endregion

            #region ImportNouns()
            /// <summary>
            /// This method Imports Nouns
            /// </summary>
            public void ImportNouns()
            {
                // starting with one syllable nouns
                int syllables = 1;

                // Read the entire file
                string fileText = File.ReadAllText(NounFilePath1);

                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(ConnectionName);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        NounGraph.Maximum = textLines.Count;
                        NounGraph.Minimum = 0;
                        NounGraph.Value = 0;
                        NounStatusLabel.Text = "Begin importing nouns: One Syllable";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // fixing issue of last word being blank
                            if (TextHelper.Exists(line.Text))
                            {
                                // Create a new instance of an 'Noun' object.
                                Noun noun = new Noun();

                                // Set the text
                                noun.WordText = line.Text;

                                // Set the syllables
                                noun.Syllables = syllables;

                                // perform the save
                                bool saved = gateway.SaveNoun(ref noun);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // Increment the value for NounGraph
                                    NounGraph.Value++;
                                }
                            }
                        }
                    }

                    // Show a finished message for a second
                    NounStatusLabel.Text = "Finished importing nouns: One Syllable.";
                }

                // Two syllable nouns
                syllables = 2;

                // Read the entire file
                fileText = File.ReadAllText(NounFilePath2);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        NounGraph.Maximum = textLines.Count;
                        NounGraph.Minimum = 0;
                        NounGraph.Value = 0;
                        NounStatusLabel.Text = "Begin importing nouns: Two Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Noun' object.
                            Noun noun = new Noun();

                            // Set the text
                            noun.WordText = line.Text;

                            // Set the syllables
                            noun.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveNoun(ref noun);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for NounGraph
                                NounGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                NounStatusLabel.Text = "Finished importing nouns: Two Syllables.";

                // Three syllable nouns
                syllables = 3;

                // Read the entire file
                fileText = File.ReadAllText(NounFilePath3);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        NounGraph.Maximum = textLines.Count;
                        NounGraph.Minimum = 0;
                        NounGraph.Value = 0;
                        NounStatusLabel.Text = "Begin importing nouns: Three Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Noun' object.
                            Noun noun = new Noun();

                            // Set the text
                            noun.WordText = line.Text;

                            // Set the syllables
                            noun.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveNoun(ref noun);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for NounGraph
                                NounGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                NounStatusLabel.Text = "Finished importing nouns: Three Syllables.";

                // Four syllable nouns
                syllables = 4;

                // Read the entire file
                fileText = File.ReadAllText(NounFilePath4);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        NounGraph.Maximum = textLines.Count;
                        NounGraph.Minimum = 0;
                        NounGraph.Value = 0;
                        NounStatusLabel.Text = "Begin importing nouns: Four Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Noun' object.
                            Noun noun = new Noun();

                            // Set the text
                            noun.WordText = line.Text;

                            // Set the syllables
                            noun.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveNoun(ref noun);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for NounGraph
                                NounGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                NounStatusLabel.Text = "Finished importing nouns: Four Syllables.";
            }
            #endregion

            #region ImportVerbs()
            /// <summary>
            /// This method Imports Verbs
            /// </summary>
            public void ImportVerbs()
            {
                // starting with one syllable verbs
                int syllables = 1;

                // Read the entire file
                string fileText = File.ReadAllText(VerbFilePath1);

                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(ConnectionName);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        VerbGraph.Maximum = textLines.Count;
                        VerbGraph.Minimum = 0;
                        VerbGraph.Value = 0;
                        VerbStatusLabel.Text = "Begin importing verbs: One Syllable";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // fixing issue of last word being blank
                            if (TextHelper.Exists(line.Text))     
                            {
                                // Create a new instance of an 'Verb' object.
                                Verb verb = new Verb();

                                // Set the text
                                verb.WordText = line.Text;

                                // Set the syllables
                                verb.Syllables = syllables;

                                // perform the save
                                bool saved = gateway.SaveVerb(ref verb);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // Increment the value for VerbGraph
                                    VerbGraph.Value++;
                                }
                            }
                        }
                    }

                    // Show a finished message for a second
                    VerbStatusLabel.Text = "Finished importing verbs: One Syllable.";
                }

                // Two syllable verbs
                syllables = 2;

                // Read the entire file
                fileText = File.ReadAllText(VerbFilePath2);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        VerbGraph.Maximum = textLines.Count;
                        VerbGraph.Minimum = 0;
                        VerbGraph.Value = 0;
                        VerbStatusLabel.Text = "Begin importing verbs: Two Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Verb' object.
                            Verb verb = new Verb();

                            // Set the text
                            verb.WordText = line.Text;

                            // Set the syllables
                            verb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveVerb(ref verb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for VerbGraph
                                VerbGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                VerbStatusLabel.Text = "Finished importing verbs: Two Syllables.";

                // Three syllable verbs
                syllables = 3;

                // Read the entire file
                fileText = File.ReadAllText(VerbFilePath3);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        VerbGraph.Maximum = textLines.Count;
                        VerbGraph.Minimum = 0;
                        VerbGraph.Value = 0;
                        VerbStatusLabel.Text = "Begin importing verbs: Three Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Verb' object.
                            Verb verb = new Verb();

                            // Set the text
                            verb.WordText = line.Text;

                            // Set the syllables
                            verb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveVerb(ref verb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for VerbGraph
                                VerbGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                VerbStatusLabel.Text = "Finished importing verbs: Three Syllables.";

                // Four syllable verbs
                syllables = 4;

                // Read the entire file
                fileText = File.ReadAllText(VerbFilePath4);

                // If the fileText string exists
                if (TextHelper.Exists(fileText))
                {
                    // get the textLines
                    List<TextLine> textLines = TextHelper.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // Setup the Graph and StatusLabel
                        VerbGraph.Maximum = textLines.Count;
                        VerbGraph.Minimum = 0;
                        VerbGraph.Value = 0;
                        VerbStatusLabel.Text = "Begin importing verbs: Four Syllables";

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in textLines)
                        {
                            // Create a new instance of an 'Verb' object.
                            Verb verb = new Verb();

                            // Set the text
                            verb.WordText = line.Text;

                            // Set the syllables
                            verb.Syllables = syllables;

                            // perform the save
                            bool saved = gateway.SaveVerb(ref verb);

                            // if the value for saved is true
                            if (saved)
                            {
                                // Increment the value for VerbGraph
                                VerbGraph.Value++;
                            }
                        }
                    }
                }

                // Show a finished message for a second
                VerbStatusLabel.Text = "Finished importing verbs: Four Syllables.";
            }
        #endregion

        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
        #endregion

        #endregion

    }
    #endregion

}
