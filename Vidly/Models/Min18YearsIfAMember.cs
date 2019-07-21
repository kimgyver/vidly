using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == Customer.Unknown || 
                customer.MembershipTypeId == Customer.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");

            int age = DateTime.Now.Year - customer.Birthdate.Value.Year;
            if (age < 18)
                return new ValidationResult("Cutomer should be at least 18 years old to go on");

            return ValidationResult.Success;
        }
    }
}