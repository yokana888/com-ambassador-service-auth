﻿using Com.Ambassador.Service.Auth.Lib.Models;
using Com.Ambassador.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Auth.Lib.AutoMapperProfiles
{
    public class AccountProfile : BaseProfile
    {
        public AccountProfile() : base()
        {
            CreateMap<Models.AccountProfile, AccountProfileViewModel>()
                .ForPath(d => d.firstname, opt => opt.MapFrom(s => s.Firstname))
                .ForPath(d => d.gender, opt => opt.MapFrom(s => s.Gender))
                .ForPath(d => d.id, opt => opt.MapFrom(s => s.Id))
                .ForPath(d => d.lastname, opt => opt.MapFrom(s => s.Lastname))
                .ForPath(d => d.dob, opt => opt.MapFrom(s => s.Dob))
                .ForPath(d => d.email, opt => opt.MapFrom(s => s.Email))
                .ReverseMap();

            CreateMap<AccountRole, RoleViewModel>()
                .ForPath(d => d.code, opt => opt.MapFrom(s => s.Role.Code))
                .ForPath(d => d.description, opt => opt.MapFrom(s => s.Role.Description))
                .ForPath(d => d.name, opt => opt.MapFrom(s => s.Role.Name))
                .ForPath(d => d._id, opt => opt.MapFrom(s => s.RoleId))
                .ForPath(d => d.permissions, opt => opt.MapFrom(s => s.Role.Permissions))
                .ReverseMap();

            //CreateMap<Permission, PermissionViewModel>()
            //    .ForPath(d => d.id, opt => opt.MapFrom(s => s.Id))
            //    .ForPath(d => d.permission, opt => opt.MapFrom(s => s.permission))
            //    .ForPath(d => d.roleId, opt => opt.MapFrom(s => s.RoleId))
            //    .ForPath(d => d.unit.Code, opt => opt.MapFrom(s => s.UnitCode))
            //    .ForPath(d => d.unit.Name, opt => opt.MapFrom(s => s.Unit))
            //    .ForPath(d => d.unit.Id, opt => opt.MapFrom(s => s.UnitId))
            //    .ForPath(d => d.unit.Division.Name, opt => opt.MapFrom(s => s.Division))
            //    .ReverseMap();

            CreateMap<Permission2, Permission2ViewModel>()
               .ForPath(d => d.roleId, opt => opt.MapFrom(s => s.RoleId))
               .ForPath(d => d.Menu, opt => opt.MapFrom(s => s.Menu))
               .ForPath(d => d.Code, opt => opt.MapFrom(s => s.Code))
               .ForPath(d => d.SubMenu, opt => opt.MapFrom(s => s.SubMenu))
               .ForPath(d => d.MenuName, opt => opt.MapFrom(s => s.MenuName))
               .ReverseMap();

            CreateMap<Account, AccountViewModel>()
                .ForPath(d => d.username, opt => opt.MapFrom(s => s.Username))
                .ForPath(d => d.password, opt => opt.MapFrom(s => s.Password))
                .ForPath(d => d.isLocked, opt => opt.MapFrom(s => s.IsLocked))
                .ForPath(d => d.profile, opt => opt.MapFrom(s => s.AccountProfile))
                .ForPath(d => d.roles, opt => opt.MapFrom(s => s.AccountRoles))
                .ReverseMap();

            
        }
    }
}
