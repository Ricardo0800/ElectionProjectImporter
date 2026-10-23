public class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int CandidateId { get; set; }

    public List<Topic> Topics { get; set; }
}