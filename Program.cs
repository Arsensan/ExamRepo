




String[] makeStringArray(String[] s)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            count++;
        }
    }
    String[] stringToChange = new String[count];
    int index = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            stringToChange[index] = s[i];
            index++;
        }
    }
    return stringToChange;
}
void showArray (String [] s){
    foreach (String item in s)
    {
        Console.Write ($"{item}, ");
    }
}
String[] baseArray = new String[] { "Hey", "Rectangle", "Mate", "R2D2", "-5", "s", "Cucumber" };
String [] modifyedArray = makeStringArray(baseArray);
showArray (modifyedArray);

