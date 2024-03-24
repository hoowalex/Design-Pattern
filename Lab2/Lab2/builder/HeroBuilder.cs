namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character hero;

        public HeroBuilder()
        {
            this.hero = new Character();
        }

        public ICharacterBuilder BuildName(string name)
        {
            hero.SetName(name);
            return this;
        }

        public ICharacterBuilder BuildPhysique(string physique)
        {
            hero.SetPhysique(physique);
            return this;
        }

        public ICharacterBuilder BuildInventoryItem(string item)
        {
            hero.AddInventoryItem(item);
            return this;
        }

        public Character GetCharacter()
        {
            return hero;
        }
    }
}