#include "Wrapper.h"

FileManager fileMan;

void SavePosition(Vec3 uVec)
{
	return fileMan.SavePosition(uVec);
}

void LoadPosition()
{
	return fileMan.LoadPosition();
}

Vec3 getVec()
{
	return fileMan.getVec();
}

void setVec(Vec3 uVec)
{
	return fileMan.setVec(uVec);
}