using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PhoneBook.PhoneBook.Persons;
namespace PhoneBook.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : EntityDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
