using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentAjax
{

    public class Student
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }

        public Student(int id, int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }
    }
    /*random note: the need for a new class StudentList was mainly because when making an object of the Student class,
     * the constructor trigger input requirements. Hence, a new list where we can make a simple object with no arguments
     * is made. 
    */
    public class StudentList        
    {
        //objects with information//
        Student Ali = new Student(1, 21, "Ali");
        Student Bilal = new Student(2, 22, "Bilal");
        Student Sal = new Student(3, 24, "Sal");
        Student Tom = new Student(4, 24, "Tom");
        Student Bot = new Student(5, 20, "Bot");
        Student Meg = new Student(6, 20, "Meg");
        Student Tim = new Student(7, 34, "Tim");
        Student Ver = new Student(8, 33, "Ver");
        Student Ham = new Student(9, 25, "Ham");
        Student Mushtaq = new Student(10, 20, "Mushtaq");
        Student Imtiaz = new Student(11, 20, "Imtiaz");
        Student Rashid = new Student(12, 27, "Rashid");
        Student Akbar = new Student(13, 44, "Akbar");
        Student Ken = new Student(14, 33, "Ken");
        Student Ben = new Student(15, 28, "Ben");
        Student Larry = new Student(16, 27, "Larry");
        Student Has = new Student(17, 24, "Has");
        Student Perez = new Student(18, 26, "Perez");
        Student Babar = new Student(19, 26, "Babar");
        Student Fawad = new Student(20, 25, "Fawad");

        //method to return list of objects//
        public List<Student> studentData()
        {

         List<Student> studentInfoList = new List<Student>();   //object of Student class//
            studentInfoList.Add(Ali);
            studentInfoList.Add(Bilal);
            studentInfoList.Add(Sal);
            studentInfoList.Add(Tom);
            studentInfoList.Add(Bot);
            studentInfoList.Add(Meg);
            studentInfoList.Add(Tim);
            studentInfoList.Add(Ver);
            studentInfoList.Add(Ham);
            studentInfoList.Add(Mushtaq);
            studentInfoList.Add(Imtiaz);
            studentInfoList.Add(Rashid);
            studentInfoList.Add(Akbar);
            studentInfoList.Add(Ken);
            studentInfoList.Add(Ben);
            studentInfoList.Add(Larry);
            studentInfoList.Add(Has);
            studentInfoList.Add(Perez);
            studentInfoList.Add(Babar);
            studentInfoList.Add(Fawad); 
            
         return studentInfoList;
        }
    }


    public partial class StudentAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //object of StudentList class to access studentData function in that class//
            StudentList stuList = new StudentList();
            DropDownList1.DataSource = stuList.studentData();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();    
        }
        [WebMethod]
        public static Student GetStInfo(string inputValue)
        {
            StudentList data = new StudentList();
            int choice = Convert.ToInt32(inputValue);
            return data.studentData()[choice-1];
        }
    }
}