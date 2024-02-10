using Abp.Application.Services;
using MyCollegeV1.Students.Dto;

namespace MyCollegeV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
      
    }
}

