// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "State_Machine.h"

#define LOCTEXT_NAMESPACE "FState_MachineModule"

void FState_MachineModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void FState_MachineModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FState_MachineModule, State_Machine)