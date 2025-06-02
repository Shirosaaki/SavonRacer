using UnrealBuildTool;

public class SavonRancer2Target : TargetRules
{
	public SavonRancer2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SavonRancer2");
	}
}
