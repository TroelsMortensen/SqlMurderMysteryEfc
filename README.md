# Sql Murder Mystery

The purpose of this project is to practice LINQ.

You are given some initial code:
* A class called Queries. It's a unit test class, so the idea is you can write methods here for different queries.
* A class called AppContext, which is the EFC context class with all the DbSets. You must edit this class initially. See Setup section below.
* Entity classes matching the tables in the database.
* A ListToTable class, which can print out a list of objects to an ascii table format. See Queries class for examples.

The exercise is about solving a murder, by querying the database, using the AppContext class.

Most of the entities have navigation properties between them. A few entities are without relationships. Below is a class diagram of the entities.
* A primary key is marked {PK}
* A composite primary key is marked {PPK}
* A foreign key is marked {FK}
* A navigation property is marked {NP}

Here is the diagram 

<img src="https://github.com/TroelsMortensen/SqlMurderMysteryEfc/blob/master/SqlMurderMystery/SqlMurderMysteryClassDiagram.png" alt="drawing" width="1000"/>
## Setup

Create a new solution by cloning this project from e.g. Rider.

You need to go to the AppContext class, and change the data source string, so that it points to your local version of the database.db file. You will notice the path is currently to a place on my local pc.\
You must change the path to the absolute path of your database.db. In Rider, you can right click the file --> Copy path/reference.

## Description of the exercise
A crime has taken place and the detective needs your help. The detective gave you the crime scene report, but you somehow lost it. 

You vaguely remember that the crime was a ​murder​ that occurred sometime on ​Jan.15, 2018​ and that it took place in ​SQL City​. 

Start by retrieving the corresponding crime scene report from the police department’s database.

Extra, after you've found the murderer: 

If you think you're up for a challenge, try querying the interview transcript of the murderer to find the real villain behind this crime. 

## Credits
This exercise was borrowed from https://mystery.knightlab.com/

It was originally an SQL "game", using SQLite, and I converted it for C# and EFC, and updated the dataset to follow the typical constraints, like referential integrity.
