#include "FileManager.h"

//This function will write the saved values to a text file
void FileManager::WriteFile(std::string fileName)
{
	Vec3 temp;
	temp = getVec();
	//Open the file
	write.open(fileName, std::ofstream::app);
	//If the file is open
	if (write.is_open())
	{
		//Write each value to the file
		write <<temp.x << ",";
		write <<temp.y << ",";
		write << temp.z;
		//Close the file
		write.close();
	}
}

//This function will read the text file and assign the saved values to the players position
void FileManager::ReadFile(std::string fileName)
{
	float posVal;
	std::string line;
	//Open the file
	read.open(fileName);
	//std::string line;
	std::vector<std::vector<Vec3>> vectorVec;
	int i = 0;
	

	//If the file is open
	if (read.is_open())
	{
		//Go through each line in the file
		while (std::getline(read, line))
		{
			//Vec3 value;
			//std::stringstream ss(line);
			//vectorVec.push_back(std::vector<Vec3>());
			//
			//while (ss >> value)
			//{
			//	vectorVec[i].push_back(value);
			//}
			//++i;

			//Go through each line in the file and covert the string of the number into a float
			//if (counter == 0)
			//{
			//	posVal = std::stof(line);
			//	setX(posVal);
			//}
			//else if (counter == 1)
			//{
			//	posVal = std::stof(line);
			//	setY(posVal);
			//}
			//else if (counter == 2)
			//{
			//	posVal = std::stof(line);
			//	setZ(posVal);
			//}

			
			//Increment the counter to assign the values to the next variable
			//counter++;
		}
		//Close the file
		read.close();
	}
}

//Saves the values to variables and calls the writer
void FileManager::SavePosition(Vec3 uVec)
{
	//Store the values passed into the variables
	setVec(uVec);

	//Call the file writer
	WriteFile("save.txt");//, this);
}

//Calls the reader
void FileManager::LoadPosition()
{
	ReadFile("save.txt");
}

void FileManager::setVec(Vec3 uVec)
{
	holdVec = uVec;
}

Vec3 FileManager::getVec()
{
	return holdVec;
}
