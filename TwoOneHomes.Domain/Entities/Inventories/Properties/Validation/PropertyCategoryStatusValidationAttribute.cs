using System.ComponentModel.DataAnnotations;
using System.Reflection;
using TwoOneHomes.Domain.Entities.Inventories.Properties.Enums;

namespace TwoOneHomes.Domain.Entities.Inventories.Properties.Validation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public sealed class PropertyCategoryStatusValidationAttribute : ValidationAttribute
{
    private readonly string _categoryPropertyName;

    public PropertyCategoryStatusValidationAttribute(string categoryPropertyName)
    {
        _categoryPropertyName = categoryPropertyName;
        CategoryPropertyName = categoryPropertyName;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Get the category property from the validation context
        PropertyInfo? categoryProperty = validationContext.ObjectType.GetProperty(_categoryPropertyName);
        if (categoryProperty == null)
        {
            return new ValidationResult($"Unknown property: {_categoryPropertyName}");
        }

        object? categoryValue = categoryProperty.GetValue(validationContext.ObjectInstance);
        if (categoryValue is not PropertyCategory category)
        {
            return new ValidationResult($"The property '{_categoryPropertyName}' must be of type {nameof(PropertyCategory)}.");
        }

        if (value is not PropertyStatus status)
        {
            return new ValidationResult($"The value being validated must be of type {nameof(PropertyStatus)}.");
        }

        // Validate based on rules
        bool isValid = category switch
        {
            PropertyCategory.Selling => true, // All statuses are valid for Selling
            PropertyCategory.Leasing => true, // All statuses are valid for Leasing
            PropertyCategory.Rental => status == PropertyStatus.Available || status == PropertyStatus.Unavailable,
            _ => false
        };

        return isValid
            ? ValidationResult.Success
            : new ValidationResult($"The status '{status}' is not valid for the category '{category}'.");
    }

    public string CategoryPropertyName { get; }
}