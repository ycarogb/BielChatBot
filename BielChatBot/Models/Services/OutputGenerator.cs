using BielChatBot.Models.Entities.Dtos;
using BielChatBot.Models.Services.Base;
using BielChatBot.Models.Services.Interfaces;
using Microsoft.Extensions.AI;
using OpenAI;

namespace BielChatBot.Models.Services;

public class OutputGenerator : IOutputGenerator
{
    public async Task<OutputDto> GenerateAsync(string input)
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        var model = config["ModelName"];
        var key = config["OpenAIKey"];

        //Criando o client para o chatbot
        var chatClient = new OpenAIClient(key).GetChatClient(model).AsIChatClient();

        // Inserindo input com um contexto para o modelo de inteligência artificial
        var chatHistory = new List<ChatMessage>
        {
            new ChatMessage(ChatRole.System, PromptInicial.Text)
        };

//Loop para obter input do usuário e carregar resposta da IA
        while (true)
        {
            //Obter prompt do usuário e adicionar ao histórico do chat
            chatHistory.Add(new ChatMessage(ChatRole.User, input));

            //Carrega resposta da IA e adiciona ao histórico do chat
            var resposta = "";
            await foreach (var item in chatClient.GetStreamingResponseAsync(chatHistory))
            {
                resposta += item.Text;
            }

            chatHistory.Add(new ChatMessage(ChatRole.Assistant, resposta));

            var result = new OutputDto(resposta);
            return result;
        }
    }
}