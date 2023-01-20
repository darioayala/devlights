using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDay.Domain;

namespace WorkDay.Validations
{
    public class AssingmentValidator: AbstractValidator<Assignment>
    {
        public AssingmentValidator()
        {
            RuleFor(assignment => assignment.Employee).NotNull().WithMessage("{PropertyName} can't be null");
            RuleFor(assignment => assignment.Employee).NotEmpty().WithMessage("{PropertyName} can´t be empty");
            RuleFor(assignment => assignment.StartHour).LessThan(x => x.FinishHour).WithMessage("{PropertyName} starting hour can't be greatter than finish hour");
            RuleFor(assignment => assignment.Task).NotEmpty().WithMessage("{PropertyName} can´t be empty");
            RuleFor(assignment => assignment.Task).NotNull().WithMessage("{PropertyName} can´t be null");
        }
    }
}
