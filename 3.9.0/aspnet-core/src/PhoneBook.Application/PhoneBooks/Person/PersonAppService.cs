using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using PhoneBook.PhoneBook.Persons;
using System.Linq.Dynamic.Core;
using PhoneBook.PhoneBooks.Dto;
using Abp.AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace PhoneBook.PhoneBooks
{
    public class PersonAppService : PhoneBookAppServiceBase, IPersonAppService
    {

        private readonly IRepository<Person> _repository;
        public PersonAppService(IRepository<Person> repository)
        {
            _repository = repository;
        }
        public async Task CreateOrEdit(PersonEditDto dto)
        {
            if (dto.Id > 0)
            {
                await _repository.UpdateAsync(dto.MapTo<Person>());
            }
            else
            {
                await _repository.InsertAsync(dto.MapTo<Person>());
            }
        }

        public async Task DeletePersonAsync(int id)
        {
            var query = _repository.Get(id);
            if (query == null)
            {
                throw new FieldAccessException("该联系人不存在,可能已经被删除!");
            }
            await _repository.DeleteAsync(id);
        }

        public List<PersonListDto> GetAllListAsync()
        {
            var query = _repository.GetAll();

            //  var person = query.ToListAsync();
            var dtos = query.MapTo<List<PersonListDto>>();
            return dtos;
        }

        public async Task<Person> GetPersonBuyID(int id)
        {

            return await _repository.GetAsync(id);
        }
    }
}
