#region Interfaces and classes of Tables,Sofas and CofeeTables

public interface IChair
{
    public void HasLegs();
    public void SitOn();
}

public class VictorianChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Chair has 2 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Victorian Chair !");
    }
}

public class ModernChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("Modern Chair has 2 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Modern Chair !");
    }
}


public interface ICofeeTable
{
    public void HasLegs();
    public void SitOn();
}

public class VictorianCofeeTable : ICofeeTable
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Cofee table has 4 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Victorian Cofee Table");
    }
}

public class ModernCofeeTable : ICofeeTable
{
    public void HasLegs()
    {
        Console.WriteLine("Modern Cofee table has 4 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Modern Cofee Table");
    }
}

public interface ISofa
{
    public void HasLegs();
    public void SitOn();
}

public class VictorianSofa : ISofa
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Sofa has 4 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Victorian Sofa !");
    }
}

public class ModernSofa : ISofa
{
    public void HasLegs()
    {
        Console.WriteLine(" Modern Sofa has 4 legs !");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitted On Modern Sofa !");
    }
}
#endregion



#region Abstract Factory Part

public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ICofeeTable CreateCoffeeTable();
    public ISofa CreateSofa();
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new VictorianChair();

    public ICofeeTable CreateCoffeeTable() => new VictorianCofeeTable();

    public ISofa CreateSofa() => new VictorianSofa();
}
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ModernChair();

    public ICofeeTable CreateCoffeeTable() => new ModernCofeeTable();

    public ISofa CreateSofa() => new ModernSofa();
}

#endregion