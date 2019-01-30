// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Trtl_SimulatorEditorTarget : TargetRules
{
	public Trtl_SimulatorEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Trtl_Simulator" } );
	}
}
