using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOBI.Service;
using TOBI.Web.Infrastructure.Core;

namespace TOBI.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class ApplicationUserController : ApiControllerBase
    {
        IApplicationUserService _applicationUserService;
        public ApplicationUserController(IErrorService errorService, IApplicationUserService postCategoryService) :
            base(errorService)
        {
            this._applicationUserService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _applicationUserService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                return response;
            });
        }

    }
}
