# RandomDataImporter
This is a second project dealing with Random Data. This project imports a list of Adjectives, Adverbs, Nouns and Verbs.

The paths to the files are hard coded. Open the Main Form app, and update the paths to the 16 files in the Input folder.

The SQL Scripts folder contains the schema only.

You will need to create a new SQL Server database, execute the SQL to create the database schema, then create a 
connection string to your new database.

Next create a system environment variable, and call it RandomData, and then set the valule to the new connection string.

Run the program, and click the 4 Import buttons and your database will be created.


Tools used in this project.

DataTier.Net
https://github.com/DataJuggler/DataTier.Net

Nuget Package:
DataJuggler.UltimateHelper

Source:
https://github.com/DataJuggler/UltimateHelper


I am building a random story generator, and I needed some data to go with my random data for people and addresses.

Sorry the paths are hard coded, I will try and make them a relative path if I can.