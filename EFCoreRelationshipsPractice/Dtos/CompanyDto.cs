﻿using EFCoreRelationshipsPractice.Model;
using System.Collections.Generic;

namespace EFCoreRelationshipsPractice.Dtos
{
    public class CompanyDto
    {
        public CompanyDto()
        {
        }

        public CompanyDto(CompanyEntity companyEntity)
        {
            Name = companyEntity.Name;
            if(companyEntity.Profile != null)
            {
                ProfileDto = new ProfileDto(companyEntity.Profile);
            }
            else
            {
                ProfileDto = null;
            }
            EmployeeDtos = companyEntity.Employees?.Select(employeeEntity => new EmployeeDto(employeeEntity)).ToList();
        }

        public string Name { get; set; }

        public ProfileDto? ProfileDto { get; set; }

        public List<EmployeeDto>? EmployeeDtos { get; set; }

        public CompanyEntity ToEntity()
        {
            return new CompanyEntity()
            {
                Name = Name,
                Profile = this.ProfileDto?.ToEntity(),
                Employees = this.EmployeeDtos?.Select(employee => employee.ToEntity()).ToList(),
            };
        }
    }
}