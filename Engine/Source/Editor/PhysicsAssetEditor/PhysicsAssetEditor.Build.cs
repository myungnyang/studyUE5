// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PhysicsAssetEditor : ModuleRules
{
	public PhysicsAssetEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicIncludePaths.AddRange(
             new string[] {
                "Editor/UnrealEd/Public",
                "Editor/Persona/Public"
            }
        );

        PrivateIncludePaths.AddRange(
            new string[] {
                "Editor/PhysicsAssetEditor/Private",
                "Editor/PhysicsAssetEditor/Private/PhysicsAssetGraph",
            }
        );

        PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Core",
				"CoreUObject",
				"Engine",
                "InputCore",
				"RenderCore",
				"Slate",
				"SlateCore",
                "EditorStyle",
				"LevelEditor",
				"EditorFramework",
				"UnrealEd",
                "Kismet",
                "Persona",
                "SkeletonEditor",
                "GraphEditor",
                "AnimGraph",
                "AnimGraphRuntime",
                "AdvancedPreviewScene",
                "DetailCustomizations",
                "PinnedCommandList",
				"ToolMenus",
				"PhysicsCore",
				"PhysicsUtilities",
				"MeshUtilitiesCommon",
				"ApplicationCore",
			}
        );

		DynamicallyLoadedModuleNames.AddRange(
			new string[] {
				"MainFrame",
				"PropertyEditor",
                "MeshUtilities",
			}
		);
	}
}
