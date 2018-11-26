using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorModel _model;
        private CalculatorController _controller;
        private bool _isEnteringDigitsMode;
        public MainWindow()
        {
            InitializeComponent();
            _model = new CalculatorModel();
            _isEnteringDigitsMode = true;
            _controller = new CalculatorController(_model);
        }

        private void AddDigitToResult(int digit)
        {
            if (!_isEnteringDigitsMode)
            {
                Result.Content = digit.ToString();
                _isEnteringDigitsMode = true;
                return;
            }

            var text = (string) Result.Content;
            if (text == "0")
            {
                Result.Content = digit.ToString();
            }
            else
            {
                Result.Content = text + digit.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(3);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(4);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(5);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(6);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(7);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(8);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(9);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            AddDigitToResult(0);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (_isEnteringDigitsMode == false)
            {
                _controller.ChangeOperation(Operation.Sum);
                return;
            }
            Result.Content = _controller.MakeOperation((string)Result.Content, Operation.Sum);
            _isEnteringDigitsMode = false;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (_isEnteringDigitsMode == false)
            {
                _controller.ChangeOperation(Operation.Substract);
                return;
            }
            Result.Content = _controller.MakeOperation((string) Result.Content, Operation.Substract);
            _isEnteringDigitsMode = false;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (_isEnteringDigitsMode == false)
            {
                _controller.ChangeOperation(Operation.Multiply);
                return;
            }
            Result.Content = _controller.MakeOperation((string)Result.Content, Operation.Multiply);
            _isEnteringDigitsMode = false;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (_isEnteringDigitsMode == false)
            {
                _controller.ChangeOperation(Operation.Divide);
                return;
            }
            Result.Content = _controller.MakeOperation((string)Result.Content, Operation.Divide);
            _isEnteringDigitsMode = false;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (_isEnteringDigitsMode == false)
            {
                return;
            }
            Result.Content = _controller.ComputeNumbers((string)Result.Content);
            _isEnteringDigitsMode = false;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Result.Content = _controller.CleanResult();
            _isEnteringDigitsMode = true;
        }
    }
}
