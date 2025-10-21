using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OllamaSharp;
using AIAgentTest1.Services;
using Microsoft.Extensions.Configuration;

class Program
{
    static async Task Main(string[] args)
    {
        // Build the configuration provider
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("config.json", optional: false, reloadOnChange: true)
            .Build();

        // Read Ollama base url from the configuration
        string baseUrl = configuration["OllamaSettings:BaseUrl"]!;

        // Read Ollama model from the configuration
        string modelName = configuration["OllamaSettings:ModelName"]!;

        // Create Ollama client - local server
        var ollamaBaseUri = new Uri(baseUrl);
        // "llama3.2:3b" can be changed with another local model, please install it before with: ollama pull <model_name>
        using OllamaApiClient chatClient = new OllamaApiClient(ollamaBaseUri, modelName);

        // Tool creation
        var weatherTool = AIFunctionFactory.Create(
            (Func<string, Task<string>>)WeatherService.GetCurrentWeatherByCityAsync
        );

        Console.WriteLine("Please write your language:");
        var language = Console.ReadLine();

        Console.WriteLine("Please write your location:");
        var location = Console.ReadLine();


        // Agent creation
        var agent = new ChatClientAgent(
            chatClient,  // IChatClient implementation (Ollama)
            name: "MyFirstOllamaAgent",
            instructions: $"""
            Yo are a weather assistant. 
            You can use the tool 'GetCurrentWeatherByCityAsync' to obtain  the weather of a city.
            Answer concisely and in {language}.
            """,
            tools: [weatherTool] // Tool created before
        );

        // Agent call execution
        var userMessage = $"What's the weather in {location}?";
        var answer = await agent.RunAsync(userMessage);

        Console.WriteLine("AGENT ANSWER:");
        Console.WriteLine(answer);
    }
}
