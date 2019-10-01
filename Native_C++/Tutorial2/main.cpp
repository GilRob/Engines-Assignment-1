#include "FileManager.h"

//#include <iostream>
//#include <fstream>

/*void main()
{
	//SimpleClass temp;
	FileManager* filer = new FileManager();
	std::ofstream write;

	filer->SavePosition(6.0f, 0.0f, 22.5f);

	filer->setX(0.0f);
	filer->setY(0.2f);
	filer->setZ(0.8f);

	std::cout << filer->getX() << filer->getY() << filer->getZ() << std::endl;

	filer->ReadFile("save.txt");

	std::cout << filer->getX() << filer->getY() << filer->getZ() << std::endl;

	//filer->WriteFile("save.txt", filer);

	/*write.open("save.txt");
	if (write.is_open())
	{
		write << temp.getX() << "\n";
		write << temp.getY() << "\n";
		write << temp.getZ() << "\n";

		write.close();
	}*/

	//filer.WriteFile("save.txt", temp);


//}