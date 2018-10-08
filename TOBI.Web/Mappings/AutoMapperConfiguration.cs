using AutoMapper;
using TOBI.Model.Models;
using TOBI.Web.Models;

namespace TOBI.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //aplicationuser
                cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>().MaxDepth(2);
                cfg.CreateMap<ApplicationGroup, ApplicationGroupViewModel>().MaxDepth(2);
                //  apper.Map<ApplicationGroup, ApplicationGroupViewModel>(appGroup);
            });
        }
    }
}