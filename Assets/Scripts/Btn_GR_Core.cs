using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_GR_Core : MonoBehaviour
{
    public GameObject TextOblicuo1;
    public GameObject TextOblicuo2;
    public GameObject TextOblicuo3;

    public GameObject TextV1;
    public GameObject TextV2;
    public GameObject TextV3;

    public GameObject TextSixPack1;
    public GameObject TextSixPack2;
    public GameObject TextSixPack3;

    public GameObject TextComplet1;
    public GameObject TextComplet2;
    public GameObject TextComplet3;


    //Arreglos  
    string[] Oblicuos = { "plancha","Leg Raise", "Plancha lateral isometrica", "Crunch foot to foot",
            "Elevacion de piernas lateral", "Reverse Corkscrews", "Thread the needle", "1 leg plank hop twist", "Toe Taps"
         };

    string[] V = { "plancha lateral", "levantamiento de piernas (90°)", "Navasana", "Raised Legs sprend",
            "Russian twists", "Reverse crunches", "Supine leg lifts", "Arm/leg raises", "wipers", "Plank rolls",
            "knee-in wtists", "cumber taps" };


    string[] Sixpack = {  "toe touchers", "sit up", "reveres crunch", "Knee crunches", "plancha", "Flutter kicks", "L-sit" ,
            "Star Plank" , "V-ups", "Janda Sit-up", "Frozen V Sit", "Plancha extendida"
        };

    string[] Complete = { "reverse cunches", "knee crunches", "plancha", "kneek elbow crunches", "Plank Crunches", "side plank crunches"
        };


    //Objeto random


    public System.Random r = new System.Random();

    public void RandomOblicuos()
    {
        //definiciones
        int indexOblic1 = r.Next(Oblicuos.Length);
        int indexOblic2 = r.Next(Oblicuos.Length);
        int indexOblic3 = r.Next(Oblicuos.Length);

        //Evitar que se repitan

        while (indexOblic1 == indexOblic2)
        {
            indexOblic2 = r.Next(Oblicuos.Length);
        }
        while (indexOblic2 == indexOblic3 || indexOblic1 == indexOblic3)
        {
            indexOblic3 = r.Next(Oblicuos.Length);
        }

        //Pasar de eso a texto
        string l_oblicuos1 = Oblicuos[indexOblic1].ToString();
        string l_oblicuos2 = Oblicuos[indexOblic2].ToString();
        string l_oblicuos3 = Oblicuos[indexOblic3].ToString();

        //Toma el box y le dá esas cositas
        TextOblicuo1.GetComponent<Text>().text = "" + l_oblicuos1;
        TextOblicuo2.GetComponent<Text>().text = "" + l_oblicuos2;
        TextOblicuo3.GetComponent<Text>().text = "" + l_oblicuos3;

    }

    public void RandomV()
    {
        //definiciones
        int indexV1 = r.Next(V.Length);
        int indexV2 = r.Next(V.Length);
        int indexV3 = r.Next(V.Length);

        //Evitar que se repitan

        while (indexV1 == indexV2)
        {
            indexV2 = r.Next(V.Length);
        }
        while (indexV2 == indexV3 || indexV1 == indexV3)
        {
            indexV1 = r.Next(V.Length);
        }

        //Pasar de eso a texto
        string l_v1 = V[indexV1].ToString();
        string l_v2 = V[indexV2].ToString();
        string l_v3 = V[indexV3].ToString();

        //Toma el box y le dá esas cositas
        TextV1.GetComponent<Text>().text = "" + l_v1;
        TextV2.GetComponent<Text>().text = "" + l_v2;
        TextV3.GetComponent<Text>().text = "" + l_v3;
    }

    public void RandomSixpack()
    {
        //definiciones
        int indexSixpack1 = r.Next(Sixpack.Length);
        int indexSixpack2 = r.Next(Sixpack.Length);
        int indexSixpack3 = r.Next(Sixpack.Length);

        //Evitar que se repitan

        while (indexSixpack1 == indexSixpack2)
        {
            indexSixpack2 = r.Next(Sixpack.Length);
        }
        while (indexSixpack2 == indexSixpack3 || indexSixpack1 == indexSixpack3)
        {
            indexSixpack3 = r.Next(Sixpack.Length);
        }

        //Pasar de eso a texto
        string l_Sixpack1 = Sixpack[indexSixpack1].ToString();
        string l_Sixpack2 = Sixpack[indexSixpack2].ToString();
        string l_Sixpack3 = Sixpack[indexSixpack3].ToString();

        //Toma el box y le dá esas cositas
        TextSixPack1.GetComponent<Text>().text = "" + l_Sixpack1;
        TextSixPack2.GetComponent<Text>().text = "" + l_Sixpack2;
        TextSixPack3.GetComponent<Text>().text = "" + l_Sixpack3;
    }

    public void RandomComplete()
    {
        //definiciones
        int indexComplet1 = r.Next(Complete.Length);
        int indexComplet3 = r.Next(Complete.Length);
        int indexComplet2 = r.Next(Complete.Length);

        //Evitar que se repitan

        while (indexComplet1 == indexComplet2)
        {
            indexComplet2 = r.Next(Complete.Length);
        }
        while (indexComplet2 == indexComplet3 || indexComplet1 == indexComplet3)
        {
            indexComplet3 = r.Next(Complete.Length);
        }

        //Pasar de eso a texto
        string l_Complet1 = Complete[indexComplet1].ToString();
        string l_Complet2 = Complete[indexComplet2].ToString();
        string l_Complet3 = Complete[indexComplet3].ToString();

        //Toma el box y le dá esas cositas
        TextComplet1.GetComponent<Text>().text = "" + l_Complet1;
        TextComplet2.GetComponent<Text>().text = "" + l_Complet2;
        TextComplet3.GetComponent<Text>().text = "" + l_Complet3;
    }

}
