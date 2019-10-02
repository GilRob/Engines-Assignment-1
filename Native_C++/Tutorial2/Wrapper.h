#pragma once

#include "PluginSettings.h"
#include "FileManager.h"

#ifdef __cplusplus
extern "C"
{
#endif

	// Put your functions here
	
	PLUGIN_API void SavePosition(Vec3 uVec);

	PLUGIN_API void LoadPosition();

	PLUGIN_API Vec3 getVec();
	PLUGIN_API void setVec(Vec3 posVec);


#ifdef __cplusplus
}
#endif