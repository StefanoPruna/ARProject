using UnrealBuildTool;

public class ARProjectTarget : TargetRules
{
	public ARProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARProject");
	}
}
