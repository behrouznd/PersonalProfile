namespace Shared.DataTransferObject
{
    public record EducationForCreationDto(string University, 
        string Major,
        int DegreeLevel, 
        DateTime DateFrom, 
        DateTime DateTo, 
        string Location);
     
}
