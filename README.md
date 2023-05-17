# TITLE
#### Brief Description/Overview  

#### By (your name here)  

## Technologies Used:
* C#
* .NET 6.0
* MSTest (if needed)
* MySql

## Description:
Long Description / Mission Statement / What the app do.  

## Setup/Installation Req's:

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

### Set up the Databases

Follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/lessons/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `todolist_with_ef_core_dump.sql` file located at the top level of this repo to create a new database in MySQL Workbench with the name `to_do_list_with_ef_core`.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "ToDoList".
3. Within the production directory "ToDoList", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=root;pwd=epicodus;"
  }
}
```

(Additional Instructions about how the app do.)

## Known Bugs:
Any known bugs here

## License:
Git your license, yo!