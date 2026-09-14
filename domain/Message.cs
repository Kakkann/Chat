using System.Reflection.Metadata;

class Message(string id, string conversationId, Content content, User sender, DateTime timestamp)
{
    public string Id { get; } = id;
    public string ConversationId { get; } = conversationId;
    public Content Content { get; } = content;
    public User Sender { get; } = sender;
    public DateTime Timestamp { get; } = timestamp;

    public Message(string id, string conversationId, Content content, User sender) : this(id, conversationId, content, sender, DateTime.Now){}
    
}