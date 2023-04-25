namespace STI.BAL.Models.Requests
{
    public class BaseRequest
    {
        public Guid UserID { get; set; }
        public string AccessToken { get; set; }
        public string FunctionID { get; set; }
        public string Status { get; set; }
    }
}
