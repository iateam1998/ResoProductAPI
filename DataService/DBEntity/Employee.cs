using System;
using System.Collections.Generic;

namespace DataService.DBEntity
{
    public partial class Employee
    {
        public Employee()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            Attendance = new HashSet<Attendance>();
            CheckFinger = new HashSet<CheckFinger>();
            EmployeeAttributeMapping = new HashSet<EmployeeAttributeMapping>();
            EmployeeFingers = new HashSet<EmployeeFingers>();
            EmployeeInStore = new HashSet<EmployeeInStore>();
            PaySlip = new HashSet<PaySlip>();
            ShiftRegister = new HashSet<ShiftRegister>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Role { get; set; }
        public string EmpEnrollNumber { get; set; }
        public int MainStoreId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public int BrandId { get; set; }
        public decimal? Salary { get; set; }
        public int Status { get; set; }
        public DateTime? DateStartWork { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeRegency { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? EmployeeSex { get; set; }
        public string PersonalCardId { get; set; }
        public DateTime? DatePersonalCard { get; set; }
        public string PlaceOfPersonalCard { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MainAddress { get; set; }
        public string EmployeeHometown { get; set; }
        public string EmployeePlaceBorn { get; set; }
        public int? EmployeeGroupId { get; set; }

        public virtual EmployeeGroup EmployeeGroup { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<CheckFinger> CheckFinger { get; set; }
        public virtual ICollection<EmployeeAttributeMapping> EmployeeAttributeMapping { get; set; }
        public virtual ICollection<EmployeeFingers> EmployeeFingers { get; set; }
        public virtual ICollection<EmployeeInStore> EmployeeInStore { get; set; }
        public virtual ICollection<PaySlip> PaySlip { get; set; }
        public virtual ICollection<ShiftRegister> ShiftRegister { get; set; }
    }
}
