using Cocona;

namespace Tholus.Console;

public class Mods {

    [Command("add", Description = "Adds a mod from a source to the installation")]
    public void Add(ModSourceParameters mod, InstallParameters install) {
        System.Console.WriteLine($"TODO: Add new mod: '{install}' '{mod}'");
    }

    [Command("remove", Description = "Removes a mod from an installation")]
    public void Remove(ModParameters mod, InstallParameters install) {
        System.Console.WriteLine($"TODO: Remove mod: '{install}' '{mod}'");
    }

    [Command("list", Description = "List all mods of an installation")]
    public void List(InstallParameters install) {
        System.Console.WriteLine($"TODO: List mods: '{install}'");
    }

    [Command("enable", Description = "Enable mods of an installation")]
    public void Enable(ModParameters mod, InstallParameters install) {
        System.Console.WriteLine($"TODO: Enable mod: '{install}' '{mod}'");
    }

    [Command("disable", Description = "Disables mods of an installation")]
    public void Disable(ModParameters mod, InstallParameters install) {
        System.Console.WriteLine($"TODO: Disable mod: '{install}' '{mod}'");
    }

    [Command("create", Description = "Creates a new mod using a template for an installation")]
    public void Create(ModParameters mod, [Argument(Description = "Template for the mod")] string template, InstallParameters install) {
        System.Console.WriteLine($"TODO: Create mod: '{install}' '{template}' '{mod}'");
    }

    [Command("build", Description = "Builds a mod's code for an installation")]
    public void Build(ModParameters mod, InstallParameters install) {
        System.Console.WriteLine($"TODO: Build mod: '{install}' '{mod}'");
    }

    [Command("purge", Description = "Purges outdated or implicitly-installed mods of an installation")]
    public void Purge(InstallParameters install, bool outdated, bool implicitlyInstalled) {
        System.Console.WriteLine($"TODO: Purge mods: '{install}' Outdated: '{outdated}' ImplicityInstalled: {implicitlyInstalled}");
    }
}
