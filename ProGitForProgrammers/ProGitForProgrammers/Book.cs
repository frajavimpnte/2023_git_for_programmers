public class Book
{
    public string Title { get; set; }
    public List<string> Authors { get; set; }

    private DateTime publicationDate;

    public DateTime GetPublicationDate()
    {
        return publicationDate;
    }

    public void SetPublicationDate(DateTime value) => publicationDate = value;
}
