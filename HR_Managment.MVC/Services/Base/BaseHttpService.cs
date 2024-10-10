using System.Net.Http.Headers;
using Hanssens.Net;
using HR_Managment.MVC.Contracts;

namespace HR_Managment.MVC.Services.Base
{
    public class BaseHttpService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IClient _client;

        public BaseHttpService(IClient client,ILocalStorageService localStorageService)
        {
            _client = client;
            _localStorageService = localStorageService;
        }

        protected Response<Guid> ConvertApiExxeptions<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "خطایی رخ داده است",ValidationErrors =exception.Response,Success = false};
            }
            else if(exception.StatusCode==404)
            {
                return new Response<Guid>() { Message = "پیدا نشد",  Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "خطایی رخ داده است", Success = false };
            }

        }

        protected void AddBearerToken()
        {
            if (_localStorageService.Exists("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Bearer",_localStorageService.GetStorageValue<string>("token"));
            }
        }
    }
}
