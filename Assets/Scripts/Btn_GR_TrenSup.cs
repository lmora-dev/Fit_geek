using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Btn_GR_TrenSup : MonoBehaviour
{
    public GameObject TextPectoral1;
    public GameObject TextPectoral2;
    public GameObject TextPectoral3;

    public GameObject TextDorsal1;
    public GameObject TextDorsal2;
    public GameObject TextDorsal3;

    public GameObject TextDeltoides1;
    public GameObject TextDeltoides2;
    public GameObject TextDeltoides3;

    public GameObject TextRomboides1;
    public GameObject TextRomboides2;
    public GameObject TextRomboides3;

    public GameObject TextTrapecio1;
    public GameObject TextTrapecio2;
    public GameObject TextTrapecio3;

    public GameObject TextBiceps1;
    public GameObject TextBiceps2;
    public GameObject TextBiceps3;

    public GameObject TextTriceps1;
    public GameObject TextTriceps2;
    public GameObject TextTriceps3;

    //Arreglos  
  
    string[] Pectoral = {" Push - Ups, Plate Press - Out", "a", "b", "c", "d" };
    string[] Dorsal = {" Resistance Band Pull - Apart ", "a", "b", "c", "d"};
    string[] Deltoides = {"Push-Ups", "Single-Arm Linear Jammer", "Side Laterals to Front Raise", "Standing Palm-In One-Arm Dumbbell Press", "Clean and Press" , "push press", "One-Arm Side Laterals", "Power Partials" , "Seated Dumbbell Press"};
    string[] Romboides = {"a","b", "c", "d" };
    string[] Trapecio = { "a", "b", "c", "d"};
    string[] Biceps = { "a", "b", "c", "d" };
    string[] Triceps = { "Push - Ups", "a", "b", "c", "d" };
    
  
    public System.Random r = new System.Random();


    // Start is called before the first frame update
    public void RandomPectoral()
    {

        int indexPectoral1 = r.Next(Pectoral.Length);
        int indexPectoral2 = r.Next(Pectoral.Length);
        int indexPectoral3 = r.Next(Pectoral.Length);

        //Evitar que se repitan

        while (indexPectoral1 == indexPectoral2)
        {
            indexPectoral2 = r.Next(Pectoral.Length);
        }
        while (indexPectoral2 == indexPectoral3|| indexPectoral1 == indexPectoral3)
        {
            indexPectoral3 = r.Next(Pectoral.Length);
        }

        //Pasar de eso a texto
        string l_Pectoral1 = Pectoral[indexPectoral1].ToString();
        string l_Pectoral2 = Pectoral[indexPectoral2].ToString();
        string l_Pectoral3 = Pectoral[indexPectoral3].ToString();

        //Toma el box y le dá esas cositas
        TextPectoral1.GetComponent<Text>().text = "" + l_Pectoral1;
        TextPectoral2.GetComponent<Text>().text = "" + l_Pectoral2;
        TextPectoral3.GetComponent<Text>().text = "" + l_Pectoral3;
    }

    public void RandomDorsal()
    {

        int indexDorsal1= r.Next(Dorsal.Length);
        int indexDorsal2 = r.Next(Dorsal.Length);
        int indexDorsal3 = r.Next(Dorsal.Length);

        //Evitar que se repitan

        while (indexDorsal1 == indexDorsal2)
        {
            indexDorsal2 = r.Next(Dorsal.Length);
        }
        while (indexDorsal2 == indexDorsal3 || indexDorsal1 == indexDorsal3)
        {
            indexDorsal3 = r.Next(Dorsal.Length);
        }

        //Pasar de eso a texto
        string l_Dorsal1 = Dorsal[indexDorsal1].ToString();
        string l_Dorsal2 = Dorsal[indexDorsal2].ToString();
        string l_Dorsal3 = Dorsal[indexDorsal3].ToString();

        //Toma el box y le dá esas cositas
        TextDorsal1.GetComponent<Text>().text = "" + l_Dorsal1;
        TextDorsal2.GetComponent<Text>().text = "" + l_Dorsal2;
        TextDorsal3.GetComponent<Text>().text = "" + l_Dorsal3;
    }

    public void RandomDeltoides()
    {

        int indexDeltoides1 = r.Next(Deltoides.Length);
        int indexDeltoides2 = r.Next(Deltoides.Length);
        int indexDeltoides3 = r.Next(Deltoides.Length);

        //Evitar que se repitan

        while (indexDeltoides1 == indexDeltoides2)
        {
            indexDeltoides2 = r.Next(Deltoides.Length);
        }
        while (indexDeltoides2 == indexDeltoides3 || indexDeltoides1 == indexDeltoides3)
        {
            indexDeltoides3 = r.Next(Deltoides.Length);
        }

        //Pasar de eso a texto
        string l_Deltoides1 = Deltoides[indexDeltoides1].ToString();
        string l_Deltoides2 = Deltoides[indexDeltoides2].ToString();
        string l_Deltoides3 = Deltoides[indexDeltoides3].ToString();

        //Toma el box y le dá esas cositas
        TextDeltoides1.GetComponent<Text>().text = "" + l_Deltoides1;
        TextDeltoides2.GetComponent<Text>().text = "" + l_Deltoides2;
        TextDeltoides3.GetComponent<Text>().text = "" + l_Deltoides3;
    }

    public void RandomRomboides()
    {

        int indexRomboide1 = r.Next(Romboides.Length);
        int indexRomboide2 = r.Next(Romboides.Length);
        int indexRomboide3 = r.Next(Romboides.Length);

        //Evitar que se repitan

        while (indexRomboide1 == indexRomboide2)
        {
            indexRomboide2 = r.Next(Romboides.Length);
        }
        while (indexRomboide2 == indexRomboide3 || indexRomboide1 == indexRomboide3)
        {
            indexRomboide3 = r.Next(Romboides.Length);
        }

        //Pasar de eso a texto
        string l_Romboide1 = Pectoral[indexRomboide1].ToString();
        string l_Romboide2 = Pectoral[indexRomboide2].ToString();
        string l_Romboide3 = Pectoral[indexRomboide3].ToString();

        //Toma el box y le dá esas cositas
        TextRomboides1.GetComponent<Text>().text = "" + l_Romboide1;
        TextRomboides2.GetComponent<Text>().text = "" + l_Romboide2;
        TextRomboides3.GetComponent<Text>().text = "" + l_Romboide3;
    }

    public void RandomTrapecio()
    {

        int indexTrapecio1 = r.Next(Trapecio.Length);
        int indexTrapecio2 = r.Next(Trapecio.Length);
        int indexTrapecio3 = r.Next(Trapecio.Length);

        //Evitar que se repitan

        while (indexTrapecio1 == indexTrapecio2)
        {
            indexTrapecio2 = r.Next(Trapecio.Length);
        }
        while (indexTrapecio2 == indexTrapecio3 || indexTrapecio1 == indexTrapecio3)
        {
            indexTrapecio3 = r.Next(Trapecio.Length);
        }

        //Pasar de eso a texto
        string l_Trapecio1 = Trapecio[indexTrapecio1].ToString();
        string l_Trapecio2 = Trapecio[indexTrapecio2].ToString();
        string l_Trapecio3 = Trapecio[indexTrapecio3].ToString();

        //Toma el box y le dá esas cositas
        TextTrapecio1.GetComponent<Text>().text = "" + l_Trapecio1;
        TextTrapecio2.GetComponent<Text>().text = "" + l_Trapecio2;
        TextTrapecio3.GetComponent<Text>().text = "" + l_Trapecio3;
    }

    public void RandomBiceps()
    {

        int indexBiceps1 = r.Next(Biceps.Length);
        int indexBiceps2 = r.Next(Biceps.Length);
        int indexBiceps3 = r.Next(Biceps.Length);

        //Evitar que se repitan

        while (indexBiceps1 == indexBiceps2)
        {
            indexBiceps2 = r.Next(Biceps.Length);
        }
        while (indexBiceps2 == indexBiceps3 || indexBiceps1 == indexBiceps3)
        {
            indexBiceps3 = r.Next(Biceps.Length);
        }

        //Pasar de eso a texto
        string l_Biceps1 = Biceps[indexBiceps1].ToString();
        string l_Biceps2 = Biceps[indexBiceps2].ToString();
        string l_Biceps3 = Biceps[indexBiceps3].ToString();

        //Toma el box y le dá esas cositas
        TextBiceps1.GetComponent<Text>().text = "" + l_Biceps1;
        TextBiceps2.GetComponent<Text>().text = "" + l_Biceps2;
        TextBiceps3.GetComponent<Text>().text = "" + l_Biceps3;
    }

    public void RandomTriceps()
    {

        int indexTriceps1 = r.Next(Triceps.Length);
        int indexTriceps2 = r.Next(Triceps.Length);
        int indexTriceps3 = r.Next(Triceps.Length);

        //Evitar que se repitan

        while (indexTriceps1 == indexTriceps2)
        {
            indexTriceps2 = r.Next(Triceps.Length);
        }
        while (indexTriceps2 == indexTriceps3 || indexTriceps1 == indexTriceps3)
        {
            indexTriceps3 = r.Next(Triceps.Length);
        }

        //Pasar de eso a texto
        string l_Triceps1 = Triceps[indexTriceps1].ToString();
        string l_Triceps2 = Triceps[indexTriceps2].ToString();
        string l_Triceps3 = Triceps[indexTriceps3].ToString();

        //Toma el box y le dá esas cositas
        TextTriceps1.GetComponent<Text>().text = "" + l_Triceps1;
        TextTriceps2.GetComponent<Text>().text = "" + l_Triceps2;
        TextTriceps3.GetComponent<Text>().text = "" + l_Triceps3;
    }

}
