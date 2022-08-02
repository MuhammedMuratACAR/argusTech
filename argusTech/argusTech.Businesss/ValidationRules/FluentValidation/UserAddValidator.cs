using argusTech.DTO.DTOs.UserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.Business.ValidationRules.FluentValidation
{
    public class UserAddValidator : AbstractValidator<UserAddDto>
    {
        public UserAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("İsim adı boş geçilemez");
            RuleFor(I => I.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(I => I.BirthDay).NotEmpty().WithMessage("Doğum günü alanı boş geçilemez");
            RuleFor(I => I.Email).NotEmpty().EmailAddress().WithMessage("Email alanı boş geçilemez");
            RuleFor(I => I.PhoneNumber).NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez");

        }
    }
}
