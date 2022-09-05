
using AppCore.DataAccess.Results.Bases;

namespace AppCore.DataAccess.Results
{
    internal class ErrorResault:Result
    {
        public ErrorResault(string message) : base(false, message)
        {

        }
        public ErrorResault() : base(false, "")
        {

        }
    }
}
/*
 Result result = new ErrorResult("Record exists in database !");
 if ( result.IsSucessful)//result.IsSuccesful : true 
{
 ....
 }
 else 
{
...(burası çalışır)
}
