using System.Reflection.Metadata;

class Message(string id, string conversationId, Content content, User sender, DateTime timestamp)
{
    public string Id { get; } = validateString(id);
    public string ConversationId { get; } = validateString(conversationId);
    public Content Content { get; } = content;
    public User Sender { get; } = sender;
    public DateTime Timestamp { get; } = validateTimestamp(timestamp);

    public Message(string id, string conversationId, Content content, User sender) : this(id, conversationId, content, sender, DateTime.UtcNow){}
    
    private static DateTime validateTimestamp(DateTime timestamp)
    {
        if (timestamp > DateTime.UtcNow)
        {
            throw new ArgumentException("Timestamp cannot be in the future.");
        }
        return timestamp;
    }

    private static string validateString(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("String cannot be null or whitespace.");
        }
        return value;
    }
}