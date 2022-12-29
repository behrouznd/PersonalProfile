namespace Shared.DataTransferObject
{
    public record PersonalInfoDto(Guid Id, string Name, string Family, string Title,
        string Nationality, DateTime Birthday, int MaritalStatus, string Residence,
        string Phone, string Mobile, string Email, string Address, string Introduction,
        string PicProfile, IEnumerable<EducationDto> Educations);

}
