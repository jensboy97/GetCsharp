namespace BossFight;

 
public class Character
{
    public string name;
    public int Health { get; set; }
    public int maxStrength;
    public int minStrength;
    public int maxStamina;
    public int stamina;
    
    public Character(string name, int health, int maxStrength, int minStrength,int maxStamina, int stamina)
    {
        this.name = name;
        Health = health;
        this.maxStrength = maxStrength;
        this.minStrength = minStrength;
        this.maxStamina = maxStamina;
        this.stamina = stamina;
    }

    public void Fight(Character opponent)
    {
        if (stamina > 0)
        {
            int dmg = GetStrength();
            opponent.Health -= dmg;
            Console.WriteLine($"{this.name} hit {opponent.name} with {dmg}\n" +
                              $" {opponent.name} now has {opponent.Health} health left");
            stamina -= 10;
            if (opponent.Health <= 0)
            {
                Console.WriteLine($"{opponent.name} has 0 health left\n" +
                                  $"{this.name} is the winner!");
            }
        }
        else
        {
            Recharge();
        }
    }

    public void Recharge()
    {
        Console.WriteLine($"{this.name} is recharging stamina");
        stamina = this.maxStamina;
    }

    public int GetStrength()
    {
        if (minStrength == maxStrength) return maxStrength;
        var rng = new Random();
        return rng.Next(minStrength, maxStrength + 1);
    }
}