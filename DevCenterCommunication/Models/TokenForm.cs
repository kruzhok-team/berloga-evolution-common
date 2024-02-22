namespace DevCenterCommunication.Models;

using System.ComponentModel.DataAnnotations;
using DevCenterCommunication;

public class TokenForm
{
    [Required]
    [MaxLength(CommunicationConstants.MAXIMUM_TOKEN_LENGTH)]
    public string Token { get; set; } = string.Empty;
}
