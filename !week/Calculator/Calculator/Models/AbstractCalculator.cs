namespace Calculator.Models
{
    public abstract class AbstractCalculator<T>
    {
        public abstract T Summarize(T input1, T input2);
        public abstract T Subtract(T input1,T input2);
        public abstract T Multiply(T input1,T input2);
        public abstract T Divide(T input1,T input2);
    }
}
