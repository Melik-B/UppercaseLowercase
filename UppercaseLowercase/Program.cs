//upper case lower case

//ALGORITHM

//1.1 Start.
//1.2 User can login again and again until they press the letter 'q', when they press the letter 'q' they exit the application.
//1.3 The user is prompted to enter a word.
//1.4 Capitalize the first letter of the word entered by the user.
//1.5 All letters except the first letter of the word entered by the user are made lowercase.
//1.6 The word entered by the user is printed on the screen with the first letter capitalized and the other letters small.


//büyük harf küçük harf

//ALGORİTMA

//1.2 Başla.
//1.2 Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
//1.3 Kullanıcıdan bir kelime girmesi istenir.
//1.4 Kullanıcı tarafından girilen kelimenin ilk harfi büyük yapılır.
//1.5 Kullanıcı tarafından girilen kelimenin ilk harfi dışındaki tüm harfler küçük harf yapılır.
//1.6 Kullanıcı tarafından girilen kelime, ilk harfi büyük, diğer harfleri küçük olacak şekilde ekrana yazdırılır.



Console.Write("Enter a word (Exit => q): ");
string word = Console.ReadLine();

while (word != "q")
{
    //string your word = "wORd";
    string result = vBoğaçMethodu(word); // Another method => string sonuc = FirstLetterToUpperOthersToLower(your word);
    Console.WriteLine(result);
    //string result2 = FirstLetterToUpperOthersToLower(word); // Another method => string sonuc = FirstLetterToUpperOthersToLower(your word);
    //Console.WriteLine(result2);

    static string vBoğaçMethodu(string value)
    {
        value = value.ToLower();
        string firstWord = value.Substring(0, 1);
        string result = firstWord.ToUpper() + value.Substring(1);
        return result;
    }

    #region Long Way
    //static string FirstLetterToUpperOthersToLower(string value) // uppErcaSelOWerCase --> Uppercaselowercase
    //{
    //    char[] charachters = new char[value.Length];
    //    //string charString;
    //    //string upperCharString;
    //    string result = "";

    //    for (int i = 0; i < charachters.Length; i++)
    //    {
    //        charachters[i] = value[i];
    //    }
    //    for (int i = 0; i < charachters.Length; i++)
    //    {
    //        if (i == 0)// f 
    //        {
    //            //charString = charachters[i].ToString();
    //            //upperCharString = charString.ToUpper();
    //            //charachters[i] = upperCharString[0];
    //            charachters[i] = charachters[i].ToString().ToUpper()[0];//Daha basit yol
    //        }
    //        else
    //        {
    //            charachters[i] = charachters[i].ToString().ToLower()[0];
    //        }
    //    }
    //    //foreach(char c in charachters)
    //    //{
    //    //    result = result + c;
    //    //}
    //    result = new string(charachters);

    //    return result;
    //}
    #endregion

    Console.Write("\nEnter a word (Exit => q): ");
    word = Console.ReadLine();
}