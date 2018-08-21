using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Domain.Entities.Auditing;
namespace PhoneBook.PhoneBook.Persons
{
    public class Person:FullAuditedEntity
    {

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [MaxLength(100)]
        public string Address { get; set; }
    }
}
