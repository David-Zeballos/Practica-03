public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Reserve> Reserves { get; set; }
}
