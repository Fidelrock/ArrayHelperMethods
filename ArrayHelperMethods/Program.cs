// See https://aka.ms/new-console-template for more information

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Select the ARRAY helper method you wish to run: \n\r1: Sorting\n\r2: Reversing\n\r3: Clearing\n\r4: Resizing\n\r5: Reversing a string\n\r6: Revision Exercise\n\r0: Exit");

string selectedOption = Console.ReadLine()?? string.Empty;

if (selectedOption != null)
{
    switch (selectedOption)
    {
        case "1":
            sortingArray();
            break;

        case "2":
            reversingArray();
            break;

        case "3":
            clearingArray();
            break;

        case "4":
            resizingArray();
            break;
            case "5":
            reverseString();
                break;
            case "6":
            revisionExerciseArrays();
            break;
        case "0":
            Console.WriteLine("You selected option 0");
            break;
        default:
            Console.WriteLine("Unknown Option");
            break;
    }
}

void sortingArray()
{
   
    Console.WriteLine("Before Sorting...");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }

    Console.WriteLine("After Sorting...");

    Array.Sort(pallets);

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }

    Console.WriteLine("");
}

void reversingArray()
{
    Console.WriteLine("Before Reversing...");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }
    Console.WriteLine(" After Reversing...");

    Array.Reverse(pallets);

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }
}
void clearingArray()
{

    Console.WriteLine("");
    Console.WriteLine($"Before: {pallets[0].ToLower()}");
    Array.Clear(pallets, 0, 2);
    if (pallets[0] != null)
    {
        Console.WriteLine($"After: {pallets[0].ToLower()}");
    }

    Console.WriteLine($"Clearing 2...Count: {pallets.Length}");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }
}
void resizingArray(){

    Console.WriteLine($"Resizing 6... Count: {pallets.Length}");
    Array.Resize(ref pallets, 6);

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"--{pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3... Count: {pallets.Length}");

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }
}

void reverseString() {
    Console.WriteLine();
    string value = "abc123";

    char[] valueArray = value.ToCharArray();

    Array.Reverse(valueArray);

    //string result = new string (valueArray);
    string result = String.Join(",", valueArray);

    Console.WriteLine(result);


    string[] items = result.Split(',');

    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}

void revisionExerciseArrays(){
    /* Split, reverse and joining string exercise */

    string pangram = "The quick brown fox jumps over the lazy dog";

    Console.WriteLine($"Reverse Letters in :\n {pangram} \n\n Solution: ");

    // Step 1
    string[] message = pangram.Split(' ');

    //Step 2
    string[] newMessage = new string[message.Length];

    // Step 3
    for (int i = 0; i < message.Length; i++)
    {
        char[] letters = message[i].ToCharArray();
        Array.Reverse(letters);
        newMessage[i] = new string(letters);
    }

    //Step 4
    string result = String.Join(" ", newMessage);
    Console.WriteLine(result);

    Console.WriteLine();
    //Complete a challenge to parse a string of orders, sort the orders and tag possible errors

    Console.WriteLine("Complete a challenge to parse a string of orders, sort the orders and tag possible errors");

    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

    string[] newOrderStream = orderStream.Split(',');

    Array.Sort(newOrderStream);

    for (int i = 0; i < newOrderStream.Length; i++)//You can use foreach() instead
    {
        if (newOrderStream[i].Length != 4)
        {
            Console.WriteLine($"{newOrderStream[i]}\t-Error");
        }

        else
        {
            Console.WriteLine(newOrderStream[i]);
        }
    }
}