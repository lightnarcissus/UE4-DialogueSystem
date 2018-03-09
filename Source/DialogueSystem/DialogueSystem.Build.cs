//Copyright (c) 2016 Artem A. Mavrin and other contributors

using UnrealBuildTool;

public class DialogueSystem : ModuleRules
{
	public DialogueSystem(ReadOnlyTargetRules Target) : base (Target)
	{

		PrivateIncludePaths.AddRange(
			new string[] {"DialogueSystem/Private"});

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
                "UMG",
                "SlateCore",
                "Slate",
                "LevelSequence",
                "MovieScene",
								"AIModule",
                "GameplayTasks"
			}
		);
	}
}
