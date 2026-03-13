public abstract class CharacterCreator
{
    public abstract Character FactoryMethod();
}

public class FighterGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Fighter();
}

public class RangerGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Ranger();
}

public class WizardGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Wizard();
}
public class RogueGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Rogue();
}
public class ClericGenerator : CharacterCreator
{
    public override Character FactoryMethod() => new Cleric();
}