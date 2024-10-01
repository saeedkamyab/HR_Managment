using System.ComponentModel.DataAnnotations;
using FluentValidationResult= FluentValidation.Results.ValidationResult;
namespace HR_Managment.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ErrorsList { get; set; } = [];
        public ValidationException(FluentValidationResult validationResult)
        {
            foreach(var err in validationResult.Errors)
            {
                ErrorsList.Add(err.ErrorMessage);
            }
        }
    }
}
