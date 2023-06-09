public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Faculty { get; set; }
    public DateTime? DateLastReserve { get; set; }
    public int CantReservesLastMonth { get; set; }
    public List<Reserve> Reserves { get; set; }
}
