class TextContent
{
    public string Data { get; }
    public TextContent(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            throw new ArgumentException("Data cannot be null or empty", nameof(data));
        }
        Data = data;
    }
}