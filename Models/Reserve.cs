public class Reserve
{
    public int Id { get; set; }
    public string Code { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public string Description { get; set; }
}
