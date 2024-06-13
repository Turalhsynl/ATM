namespace ConsoleApp1
{
    class notEnoughMoneyException : Exception
    {
        public string Message { get; set; }

        public notEnoughMoneyException(string message) : base(message)
        {
            Message = message;
        }
    }
    
}
