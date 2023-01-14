namespace IDArray
{
    class Array
    {
        string firstName;
        string lastName;
        string dateOfBirth;
        string number;
        string address;
        Random generator = new Random();

        string[] FirstNames = new string[] { "John", "Dave", "Charlie", "Damian", "Bob", "Finn", "Finley", "James", "Issac", "Matthew" };
        string[] LastNames = new string[] { "Doe", "Wiker", "Smith", "Radcliff", "Reacher", "Marns", "Shepard", "Elmes", "McClure", "Hopkins" };
        string[] Dates = new string[] { "11/12/2015", "01/01/2001", "11/11/1111", "12/5/2023", "06/03/2010", "10/11/1976", "31/12/2022", "25/12/2009", "31/01/2005", "22/03/2019" };
        string[] Numbers = new string[] { "+44 789365284", "+44 7556473267", "+44 7123456789", "+44 700000000", "+44 765897356", "+44 777777777", "+44 756789564", "+44 745348565", "+44 746396433", "+44 755845779" };
        string[] Addresses = new string[] { "9 Haw Street, Wotton-Under-Edge", "135 Cherwell Drive, Walsall", "261 Manchester Road East, Little Hulton", "66 Bridgnorth Drive, Clifton", "9 Ash Avenue, Kirkham", "7 Far Lawrence, Moulsoe", "32 Lansdowne Drive, Poringland", "Ashleigh, Davidstow", "Springs, Pinfold Hill, Curbar", "3 Mount Road, Rowley Regis" };

        static void Main(string[] args)
        {
            Array a = new Array();
            a.Randomise();
            string[,] s = { { "First Name: " + a.firstName, "  Last Name: " + a.lastName }, { "DOB: " + a.dateOfBirth, "   Num: " + a.number }, { "Address: " + a.address, "" } };
            Print2DArray(s);
            Console.WriteLine();

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < s.GetLength(0); i++)
                {
                    for (int j = 0; j < s.GetLength(1); j++)
                    {
                        writer.Write(s[i, j]);
                    }
                    writer.WriteLine();
                }
            }
        }


        static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        void Randomise()
        {
            firstName = FirstNames[generator.Next(0, 9)];
            lastName = LastNames[generator.Next(0, 9)];
            dateOfBirth = Dates[generator.Next(0, 9)];
            number = Numbers[generator.Next(0, 9)];
            address = Addresses[generator.Next(0, 9)];
        }
    }
}