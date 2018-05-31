﻿namespace ConsoleApp4
{
    public class Student
    {
        private string rollNumber;
        private string name;
        private string email;
        private string phone;

        public Student(string rollNumber, string name, string email, string phone)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public Student()
        {
        }

        public string RollNumber
        {
            get => rollNumber;
            set => rollNumber = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}