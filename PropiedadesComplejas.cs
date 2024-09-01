var deathpool = new SuperHero();

deathpool.Id = 1;
deathpool.Name = "Deathpool";
deathpool.SecretIdent = "Wade wilson";
deathpool.SuperPowers = new [] {"Dance", "Fight", "Strong"};
deathpool.CanFly = false;
class SuperHero
{
    public int Id;
    public string Name;
    public string SecretIdent;
    public string City;
    public string[] SuperPowers;
    public bool CanFly;
}

//Creando clases complejas

class SuperPoder
{
    public  string Name;

    public  string Description;

    public PowerLevel Level;
}

class PowerLevel {
    LevelOne,
    LevelTwo,
    LevelThree
}