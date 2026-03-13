public abstract class Character
{
    public abstract string Name { get; }
    public abstract int Health { get; }
    public abstract int Mana { get; }
    public abstract int Attack { get; }
    public abstract int Defense { get; }
    public abstract int Speed { get; }
    public abstract string ImagePath { get; }

    public abstract string TakeAction();

    public virtual string GetStats()
    {
        return
            $"Stats\n" +
            $"HP: {Health}\n" +
            $"MP: {Mana}\n" +
            $"ATK: {Attack}\n" +
            $"DEF: {Defense}\n" +
            $"SPD: {Speed}\n";
    }
}

public class Fighter : Character
{
    public override string Name => "Fighter";
    public override int Health => 150;
    public override int Mana => 20;
    public override int Attack => 20;
    public override int Defense => 18;
    public override int Speed => 8;
    public override string ImagePath => "fighter.jpg";

    public override string TakeAction()
    {
        return "Fighter performs Heavy Slash!";
    }
}

public class Ranger : Character
{
    public override string Name => "Ranger";
    public override int Health => 100;
    public override int Mana => 40;
    public override int Attack => 30;
    public override int Defense => 10;
    public override int Speed => 18;
    public override string ImagePath => "ranger.jpg";

    public override string TakeAction()
    {
        return "Ranger shoots a precise arrow!";
    }
}

public class Wizard : Character
{
    public override string Name => "Wizard";
    public override int Health => 80;
    public override int Mana => 120;
    public override int Attack => 45;
    public override int Defense => 8;
    public override int Speed => 12;
    public override string ImagePath => "wizard.jpg";

    public override string TakeAction()
    {
        return "Wizard casts Fireball!";
    }
}

public class Rogue : Character
{
    public override string Name => "Rogue";
    public override int Health => 90;
    public override int Mana => 35;
    public override int Attack => 40;
    public override int Defense => 9;
    public override int Speed => 22;
    public override string ImagePath => "rogue.jpg";

    public override string TakeAction()
    {
        return "Rogue performs Backstab!";
    }
}

public class Cleric : Character
{
    public override string Name => "Cleric";
    public override int Health => 120;
    public override int Mana => 100;
    public override int Attack => 15;
    public override int Defense => 14;
    public override int Speed => 10;
    public override string ImagePath => "cleric.jpg";

    public override string TakeAction()
    {
        return "Cleric casts Healing Light!";
    }
}