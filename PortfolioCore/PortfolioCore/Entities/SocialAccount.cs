namespace PortfolioCore.Entities
{
    public class SocialAccount
    {
        public int SocialAccountId { get; set; }
        public string SocialUrl { get; set; }
       

        public int IconId { get; set; }
        public Icon Icon { get; set; }
    }
}
