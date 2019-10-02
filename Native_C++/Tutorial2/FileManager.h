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
	void SavePosition(Vec3 uVec);

	//Calls the reader
	void LoadPosition();

	//Setters
	void setVec(Vec3 posVec);

	//Getters
	Vec3 getVec();

	//Variables to hold the position
	Vec3 holdVec;

private:
	
	std::ofstream write;
	std::ifstream read;
};