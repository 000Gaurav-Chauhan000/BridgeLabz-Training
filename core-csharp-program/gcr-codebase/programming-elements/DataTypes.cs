using System;

class DataTypes{
	static void Main(){
		int firstNumber = 37; //int data type for Integer value

		float firstDecimal = 19.00f; // float data type for floating point values

		bool firstBoolean = true; // bool datatype for Boolean values

		char firstCharacter = 'w'; // char for characters

		byte firstByte = 23; // byte data type for byte values
		
		short firstShort = 29; // short data type for short values

		Console.WriteLine("This is an integer value : " + firstNumber);
		Console.WriteLine("This is a float value : " + firstDecimal);
		Console.WriteLine("This is a boolean value : " +firstBoolean);
		Console.WriteLine("This is a char value : " + firstCharacter);
		Console.WriteLine("This is a byte value : " + firstByte);
		Console.WriteLine("This is a short value : " + firstShort);
		
		//Type Casting 

		//Implicit type casting 

		int myInt = 43;
		Console.WriteLine("Before type casting : "+myInt);
		double myDouble = myInt;

		Console.WriteLine("After Type casting"+ myDouble);

		// Explicit TypeCasting 
		 myDouble = 19.13;
		 Console.WriteLine("Before type casting :"+ myDouble);

		 myInt = (int) myDouble;
		 Console.WriteLine("After Type casting :" + myInt);

	}
}
