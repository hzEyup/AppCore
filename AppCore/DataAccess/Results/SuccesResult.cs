
using AppCore.DataAccess.Results.Bases;

namespace AppCore.DataAccess.Results
{
    public class SuccesResult : Result
    {
        public SuccesResult(string message) : base(true, message)
        {

        }
        public SuccesResult() : base(true, "")
        {

        }
    }

}


/*e
 * SuccesResult result = new SuccesResult("Operation succesful.");
 * Result result = new SuccesResult();
 *
 * if(result.IsSuccesful)//result.IsSuccesful: false 
 * {
 * ...
 * }
 * else
 * {
 * (burası çalışır)
 * 
 */