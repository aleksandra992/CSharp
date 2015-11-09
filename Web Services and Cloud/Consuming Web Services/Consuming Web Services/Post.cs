namespace Consuming_Web_Services
{
    public class Post
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public int UserId { get; set; }

        public int Id { get; set; }

        public string User { get; set; }

        public override string ToString()
        {
            return string.Format("Post title: {0}\n Body: {1} \n Posted by:{2}", this.Title, this.Body, this.User);
        }
    }
}
