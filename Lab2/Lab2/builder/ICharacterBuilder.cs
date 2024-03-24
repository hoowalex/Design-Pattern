namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder BuildName(string name);

        ICharacterBuilder BuildPhysique(string physique);

        ICharacterBuilder BuildInventoryItem(string item);

        Character GetCharacter();
    }
}
