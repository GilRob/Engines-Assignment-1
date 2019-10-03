#pragma once
#include "PluginSettings.h"

#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <sstream>

struct Vec3
{
	float x;
	float y;
	float z;
};

class PLUGIN_API FileManager
{
public:

	//This function will write the saved values to a text file
	void WriteFile(std::string fileName);
	//This function will read the text file and assign the saved values to the players position
	void ReadFile(std::string fileName);

	//Saves the values to variables and calls the writer
	void SavePosition(float posX, float posY, float posZ);

	//Calls the reader
	void LoadPosition();

	//Setters
	void setX(float posX);
	void setY(float posY);
	void setZ(float posZ);

	//Getters
	float getX();
	float getY();
	float getZ();

	//Variables to hold the position
	float X;
	float Y;
	float Z;

	std::vector<Vec3> myVecs;

private:

	std::ofstream write;
	std::ifstream read;
};