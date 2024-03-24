namespace Builder
{
    public class Director
    {
        public Character CreateCharacter(ICharacterBuilder builder, string name, string physique, string inventory)
        {
            return builder
                .BuildName(name)
                .BuildPhysique(physique)
                .BuildInventoryItem(inventory)
                .GetCharacter();
        }
    }
}
