using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using RestSharp;
using System.Net.Http;
using System.Net.Http.Headers;
namespace BiostarIntegration
{
    public class Auth
    {

        public string login()
        {
            var client = new RestClient("http://192.168.0.15:81/api/login");
           //client.Timeout = -1;
            var request = new RestRequest("login",Method.Post);
            var body = @"{
" + "\n" +
            @"    ""User"": {
" + "\n" +
            @"        ""login_id"": ""admin"",
" + "\n" +
            @"        ""password"": ""Kobby357""
" + "\n" +
            @"    }
" + "\n" +
            @"}";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return (response.Content);
        }
        public string logout()
        {
            var client = new RestClient("http://192.168.0.15:81/api/logout");
            //client.Timeout = -1;
            var request = new RestRequest("logout",Method.Post);
            RestResponse response = client.Execute(request);
            
            return(response.Content);
            
        }
        public string createNewAG()
        {
            var client = new RestClient("http://192.168.0.15:81/api/access_groups");
       // client.Timeout = -1;
var request = new RestRequest("AG",Method.Post);
        var body = @"{
" + "\n" +
        @"    ""AccessGroup"": {
" + "\n" +
        @"        ""name"": ""ac_grp2"",
" + "\n" +
        @"        ""description"": """",
" + "\n" +
        @"        ""users"": [{""user_id"": 1}],
" + "\n" +
        @"        ""user_groups"": [{""id"": 1}],
" + "\n" +
        @"        ""access_levels"": [{""id"": 2}],
" + "\n" +
        @"        ""floor_levels"": [{""id"": ""32769"",""name"": ""floor_test"",""$$hashKey"": ""object:20863""}]
" + "\n" +
        @"    }
" + "\n" +
        @"}";
        request.AddParameter("text/plain", body,  ParameterType.RequestBody);
RestResponse response = client.Execute(request);
        Console.WriteLine(response.Content);
            return(response.Content);
        }

        public string UpdateAnAG()
        {
            var client = new RestClient("http://192.168.0.15:81/api/access_groups/1");
            //client.Timeout = -1;
            var request = new RestRequest("AG", Method.Put);
            var body = @"{
" + "\n" +
            @"  ""AccessGroup"": {
" + "\n" +
            @"    ""name"": ""Meeting Room Name"",
" + "\n" +
            @"    ""description"": ""MR Description"",
" + "\n" +
            @"    ""access_levels"": [{""id"":1}],
" + "\n" +
            @"    ""user_groups"": [{ ""id"":1}],
" + "\n" +
            @"    ""users"": [{""user_id"":17},{""user_id"":9932},{""user_id"":2}],
" + "\n" +
            @"    ""delete_users"": [{""user_id"":0}]
" + "\n" +
            @"  }
" + "\n" +
            @"}";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return(response.Content);
        }
        public string deleteAnAG()
        {
            var client = new RestClient("http://192.168.0.15:81/api/access_groups?id=");
           // client.Timeout = -1;
            var request = new RestRequest("AG", Method.Delete);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return(response.Content);
        }
        public string CreateUG()
        {
            var client = new RestClient("http://192.168.0.15:81/api/user_groups");
            //client.Timeout = -1;
            var request = new RestRequest("UG", Method.Post);
            var body = @"{
" + "\n" +
            @"    ""UserGroup"": {
" + "\n" +
            @"        ""parent_id"": {
" + "\n" +
            @"            ""id"": 1
" + "\n" +
            @"        },
" + "\n" +
            @"        ""depth"": 1,
" + "\n" +
            @"        ""name"": ""TestDataXFer3""
" + "\n" +
            @"    }
" + "\n" +
            @"}";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return(response.Content);
        }

    }
}