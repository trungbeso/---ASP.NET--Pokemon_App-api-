-- Inserting 5 records into the Countries table
INSERT INTO Countries (Name) VALUES ('Kanto');
INSERT INTO Countries (Name) VALUES ('Johto');
INSERT INTO Countries (Name) VALUES ('Hoenn');
INSERT INTO Countries (Name) VALUES ('Sinnoh');
INSERT INTO Countries (Name) VALUES ('Unova');

-- Inserting 5 records into the Categories table
INSERT INTO Categories (Name) VALUES ('Electric');
INSERT INTO Categories (Name) VALUES ('Fire');
INSERT INTO Categories (Name) VALUES ('Water');
INSERT INTO Categories (Name) VALUES ('Grass');
INSERT INTO Categories (Name) VALUES ('Normal');

-- Inserting 5 records into the Pokemon table
-- Assuming Id and BirthDate columns based on your entity
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Pikachu', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Charizard', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Blastoise', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Venusaur', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Jigglypuff', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Squirtle', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Charmander', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Bulbasaur', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Eevee', '1996-11-21'); 
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Snorlax', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Mewtwo', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Mew', '1996-02-27');
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Chikorita', '1999-10-14'); 
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Cyndaquil', '1999-10-14'); 
INSERT INTO Pokemon (Name, BirthDate) VALUES ('Totodile', '1999-10-14');  

-- Inserting 5 records into the Reviewers table
-- Assuming Id, FirstName, LastName columns
INSERT INTO Reviewers (FirstName, LastName) VALUES ('Ash', 'Ketchum');
INSERT INTO Reviewers (FirstName, LastName) VALUES ('Misty', 'Waterflower');
INSERT INTO Reviewers (FirstName, LastName) VALUES ('Brock', 'Harrison');
INSERT INTO Reviewers (FirstName, LastName) VALUES ('Gary', 'Oak');
INSERT INTO Reviewers (FirstName, LastName) VALUES ('Serena', 'Gabena');

-- Inserting 5 records into the Owners table
-- Assuming Id, Name, Gym, and CountryId columns
-- We need valid CountryIds (assuming 1, 2, 3, 4, 5 based on our previous inserts)
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Brock', 'Harrison', 'Pewter Gym', 1);  
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Misty', 'Waterflower', 'Cerulean Gym', 1); 
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Lt.', 'Surge', 'Vermilion Gym', 1);    
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Jasmine', 'Steel', 'Olivine Gym', 2);  
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Wattson', 'Volt', 'Mauville Gym', 3);  
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Erika', 'Grass', 'Celadon Gym', 1);   
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Janine', 'Poison', 'Fuchsia Gym', 1);
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Falkner', 'Wind', 'Violet Gym', 2);  
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Bugsy', 'Bug', 'Azalea Gym', 2);     
INSERT INTO Owners (FirstName, LastName, Gym, CountryId) VALUES ('Whitney', 'Normal', 'Goldenrod Gym', 2);


-- Inserting 5 records into the Reviews table
-- Assuming Id, Title, Text, Rating, PokemonId, and ReviewerId columns
-- We need valid PokemonIds (assuming 1-5) and ReviewerIds (assuming 1-5)
INSERT INTO Reviews (Title, Text, Rating, PokemonId, ReviewerId) VALUES ('Awesome Mouse', 'Pikachu is the best starter!', 5, 1, 1); -- Pikachu by Ash
INSERT INTO Reviews (Title, Text, Rating, PokemonId, ReviewerId) VALUES ('Fire Power', 'Charizard is incredibly strong.', 4, 2, 3); -- Charizard by Brock
INSERT INTO Reviews (Title, Text, Rating, PokemonId, ReviewerId) VALUES ('Water Tank', 'Blastoise defends well.', 4, 3, 2); -- Blastoise by Misty
INSERT INTO Reviews (Title, Text, Rating, PokemonId, ReviewerId) VALUES ('Sleepy Singer', 'Jigglypuff is cute but makes me sleepy.', 3, 5, 5); -- Jigglypuff by Serena
INSERT INTO Reviews (Title, Text, Rating, PokemonId, ReviewerId) VALUES ('Bulbasaur''s Strength', 'Venusaur is a solid grass type.', 4, 4, 4); -- Venusaur by Gary

-- Inserting 5 records into the PokemonCategories join table
-- Requires valid PokemonId and CategoryId combinations
-- Assuming PokemonIds 1-5 and CategoryIds 1-5
-- Pokemon 1 (Pikachu - Electric)
INSERT INTO PokemonCategories (PokemonId, CategoryId) VALUES (1, 1);
-- Pokemon 2 (Charizard - Fire)
INSERT INTO PokemonCategories (PokemonId, CategoryId) VALUES (2, 2);
-- Pokemon 3 (Blastoise - Water)
INSERT INTO PokemonCategories (PokemonId, CategoryId) VALUES (3, 3);
-- Pokemon 4 (Venusaur - Grass)
INSERT INTO PokemonCategories (PokemonId, CategoryId) VALUES (4, 4);
-- Pokemon 5 (Jigglypuff - Normal)
INSERT INTO PokemonCategories (PokemonId, CategoryId) VALUES (5, 5);


-- Owner 1 (Brock) owns Pokemon 1 (Pikachu) - (example, doesn't match anime)
INSERT INTO PokemonOwners (PokemonId, OwnerId) VALUES (1, 1);
-- Owner 2 (Misty) owns Pokemon 3 (Blastoise) - (example)
INSERT INTO PokemonOwners (PokemonId, OwnerId) VALUES (3, 2);
-- Owner 3 (Lt. Surge) owns Pokemon 1 (Pikachu) - (example)
INSERT INTO PokemonOwners (PokemonId, OwnerId) VALUES (1, 3);
-- Owner 4 (Jasmine) owns Pokemon 2 (Charizard) - (example)
INSERT INTO PokemonOwners (PokemonId, OwnerId) VALUES (2, 4);
-- Owner 5 (Wattson) owns Pokemon 5 (Jigglypuff) - (example)
INSERT INTO PokemonOwners (PokemonId, OwnerId) VALUES (5, 5);