using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Common;
using eShopMobile.ViewModels.System.Roles;
using eShopMoblie.ApiIntegration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopMobile.ApiIntegration
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RoleApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            :base(httpClientFactory, httpContextAccessor, configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public Task<bool> CreateRole(RoleCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRole(Guid id)
        {
            return await Delete($"/api/products/" + id);
        }

        public async Task<ApiResult<List<RoleViewModel>>> GetAll()
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/roles");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                List<RoleViewModel> myDeserializedObjList = (List<RoleViewModel>)JsonConvert.DeserializeObject(body, typeof(List<RoleViewModel>));
                return new ApiSuccessResult<List<RoleViewModel>>(myDeserializedObjList);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<List<RoleViewModel>>>(body);
        }

        public Task<RoleViewModel> GetById(Guid id, string languageId)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<RoleViewModel>> GetPagings(GetManageRolePagingRequest request)
        {
            var data = await GetAsync<PagedResult<RoleViewModel>>(
                $"/api/roles/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}");

            return data;
        }

        public Task<bool> UpdateRole(RoleUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
