using System;

class Program



{
    static string Obtain_Random_element(string[] t)
    {
        Random rnd = new Random();
        int number = rnd.Next(t.Length);
        return t[number];
    }

    static void Main(string[] args)
    {
        var sujet = new string[]
        {
            "Un immense dragon",
            "Une coccinelle",
            "Un chaton rouge",
            "Un hiboux affamé",
            "Une araignée minuscule",
            "Un raton laveur",
            "Une écolière",
            "Une équipe de football",
            "Un groupe de monstre",
            "Un dinosaure"
        };

        var verbe = new string[]
        {
            "dévore",
            "examine",
            "ecoute",
            "chante",
            "mange",
            "observe",
            "ecrase",
            "s'accroche à",
            "hurle",
            "se bat avec"
        };

        var complement = new string[]
        {
            "un arbre",
            "la lune",
            "le soleil",
            "chaque matin",
            "un gateau",
            "le ciel",
            "un crapaud",
            "une tomate",
            "un bureau",
            "pendant la nuit"
        };
        int doublon = 0;
        var liste_phrase = new List<string>();



      while(liste_phrase.Count < 100) {

                string s = Obtain_Random_element(sujet);
                string v = Obtain_Random_element(verbe);
                string c = Obtain_Random_element(complement);

                string phrase = s + " " + v + " " + c;



                if (!liste_phrase.Contains(phrase))
                {
                    liste_phrase.Add(phrase);
                }
                else
                {
                    doublon++;
                }

               
                foreach (string e in liste_phrase)
                {
                    Console.WriteLine(e);
                }
        }

        Console.WriteLine($"Nombre de Phrases Unique : {liste_phrase.Count}.");
        Console.WriteLine($"Doublons évité : {doublon}.");

    }

}
