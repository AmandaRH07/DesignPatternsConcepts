namespace Adapter
{
    public class Token
    {
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibm" +
            "FtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.S6wNWnB_avwLFLB6MyokjlQsRCblcpr_HK2ILcVJJ0E";
    
        public string GetToken()
        {
            return token;
        }
    }
}