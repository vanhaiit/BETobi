using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOBI.Model.Models;
using TOBI.Service;
using TOBI.Web.App_Start;
using TOBI.Web.Infrastructure.Core;
using TOBI.Web.Models;

namespace TOBI.Web.Api
{
    [RoutePrefix("api/postcategory")]
    [Authorize]
    public class ApplicationUserController : ApiControllerBase
    {
        ApplicationUserManager _userManager;
        IApplicationUserService _applicationUserService;
        IApplicationGroupService _appGroupService;
        public ApplicationUserController(
            IErrorService errorService,
            IApplicationUserService postCategoryService,
            ApplicationUserManager userManager,
              IApplicationGroupService appGroupService
            ) : base(errorService)
        {
            this._userManager = userManager;
            this._appGroupService = appGroupService;
            this._applicationUserService = postCategoryService;
        }

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _applicationUserService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                return response;
            });
        }
        [Route("detail/{id}")]
        [HttpGet]
        public HttpResponseMessage Details(HttpRequestMessage request, string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return request.CreateErrorResponse(HttpStatusCode.BadRequest, nameof(id) + " không có giá trị.");
            }
            var user = _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return request.CreateErrorResponse(HttpStatusCode.NoContent, "Không có dữ liệu");
            }
            else
            {
                var applicationUserViewModel = Mapper.Map<ApplicationUser, ApplicationUserViewModel>(user.Result);
                var listGroup = _appGroupService.GetListGroupByUserId(applicationUserViewModel.Id);
                applicationUserViewModel.Groups = Mapper.Map<IEnumerable<ApplicationGroup>, IEnumerable<ApplicationGroupViewModel>>(listGroup);
                return request.CreateResponse(HttpStatusCode.OK, applicationUserViewModel);
            }
        }

    }
}
