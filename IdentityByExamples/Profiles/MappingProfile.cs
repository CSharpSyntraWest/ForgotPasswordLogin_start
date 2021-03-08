using AutoMapper;
using IdentityByExamples.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//ADDED 20: new class MappingProfile to map UserRegistrationModel to IdentityUser
//ADDED 21: Run app and test Registration form 
//https://code-maze.com/user-registration-aspnet-core-identity/
namespace IdentityByExamples.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //we map email to the username 
            //because we are not using username in the registration form.
            CreateMap<UserRegistrationModel, IdentityUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
