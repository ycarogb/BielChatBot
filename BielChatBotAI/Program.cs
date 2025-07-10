using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using OpenAI;

var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
var model = config["ModelName"];
var key = config["OpenAIKey"];

//Criando o client para o chatbot
var chatClient = new OpenAIClient(key).GetChatClient(model).AsIChatClient();

// Inserindo input com um contexto para o modelo de inteligência artificial
var chatHistory = new List<ChatMessage>
    {
        new ChatMessage(ChatRole.System, """
                                         Você é um entusiasta de caminhadas que ajuda as pessoas a descobrir trilhas divertidas em sua região.
                                         Você se apresenta ao cumprimentá-las pela primeira vez.
                                         Ao ajudar as pessoas, você sempre pede estas informações
                                         para embasar a recomendação de caminhada que você fornece:

                                         1. O local onde elas gostariam de caminhar
                                         2. Qual a intensidade da caminhada que elas buscam

                                         Você então fornecerá três sugestões de trilhas próximas, com duração variada
                                         após obter essas informações. Você também compartilhará um fato interessante sobre
                                         a natureza local nas trilhas ao fazer uma recomendação. Ao final da sua
                                         resposta, pergunte se há algo mais em que você possa ajudar.
                                         """)
    };
    
//Loop para obter input do usuário e carregar resposta da IA
while (true)
{
    //Obter prompt do usuário e adicionar ao histórico do chat
    Console.WriteLine("Seu prompt: ");
    var userPrompt = Console.ReadLine();
    chatHistory.Add(new ChatMessage(ChatRole.User, userPrompt));
    
    //Carrega resposta da IA e adiciona ao histórico do chat
    Console.WriteLine("Resposta da IA: ");
    var resposta = "";
    await foreach (var item in chatClient.GetStreamingResponseAsync(chatHistory))
    {
        Console.Write(item.Text);
        resposta += item.Text;
    }
    
    chatHistory.Add(new ChatMessage(ChatRole.Assistant, resposta));
    Console.WriteLine();
}