using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamleshproject
{
    public class StaffRegistration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime JoinDate { get; set; }
        public string Faculty { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Image_Path { get; set; }
        public string Ent_User { get; set; }
        public DateTime Ent_DateTime { get; set; }
        public string FullName { get; set; }
    }

    public class Admission
    {
        public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string TemporaryAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Image_Path { get; set; }
        public string Ent_User { get; set; }
        public DateTime Ent_DateTime { get; set; }

        public string FullName { get; set; }
    }

    public class FeeColumns
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string FeeColumn { get; set; }
        public decimal Rate { get; set; }
    }
}
