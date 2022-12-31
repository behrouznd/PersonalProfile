namespace Shared.DataTransferObject
{
    public record PersonalInfoDto
    /*(Guid Id, string Name, string Family, string Title,
    string Nationality, DateTime Birthday, int MaritalStatus, string Residence,
    string Phone, string Mobile, string Email, string Address, string Introduction,
    string PicProfile, IEnumerable<EducationDto> Educations);*/
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Family { get; init; }
        public string? Title { get; init; }
        public string? Nationality { get; init; }
        public DateTime Birthday { get; init; }
        public int MaritalStatus { get; init; }
        public string? Residence { get; init; }
        public string? Phone { get; init; }
        public string? Mobile { get; init; }
        public string? Email { get; init; }
        public string? Address { get; init; }
        public string? Introduction { get; init; }
        public string? PicProfile { get; init; }
        public ICollection<ExperienceDto>? Experiences { get; init; }
        public ICollection<EducationDto>? Educations { get; init; }
        public ICollection<SocialMediaDto>? SocialMedias { get; init; }
        public ICollection<CertificateDto>? Certificates { get; init; }
    }

}
