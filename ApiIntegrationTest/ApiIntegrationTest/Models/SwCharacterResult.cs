namespace ApiIntegrationTest.Models
{
    public record SwCharacterResult
    {
        public string Name { get; init; }
        public string Height { get; init; }
        public IReadOnlyList<Uri> Films { get; init; }
    }
}