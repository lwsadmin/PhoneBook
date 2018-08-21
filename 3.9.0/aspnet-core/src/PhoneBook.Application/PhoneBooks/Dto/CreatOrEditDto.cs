using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PhoneBook.PhoneBook.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.PhoneBooks.Dto
{
    [AutoMap(typeof(Person))]
    public class CreatOrEditDto
    {
        public PersonEditDto PersonEditDto { get; set; }
    }
}
