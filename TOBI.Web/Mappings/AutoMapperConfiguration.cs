using AutoMapper;
using TOBI.Model.Models;
using TOBI.Web.Models;

namespace G9VN.TIKTAK.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //aplicationuser
                cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>().MaxDepth(2);
            });
        }
    }
}