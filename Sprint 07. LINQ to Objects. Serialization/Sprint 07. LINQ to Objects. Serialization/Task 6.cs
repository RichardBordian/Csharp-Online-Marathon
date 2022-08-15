﻿//Suppose, you have classes Student and Group:

//class Student { public string Name { get; set; } public double Rating { get; set; } public string GroupName { get; set; } }
//class Group { public string Name { get; set; } public string Description { get; set; } public int Popularity { get; set; } }

//Please, implement the CreateGroups method that takes a list of students as a first parameter and a list of groups as a second.

//The method should return a string that contains for all groups the next information:

// group name, average rating and the list of students in the group in the following format     

// [
//  {
//    "group": "group_name",
//    "description": "group_description",
//    "rating": average_rating,
//    "students": [
//      {
//        "FullName": "Name_of_student",
//        "AvgMark": students_rating
//      },
//      {
//    "FullName": "Ivan",
//        "AvgMark": 68.34
//      },
//      {
//    "FullName": "Oleh",
//        "AvgMark": 98.34
//      },
//      {
//    "FullName": "Katya",
//        "AvgMark": 88.34
//      }
//    ]
//  },
//  ...
//]
//        Tip: you can use GroupJoin to join collection with grouping. 

//        Use JSON serialization to generate output in the specified format.

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)

public static string CreateGroups(List<Student> students, List<Group> groups)
{

}