using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBook.PhoneBook.Persons;
using PhoneBook.PhoneBooks.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace PhoneBook.PhoneBooks
{
    public interface IPersonAppService : IApplicationService
    {
        List<PersonListDto> GetAllListAsync();
        Task<Person> GetPersonBuyID(int id);
        Task CreateOrEdit(PersonEditDto dto);
        Task DeletePersonAsync(int id);
    }
}
