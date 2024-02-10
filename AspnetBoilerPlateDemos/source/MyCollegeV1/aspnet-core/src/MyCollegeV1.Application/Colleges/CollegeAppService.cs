using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyCollegeV1.Authorization;
using MyCollegeV1.Colleges.Dto;
using MyCollegeV1.Models;

namespace MyCollegeV1.Colleges
{

    // [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {
        private readonly IRepository<College, int> _collegeRepository;
        private readonly IObjectMapper _objectMapper;

        public CollegeAppService
        (
            IRepository<College, int> collegeRepository,
            IObjectMapper objectMapper
        )
            : base(collegeRepository)
        {
            _collegeRepository = collegeRepository;
            _objectMapper = objectMapper;
        }

        public async Task<List<CollegeDto>> GetMyCollgeListAsync()
        {
            var colleges = await Repository.GetAllListAsync();
            colleges = colleges.Where(p => p.Id > 1).ToList();
            return _objectMapper.Map<List<CollegeDto>>(colleges);
        }

        public void CreateMyCollege(CreateCollegeDto input)
        {
            var college = _objectMapper.Map<College>(input);
            _studentRepository.Insert(college);
        }
    }
}
