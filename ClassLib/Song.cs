
public record Song
{
    public string Name { get; set; }
    public string Path { get; set; }

    public Song(string name, string path)
    {
        Name = name;
        Path = path;
    }
}