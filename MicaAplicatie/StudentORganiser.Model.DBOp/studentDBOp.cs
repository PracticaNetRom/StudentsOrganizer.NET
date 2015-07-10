﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using StudentOrganiser.Model.BO;
using System.Data;

namespace StudentORganiser.Model.DBOp
{
    public class StudentDBOP
    {
        private SqlConnection conn;
        private string connectionString;

        public StudentDBOP(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudent(Student stud)
        {
            string insertString = @"INSERT INTO STUDENT(
                                        FirstName,
                                        LastName,
                                        Gender,
                                        BirthDate,
                                        Email,
                                        PhoneNumber,
                                        Faculty,
                                        FacultyStartYear) values(
                                                          @firstName,@lastName,@gender,
                                                          @birthDate,@email,@phoneNumber,
                                                          @faculty,@facultyStart
                                                          )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@firstName", stud.FirstName);
                command.Parameters.Add("@lastName", stud.LastName);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@birthDate", stud.BirthDate);
                command.Parameters.Add("@email", stud.Email);
                command.Parameters.Add("@phoneNumber", stud.PhoneNumber);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStart", stud.FacultyStartYear);
                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
                conn.Close();
            }

        }

        public void UpdateStudent(Student stud)
        {
            string updateString = "UPDATE STUDENT SET FirstName = @firstName,LastName = @lastName, Gender=@gender, BirthDate=@birthDate, Email=@email, PhoneNumber = @phoneNumber, Faculty = @faculty, FacultyStartYear = @facultyStart WHERE student.id = '" + stud.ID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@firstName", stud.FirstName);
                command.Parameters.Add("@lastName", stud.LastName);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@birthDate", stud.BirthDate);
                command.Parameters.Add("@email", stud.Email);
                command.Parameters.Add("@phoneNumber", stud.PhoneNumber);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStart", stud.FacultyStartYear);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteStudent(Student stud)
        {
            string deleteString = "DELETE FROM Student WHERE id = '" + stud.ID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public Student SearchStudent(int studID)
        {
            Student student = new Student();
            student.ID = studID;

            string searchString = "SELECT * FROM student where id = " + student.ID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                        student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        student.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        student.Email = reader.GetString(reader.GetOrdinal("Email"));
                        student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                        student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("FacultyStartYear"));
                    }
                    reader.Close();
                }

                conn.Close();
            }

            return student;
        }

        public List<Student> GetStudents()
        {
            Student student = new Student();
            List<Student> studentsList = new List<Student>();

            string selectString = "SELECT * FROM student ";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(selectString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                        student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        student.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        student.Email = reader.GetString(reader.GetOrdinal("Email"));
                        student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                        student.FacultyStartYear = reader.GetInt32(reader.GetOrdinal("FacultyStartYear"));

                        studentsList.Add(student);
                    }
                    reader.Close();
                }
            }

            return studentsList;
        }
    }
}
