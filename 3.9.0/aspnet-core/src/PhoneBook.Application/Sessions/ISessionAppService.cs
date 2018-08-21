﻿using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneBook.Sessions.Dto;

namespace PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
