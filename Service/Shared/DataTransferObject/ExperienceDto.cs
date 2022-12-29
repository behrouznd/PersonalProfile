namespace Shared.DataTransferObject
{
    public record ExperienceDto(Guid Id, string JobTitle, string CompanyName, DateTime DateFrom, DateTime DateTo,
        bool IsCurrently, string DescExperience);
     
}
