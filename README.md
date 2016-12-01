# ZooTest

The accompanying Visual Studio Solution is a very small MVC application which uses Entity Framework to connect to a local database. It has a few tables, one controller, and one view which lists the animals in the zoo.

We would like to see the following improvements made:

1.	Replace the ‘Date of Birth’ column with an ‘Age’ column displaying the animal’s age in years
2.	Visually highlight rows where the animal is older than species’ life expectancy
3.	Add a new column: ‘Average Species Age’, which calculates the average age of all the animals of that species. Do this in the database, not in memory - you may need to create a view model 
4.	Add search functionality so user can enter a name into input box and return all animals whose name contains the search text 
5.	Allow the user to sort by Species Name by clicking on the column header. Clicking again should reverse the ordering
6.	If the user double-clicks on an animal’s name, make it editable so that when they edit and hit ‘enter’, the animal’s name is updated. Do not refresh the page (use AJAX)
7.	Add a new database Entity, ZooKeeper. A ZooKeeper has a FirstName, LastName, and looks after many animals. Animals are looked after by many ZooKeepers (it is a many-to-many relationship).
