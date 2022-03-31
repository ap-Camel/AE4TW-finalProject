# AE4TW-finalProject

## task description 

Web application using client-server technologies (HTML, CSS, JavaScript, PHP) with data stored in Database
  1. Should use also server side scripting (e.g. PHP or different language) and provide basic CRUD on data tables
  2. Should provide admin section and public section (user accounts, login, etc.)

--------------------------------------------------------------------------------------------------------------

## website description 

* This website provides a place where teachers can create online exams and publish the exams so their students can take those exams online.
* Teacher can create exams and questions, they can create questions and add them to exams seperatly
* Teacher can also add and remove their students
* When a student takes an exam, the questions and the answers will be choosen randomly so that no two students will have the same questions

--------------------------------------------------------------------------------------------------------------

## solution description

* The login is provided but it is only simple login and there isn't any encryption or password hasshing
* The logged in user is saved using session storage using [this library](https://github.com/Blazored/SessionStorage)
* Roles are also used to differentiate between student and teacher
* Dapper is used for the ORM and for the databse, MS SQL server is used
* There is no design for the website, I mainly used all the default designs provided

--------------------------------------------------------------------------------------------------------------

## some pictures

#### login page as teacher or student


![login page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20234040.png)




#### here the teacher can see theri students


![students page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20234847.png)




#### here the teacher can see theri exams


![exams page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20234914.png)




#### here the teacher can see their questions


![questions page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20234942.png)




#### here the student can see their available exams


![available exams page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20235019.png)




#### here the student is taking the examination


![eamination page](https://github.com/ap-Camel/AE4TW-finalProject/blob/master/Pictures/Screenshot%202022-03-30%20235038.png)





