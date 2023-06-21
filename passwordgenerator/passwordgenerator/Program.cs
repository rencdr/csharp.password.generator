using System;

class PasswordGenerator
{
	static void Main()
	{
		Console.WriteLine("Welcome to the Password Generator!");
		Console.WriteLine("----------------");

		Console.Write("Please enter a password: ");
		string password = Console.ReadLine();

		string generatedPassword = GeneratePassword(password);

		Console.WriteLine("Generated Password: " + generatedPassword);

		Console.WriteLine("----------------");
		Console.WriteLine("Press any key to exit the program.");
		Console.ReadKey();
	}

	static string GeneratePassword(string password)
	{
		Random random = new Random();

		string updatedPassword = "";

		foreach (char c in password)
		{
			switch (c)
			{
				case 'e':
					updatedPassword += "3";
					break;
				case 'a':
					updatedPassword += "@";
					break;
				case 'l':
					updatedPassword += "/";
					break;
				case 'b':
					updatedPassword += "8";
					break;
				case 'i':
					updatedPassword += "1";
					break;
				case 'g':
					updatedPassword += "6";
					break;
				case 's':
					updatedPassword += "$";
					break;
				default:
					int randomCase = random.Next(2);
					if (char.IsLower(c) && randomCase == 0)
					{
						updatedPassword += char.ToUpper(c);
					}
					else if (char.IsUpper(c) && randomCase == 0)
					{
						updatedPassword += char.ToLower(c);
					}
					else
					{
						updatedPassword += c;
					}
					break;
			}

			int symbolProbability = random.Next(4);
			if (symbolProbability == 0)
			{
				updatedPassword += ".";
			}
			else if (symbolProbability == 1)
			{
				updatedPassword += "_";
			}
		}

		return updatedPassword;
	}
}
