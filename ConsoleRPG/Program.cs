namespace ConsoleRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Player = new Hero("Você", 3, 15);

            Bandit N1 = new Bandit("Bandido n°1 ", 1, 5);
            Bandit N2 = new Bandit("Bandido n°2", 2, 8);

            Knight Paul = new Knight("Cavaleiro Paul", 3, 12);
            Knight Fred = new Knight("Cavaleiro Fred", 5, 15);

            Dragon WhiteDrag = new Dragon("Dragão branco", 7, 20, 2);
            Dragon RedDrag = new Dragon("Dragão vermelho", 8, 20, 3);
            Dragon SupremeDrag = new Dragon("Dragão supremo", 10, 25, 4);

            Story.BeforeFirstFight();
            Battle.WithBandit(Player, N1);
            Battle.WithBandit(Player, N2);

            Player.LevelUp();

            Story.BeforeKnights();
            Battle.WithKnight(Player, Paul);
            Battle.WithKnight(Player, Fred);

            Player.LevelUp();

            Story.BeforeDragons();
            Battle.WithDragon(Player, WhiteDrag);
            Battle.WithDragon(Player, RedDrag);
            Battle.WithDragon(Player, SupremeDrag);

            Story.TheEnd();
        }
    }
}