using BielChatBot.Models.Entities.Dtos;

namespace BielChatBot.Models.Services.Interfaces;

public interface IOutputGenerator
{
    public Task<OutputDto> GenerateAsync(string input);
}