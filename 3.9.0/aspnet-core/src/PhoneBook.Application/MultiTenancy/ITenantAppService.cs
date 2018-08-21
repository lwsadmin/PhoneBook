using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBook.MultiTenancy.Dto;

namespace PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
