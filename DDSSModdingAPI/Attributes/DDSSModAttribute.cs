namespace DDSSModdingAPI.Attributes;


[System.AttributeUsage(System.AttributeTargets.Class)]
public class DDSSModAttribute : System.Attribute
{
    public DDSSModType ModType;

    public DDSSModAttribute(DDSSModType modType)
    {
        ModType = modType;
    }
}