namespace PortfolioCore.Entities
{
    public class Icon
    {
        public int IconId { get; set; }
        public string IconClass { get; set; }
        public string IconName { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
    }
}
