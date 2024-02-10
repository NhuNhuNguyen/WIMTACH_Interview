using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCollegeV1.Models;

namespace MyCollegeV1.Colleges.Dto
{
    [AutoMapFrom(typeof(College))]
    public class CollegeDto : EntityDto<int>
    {

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string GPSLatitude { get; set; }

        public string Longitude { get; set; }

        public string ContactEmail { get; set; }

        public bool IsSleep { get; set; }

        public bool NguyenReasonDescription { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

    }
}