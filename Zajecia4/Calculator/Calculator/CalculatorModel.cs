namespace Test
{
    class CalculatorModel
    {
        public string Result { get; set; }
        public double LeftNumber { get; set; }
        public Operation LastOperation { get; set; }

        public CalculatorModel()
        {
            Result = "0";
            LastOperation = Operation.None;
        }
    }
}
