using UnityEngine;

namespace MarkkuPelit //namespace -nimiavaruus
{
    public class Utilites  //class  -luokka
    {
        public static void PrintMarkku()  //method ñ metodi, funktio
        {
            Debug.Log("MarkkuPelit on parhaita!");
        }
    }

    namespace UI
    {
        public class UIStuff
        {
            public static void DoUI()
            {
                Debug.Log(" Tehd‰‰n hieno User Interface");
            }
        }
    }
}

