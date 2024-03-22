namespace money
{
    public interface IMoney
    {
        void SetMoney(int wholePart, int fractionalPart);

        void PrintAmount();

        int GetWholePart();

        int GetFractionalPart();

    }

}
