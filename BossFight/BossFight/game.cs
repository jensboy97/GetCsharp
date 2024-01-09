namespace BossFight;

public class game
{
   static Random rand = new Random();
   static int bossAttack = rand.Next(1, 31);
    public Character boss = new Character("boss",250, 25, 0, 10, 10);
    public Character hero = new Character("hero", 100, 20,20, 30, 30);

    public void startGame()
    {
        while (hero.Health > 0 && boss.Health > 0)
        {
            hero.Fight(boss);
            if (boss.Health <= 0) break;
            boss.Fight(hero);
            if (hero.Health <= 0) break;
        }
    }
}