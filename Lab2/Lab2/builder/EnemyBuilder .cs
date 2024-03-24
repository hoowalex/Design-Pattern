namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character enemy;

        public EnemyBuilder()
        {
            this.enemy = new Character();
        }

        public ICharacterBuilder BuildName(string name)
        {
            enemy.SetName(name);
            return this;
        }

        public ICharacterBuilder BuildPhysique(string physique)
        {
            enemy.SetPhysique(physique);
            return this;
        }

        public ICharacterBuilder BuildInventoryItem(string item)
        {
            enemy.AddInventoryItem(item);
            return this;
        }

        public Character GetCharacter()
        {
            return enemy;
        }
    }
}
