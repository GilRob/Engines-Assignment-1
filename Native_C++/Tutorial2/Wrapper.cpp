#include "Wrapper.h"

FileManager fileMan;

void SavePosition(float posX, float posY, float posZ, float id)
{
	return fileMan.SavePosition(posX, posY, posZ, id);
}

std::vector<Vec3> LoadPosition()
{
	return fileMan.LoadPosition();
}

float getX()
{
	return fileMan.getX();
}

float getY()
{
	return fileMan.getY();
}

float getZ()
{
	return fileMan.getZ();
}
