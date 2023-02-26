using AutoMapper;
using EmployeeCRUD.DTO;

namespace EmployeeCRUD.AutoMapper
{
    public class EmployeeMappingProfiles : Profile
    {
        public EmployeeMappingProfiles()
        {
            CreateMap<EmployeeCreateDTO, Employee>();
            //CreateMap<EmployeeCreateDTO, Employee>()
            //    .ForMember(dist => dist.FirstName, opt => opt.MapFrom(src => src.FirstName));
        }
        
    }
}
