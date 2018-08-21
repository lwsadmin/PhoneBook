using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using PhoneBook.PhoneBook.Persons;
using Abp.Domain.Entities;

namespace PhoneBook.PhoneBook.PhoneNumber
{
    public class PhoneNumber : Entity<long>, IHasCreationTime
    {

        [MaxLength(11)]
        [Required]
        public string Number { get; set; }
        public PhoneType Type { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
