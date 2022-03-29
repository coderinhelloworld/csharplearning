namespace csharpLearning.AbstractClass
{
    public interface IFruit
    {
        public decimal GetPrice();

        public string Name
        {
            get;
            set;
        }
    }
}