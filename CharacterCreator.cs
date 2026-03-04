public abstract class CharacterCreator
{
    public abstract Character FactoryMethod();
}

// ConcreteCreator
public class WarriorGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Warrior();
}

public class ArcherGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Archer();
}

public class WizardGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Wizard();
}
public class AssassinGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Assassin();
}