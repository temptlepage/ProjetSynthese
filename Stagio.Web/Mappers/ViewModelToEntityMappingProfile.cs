﻿using AutoMapper;
using Stagio.Domain.Entities;

namespace Stagio.Web.Mappers
{
    internal class ViewModelToEntityMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToEntityMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ViewModels.Student.Edit, Student>()
                .ForMember(dest => dest.FirstName, opt => opt.Ignore())
                .ForMember(dest => dest.LastName, opt => opt.Ignore())
                .ForMember(dest => dest.Matricule, opt => opt.Ignore())
                .ForMember(dest => dest.Activated, opt => opt.Ignore())
                .IgnoreAllNonExisting();

            Mapper.CreateMap<ViewModels.Student.ListStudent, Student>()
                  .ForMember(dest => dest.Telephone, opt => opt.Ignore())
                  .ForMember(dest => dest.Id, opt => opt.Ignore())
                  .IgnoreAllNonExisting();


            Mapper.CreateMap<ViewModels.Student.Create, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .IgnoreAllNonExisting();

            Mapper.CreateMap<ViewModels.Coordinator.Create, Coordinator>()
                .IgnoreAllNonExisting();

            Mapper.CreateMap<ViewModels.ContactEnterprise.Reactive, ContactEnterprise>()
                .IgnoreAllNonExisting();

            Mapper.CreateMap<ViewModels.Stage.Create, Stage>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.PublicationDate, opt => opt.Ignore())
                .IgnoreAllNonExisting();
        }
    }
}