using System.Collections.Generic;
public class Collections
{
    public void LearnedAboutList()
    {
        List<string> names = new List<string>{ "James", "Riley"};

        names.Add("Ram");
        names.Add("Sita");
        names.Add("Hari");
        names.Add("Ravi");

        names.Sort();
    }

    public void LearnAboutDictionary()
    {
        // Hold key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };

        countryCapitals.Add("Nepal","Kathmandu");
        countryCapitals.Add("India","delhi");
        countryCapitals.Add("USA","WDC");
        countryCapitals.Add("Russia","Mosco");
    }

}