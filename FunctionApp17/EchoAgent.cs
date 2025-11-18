using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using System.Text.Json;

namespace FunctionApp17;

internal class EchoAgent : AIAgent
{
    public override AgentThread DeserializeThread(JsonElement serializedThread, JsonSerializerOptions? jsonSerializerOptions = null)
    {
        return new EchoAgentThread(serializedThread, jsonSerializerOptions);
    }

    public override AgentThread GetNewThread()
    {
        return new EchoAgentThread();
    }

    public override Task<AgentRunResponse> RunAsync(IEnumerable<ChatMessage> messages, AgentThread? thread = null, AgentRunOptions? options = null, CancellationToken cancellationToken = default)
    {
        var lastMessage = messages.Last();
        var response = new AgentRunResponse(new ChatMessage(ChatRole.Assistant, lastMessage.Text));
        return Task.FromResult(response);
    }

    public override async IAsyncEnumerable<AgentRunResponseUpdate> RunStreamingAsync(IEnumerable<ChatMessage> messages, AgentThread? thread = null, AgentRunOptions? options = null, CancellationToken cancellationToken = default)
    {
        var response = await RunAsync(messages, thread, options, cancellationToken);
        foreach (var update in response.ToAgentRunResponseUpdates())
        {
            yield return update;
        }
    }

    class EchoAgentThread : InMemoryAgentThread
    {
        public EchoAgentThread()
        {
        }

        public EchoAgentThread(JsonElement serializedThread, JsonSerializerOptions? jsonSerializerOptions) : base(serializedThread, jsonSerializerOptions)
        {
            
        }
    }
}
