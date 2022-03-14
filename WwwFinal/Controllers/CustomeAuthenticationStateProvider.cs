using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwFinal.Controllers
{
    public class CustomeAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorageService;

        public CustomeAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var email = await _sessionStorageService.GetItemAsync<string>("email");
            var role = await _sessionStorageService.GetItemAsync<string>("role");

            ClaimsIdentity identity;

            if (email != null)
            {
                identity = new ClaimsIdentity(authenticationType: "test");
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, $"{email}"),
                    new Claim(ClaimTypes.Role, $"{role}")
                };
                identity.AddClaims(claims);
            } else {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(TeachersModel t)
        {

            var claim = new Claim(ClaimTypes.Name, $"{t.firstName}");

            var identity = new ClaimsIdentity(authenticationType: "test");
            identity.AddClaim(claim);

            var user = new ClaimsPrincipal();
            user.AddIdentity(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));


            //List<TeachersModel> list = new List<TeachersModel>();

            //list = await teacherData.GetTeacher(t);

            //if(list != null)
            //{
            //    var claim = new Claim(ClaimTypes.Name, $"{t.PersonID}");

            //    var identity = new ClaimsIdentity();
            //    identity.AddClaim(claim);

            //    var user = new ClaimsPrincipal();
            //    user.AddIdentity(identity);

            //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

            //}
        }

        public void AuthenticateTeacher(TeacherModel t)
        {


            //var claim = new Claim()
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, $"{t.email}"),
                new Claim(ClaimTypes.Role, $"teacher")
            };
            

            var identity = new ClaimsIdentity(authenticationType: "test");
            identity.AddClaims(claims);

            var user = new ClaimsPrincipal();
            user.AddIdentity(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));


            //List<TeachersModel> list = new List<TeachersModel>();

            //list = await teacherData.GetTeacher(t);

            //if(list != null)
            //{
            //    var claim = new Claim(ClaimTypes.Name, $"{t.PersonID}");

            //    var identity = new ClaimsIdentity();
            //    identity.AddClaim(claim);

            //    var user = new ClaimsPrincipal();
            //    user.AddIdentity(identity);

            //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

            //}
        }

        public void AuthenticateStudent(StudentModel s)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, $"{s.email}"),
                new Claim(ClaimTypes.Role, $"student")
            };


            var identity = new ClaimsIdentity(authenticationType: "test");
            identity.AddClaims(claims);

            var user = new ClaimsPrincipal();
            user.AddIdentity(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public async Task LogoutUser()
        {
            await _sessionStorageService.RemoveItemAsync("email");
            await _sessionStorageService.RemoveItemAsync("role");

            ClaimsIdentity identity = new ClaimsIdentity();
            
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
