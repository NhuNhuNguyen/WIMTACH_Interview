using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyCollegeV1.Authorization;
using MyCollegeV1.Students.Dto;
using MyCollegeV1.Models;

namespace MyCollegeV1.Students
{

    // [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService
        (
            IRepository<Student, int> repository
        )
        : base(repository)
        {

        }

    }
}
