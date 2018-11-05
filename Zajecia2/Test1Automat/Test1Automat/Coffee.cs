namespace Test1Automat
{
    class Coffee
    {
        private bool withMilk;
        private int howManySugar;

        public void AddMilk()
        {
            withMilk = true;
        }

        public void AddSugar(int quantity)
        {
            howManySugar = quantity;
        }

        public bool CheckIfWithMilk()
        {
            return withMilk;
        }

        public int GetHowManySugar()
        {
            return howManySugar;
        }
    }
}
