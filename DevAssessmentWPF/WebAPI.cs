using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Security.Policy;

namespace DevAssessmentWPF
{
    public class WebAPI
    {
        const string baseURL = "https://gorest.co.in/public/v2/users";
        const string apiAuthToken = "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023";
        public static Task<HttpResponseMessage> GetData(string lParams = "")
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = httpClient.GetAsync(baseURL + lParams);
                response.Wait();
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> PostData<T>(T model) where T : class
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023");
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiAuthToken);
                    var response = httpClient.PostAsJsonAsync(baseURL, model);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> PutData<T>(string url, T model) where T : class
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiAuthToken);
                    var response = httpClient.PutAsJsonAsync(url, model);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> DeleteData(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiAuthToken);
                    var response = httpClient.DeleteAsync(url);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
