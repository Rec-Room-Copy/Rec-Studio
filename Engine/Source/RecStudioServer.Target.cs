using BuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class RecStudioServerTarget : TargetRules
{
    public RecStudioServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.Add("RecRoomCopyGame");
	}
}
