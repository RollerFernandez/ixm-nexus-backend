global using Autofac;
global using Microsoft.AspNetCore.Http;
global using Microsoft.Extensions.Options;
global using System.Security.Claims;
global using AutoMapper;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Text;

global using Ixm.Nexus.Commons.Configurations;
global using Ixm.Nexus.Users.Application.Interfaces;
global using Ixm.Nexus.Users.Domain.Models;
global using Ixm.Nexus.Users.Infrastructure.Repository.Interfaces;
global using Ixm.Nexus.Users.Infrastructure.Repository.Interfaces.Data;
global using Ixm.Nexus.Users.Application.Dto;
global using Ixm.Nexus.Users.Application.Dto.UsersDto;
global using Ixm.Nexus.Commons;