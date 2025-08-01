namespace BielChatBot.Models.Entities.Dtos;

public class OutputDto
{
    public OutputDto(string response)
    {
        Value = response;
    }

    public string Value { get; set; }
}