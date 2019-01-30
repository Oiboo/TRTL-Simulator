// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Trtl_SimulatorTarget : TargetRules
{
	public Trtl_SimulatorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Trtl_Simulator" } );
	}
}
