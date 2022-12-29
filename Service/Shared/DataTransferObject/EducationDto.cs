namespace Shared.DataTransferObject
{
    public record EducationDto(Guid Id, string University, string Major, 
        int DegreeLevel, DateTime DateFrom, DateTime DateTo, string? Location);
    
}
