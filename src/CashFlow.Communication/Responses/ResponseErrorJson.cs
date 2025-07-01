namespace CashFlow.Communication.Responses
{
    public class ResponseErrorJson
    {
        public List<string> ErrorMessages { get; set; }

        public ResponseErrorJson(string errorMessages)
        {
            ErrorMessages = new List<string> { errorMessages };
        }

        public ResponseErrorJson(List<string> errorMessage)
        {
            ErrorMessages = errorMessage;
        }
    }
}
