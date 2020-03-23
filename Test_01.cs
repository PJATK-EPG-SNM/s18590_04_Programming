using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ zmiennej nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 15;
        //wyświetlanie na konsoli
        Debug.Log(a);

        float f = 1.5f;  // jak jest kropka to dopisujemy f 
        f = 4;
        bool log = true;  //false  //zmienna logiczna
        string str = "jakiś napis";

        Debug.Log("f: " + f + " log: " + log + " str: " + str);

        Debug.Log(a / b);
        Debug.Log(a / f);
        Debug.Log(Mathf.Sqrt(2));

        //oberacje logiczne
        Debug.Log(a == b); //równe
        Debug.Log(a != b); //różne
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

        //instrukcja warunkowa 
        //if (warunek_logiczny){
        //}

        if (a == b)
        {
            Debug.Log("Tak,jest taka sama!");
        }
        else if (a < b)
        {
            Debug.Log("a < b");
        } else
        {
            Debug.Log("żadne z powyższych");
        }
        //koniuńkcja  oba muszą być prawdziwe
        Debug.Log((a != b) && (a > 0));

        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }

        if((a != b) && (a > 0))
        {
            //kod
        }

        //alternatywa  tylko jedno musi być prawdziwe
        //brzydka wersja XD

        indexer hp = 2, time = 1;
        if(hp <= 0)
        {
            if (!amulet)
            {
                //
            }
            else
            {

            }
        }
        
        // ładna wersja XDDDD
        if(hp <= 0 || time <= 0)
        {
            if (!amulet)
            {

            }
            else
            {

            }
        }   
    }

    public void Koniunkcja(int a, int b)
    {
        Debug.Log((a != b) && (a > 0));

        if (a != b)
        {
            if (a > 0)
            {
                //kod
            }
        }

        if ((a != b) && (a > 0))
        {
            //kod
        }
    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
