using Abp.Application.Services;
using MyCollegeV1.Colleges.Dto;

namespace MyCollegeV1.College
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {

    }
}
