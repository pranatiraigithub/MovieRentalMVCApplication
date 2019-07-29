//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;

//namespace MovieRentalMVCApplication.Models
//{
//    public class Min18YearsifAMember : ValidationAttribute
//    {
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            var customer = (Customer)validationContext.ObjectInstance;
//            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)

//                return ValidationResult.Success;
//            if (customer.DateOfBirth == null)
//                return new ValidationResult("BirthDate is Required");
//            var age = DateTime.Today.Year - customer.DateOfBirth.Year;
//            return (age >= 18) ? ValidationResult.Success
//                : new ValidationResult("Should be greater than 18 yrs to avail membership");


//        }
//    }
//}