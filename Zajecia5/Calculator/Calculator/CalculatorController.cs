using System;

namespace Test
{
    class CalculatorController
    {
        private CalculatorModel _model;

        public CalculatorController(CalculatorModel model)
        {
            _model = model;
        }

        public string CleanResult()
        {
            if (_model.Result == "0")
            {
                _model.LastOperation = Operation.None;
            }
            else
            {
                _model.Result = "0";
            }

            return _model.Result;
        }

        public string ComputeNumbers(string result)
        {
            _model.Result = result;
            if (_model.LastOperation == Operation.None)
            {
                return _model.Result;
            }
            Compute();
            _model.LastOperation = Operation.None;
            return _model.Result;
        }

        private void Compute()
        {
            switch (_model.LastOperation)
            {
                case Operation.None:
                    break;
                case Operation.Sum:
                    _model.LeftNumber += Int32.Parse(_model.Result);
                    break;
                case Operation.Substract:
                    _model.LeftNumber -= Int32.Parse(_model.Result);
                    break;
                case Operation.Multiply:
                    _model.LeftNumber *= Int32.Parse(_model.Result);
                    break;
                case Operation.Divide:
                    _model.LeftNumber /= Int32.Parse(_model.Result);
                    break;
            }

            _model.Result = _model.LeftNumber.ToString();
        }

        public string MakeOperation(string result, Operation operation)
        {
            _model.Result = result;
            _model.LeftNumber = int.Parse(_model.Result);
            if (_model.LastOperation == Operation.None)
            {
                _model.LastOperation = operation;
            }
            else
            {
                Compute();
                _model.LastOperation = operation;
            }

            return _model.Result;
        }

        public void ChangeOperation(Operation operation)
        {
            _model.LastOperation = operation;
        }
    }
}