// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class strashiirka : ModuleRules
{
	public strashiirka(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"strashiirka",
			"strashiirka/Variant_Horror",
			"strashiirka/Variant_Horror/UI",
			"strashiirka/Variant_Shooter",
			"strashiirka/Variant_Shooter/AI",
			"strashiirka/Variant_Shooter/UI",
			"strashiirka/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
