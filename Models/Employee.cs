﻿using backend_employees_webapi_aspdotnet.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_employees_webapi_aspdotnet.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Role Role { get; private set; }
        public bool Active { get; private set; } = true;
        public DateTime CreationDate { get; private set; } = DateTime.Now.ToLocalTime();
        public DateTime UpdateDate { get; private set; } = DateTime.Now.ToLocalTime();

        public Employee(string name, int age, Role role)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Role = role;
            Active = true;
        }

        public void NewModification()
        {
            UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void InactivateEmployee()
        {
            Active = false;
        }
    }
}
