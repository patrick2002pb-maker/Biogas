using Mafi.Core.Mods;

public class BessereBiogasanlage : IMod
{
    public string Name => "Bessere Biogasanlage";
    public int Version => 1;
    public string Author => "patrick2002pb-maker";

    public void Initialize(IModContext context)
    {
        Console.WriteLine("Bessere Biogasanlage Mod loaded!");
    }

    public void PostLoad()
    {
        Console.WriteLine("Bessere Biogasanlage Mod post-load complete!");
    }
}
