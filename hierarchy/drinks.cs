namespace hierarchy
{
     class drinks
    {
        private double cost_;
        private string name_;
        private int quantity_;
        public string discount;

        public drinks(string Name, double Cost, int Quantity)
        {
            name_ = Name;
            cost_ = Cost;
            quantity_ = Quantity;
        }
        
        public double GetCost()
        {
            return cost_;
        }
        public string GetName()
        {
            return name_;
        }
        public int GetQuantity()
        {
            return quantity_;
        }
        public virtual string Discount()
        {
            return discount;
        }
    }
}
