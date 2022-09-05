namespace AppCore.DataAccess.Results.Bases
{
    public class Result
    {
        public bool IsSuccesful { get; set; }
        public string Message { get; set; }
        public Result(bool isSuccesful, string message)
        {
            IsSuccesful = isSuccesful;
            Message = message;
        }
    }
}
/*Result result = new Result
 * {
 * IsSuccesful = true,
 * Message ="Operation succesful."
 * };
 Result result = new Result(true, "Operation suceesful.");
 */