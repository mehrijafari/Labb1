
Console.WriteLine("Skriv in en valfri sträng med siffror och bokstäver: ");

string input = Console.ReadLine();
Console.WriteLine();

long sum = 0;

for (int i = 0; i < input.Length; i++)
{
	string validString = string.Empty;
	char firstChar = input[i];	
	validString += firstChar;


    for (int j = i + 1; j < input.Length; j++)
	{
		char matchedChar = input[j];


		if (char.IsDigit(matchedChar) == true)
		{
			validString += matchedChar;
		}
		else
		{
			break;
		}
		
		if (firstChar == matchedChar)
		{
			
            Console.Write(input[0..i]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(validString);
            Console.ResetColor();
            Console.WriteLine(input[(j + 1)..]);
			sum += long.Parse(validString);

			break;
        }

	}

    
}

Console.WriteLine($"\nTotal= {sum}");
