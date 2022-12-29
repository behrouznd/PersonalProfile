namespace Shared.DataTransferObject
{
    public record CertificateDto(Guid Id, string Title, string Issuer, DateTime DateIssued);
}
