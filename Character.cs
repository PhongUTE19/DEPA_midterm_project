public abstract class Character
{
    public abstract string Name { get; }
    public abstract int Health { get; }
    public abstract int Attack { get; }
    public abstract string ImagePath { get; }

    public virtual string GetStats()
    {
        return $"HP: {Health} | ATK: {Attack}";
    }
}

public class Warrior : Character
{
    public override string Name => "Warrior";
    public override int Health => 150;
    public override int Attack => 20;
    public override string ImagePath => "warrior.png";
}

public class Archer : Character
{
    public override string Name => "Archer";
    public override int Health => 100;
    public override int Attack => 30;
    public override string ImagePath => "archer.png";
}

public class Wizard : Character
{
    public override string Name => "Wizard";
    public override int Health => 80;
    public override int Attack => 45;
    public override string ImagePath => "wizard.png";
}

public class Assassin : Character
{
    public override string Name => "Assassin";
    public override int Health => 90;
    public override int Attack => 40;
    public override string ImagePath => "assassin.png";
}