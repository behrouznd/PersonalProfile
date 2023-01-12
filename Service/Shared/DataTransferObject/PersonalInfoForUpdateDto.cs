namespace Shared.DataTransferObject
{
    public record PersonalInfoForUpdateDto(
        string Name,
        string Family,
        string Title,
        string Nationality,
        DateTime Birthday,
        int MaritalStatus,
        string Residence,
        string Phone,
        string Mobile,
        string Email,
        string Address,
        string Introduction,
        string PicProfile);
}
