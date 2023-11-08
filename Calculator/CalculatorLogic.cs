using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorLogic
    {
        private int _number1 = 0;
        private int _number2 = 0;
        private char _action = '\0';

        private TextBox _tb;


        public CalculatorLogic(TextBox tb)
        {
            _tb = tb;
            _tb.Text = "0";
        }

        public void AddNum(byte num)
        {
            if (_action == '\0')
            {
                if (_number1 < 1000000)
                {
                    if (_number1 >= 0) _number1 = _number1 * 10 + num;
                    else _number1 = _number1 * 10 - num;
                    _tb.Text = _number1.ToString();
                }
            }
            else
            {
                if (_number2 < 1000000)
                {
                    if (_number2 >= 0) _number2 = _number2 * 10 + num;
                    else _number2 = _number2 * 10 - num;
                    _tb.Text = _number2.ToString();
                }
            }
        }


        public void SetAction(char action)
        {
            _action = action;
        }

        public void Clear()
        {
            _tb.Text = "0";
            _number1 = _number2 = 0;
            _action = '\0';
        }

        public void Calculate()
        {
            switch (_action)
            {
                case '+':
                    _number1 += _number2;
                    break;
                case '-':
                    _number1 -= _number2;
                    break;
                case '*':
                    _number1 *= _number2;
                    break;
                case '/':
                    if (_number2 == 0)
                    {
                        _tb.Text = "Ошибка";
                        _number1 = _number2 = 0;
                        _action = '\0';
                        return;
                    }
                    _number1 /= _number2;
                    break;
            }
            _number2 = 0;
            _action = '\0';
            if (_number1 > 10000000)
            {
                _tb.Text = "Ошибка";
                _number1 = 0;
            }
            else _tb.Text = _number1.ToString();
        }
    }
}
