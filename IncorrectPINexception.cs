namespace ConsoleApp1
{
    class IncorrectPINexception : Exception
    {
        public string Message { get; set; }

        public IncorrectPINexception(string message) : base(message)
        {
            Message = message;
        }
    }
}
