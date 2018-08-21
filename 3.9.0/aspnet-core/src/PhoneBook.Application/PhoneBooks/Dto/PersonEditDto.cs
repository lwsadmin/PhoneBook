using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using PhoneBook.PhoneBook.Persons;

namespace PhoneBook.PhoneBooks.Dto
{
    [AutoMap(typeof(Person))]
    public class PersonEditDto:FullAuditedEntityDto
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
