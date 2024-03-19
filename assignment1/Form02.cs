using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);
                string selectedOperator = operatorComboBox.SelectedItem.ToString();

                double result = Calculate(num1, num2, selectedOperator);

                resultLabel.Text = "结果: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入有效的数字！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生未知错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Calculate(double num1, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new ArgumentException("除数不能为零");
                default:
                    throw new ArgumentException("无效的运算符");
            }
        }
    }
}
