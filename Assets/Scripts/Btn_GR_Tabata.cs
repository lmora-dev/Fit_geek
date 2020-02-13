using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_GR_Tabata : MonoBehaviour
{

    public GameObject TextCardio1;
    public GameObject TextCardio2;

    public GameObject TextFuerza1;
    public GameObject TextFuerza2;

    public GameObject TextAbs1;
    public GameObject TextAbs2;

    //Arreglos  
    string[] Cardio = { "Burpees", "Jumping Jack",
                 "Carrera rodilla al pecho", "Saltar la cuerda",
                "Sentadilla con salto", "Mountain Climbers", "Power Skips",
                "Tuck Jumps", "Scissor runs"
        };

    string[] Fuerza = { "Flexiones Spiderman", "Sentadillas con salto",
                 "Flexiones", "Flexiones diamante", "sentadillas",
                "Flexiones abiertas", "Jumping lunges", "plank row", "skull crushers",
        "Pistol squad", "peso muerto", "tricep dips"
        };

    string[] Abdominales = { "twist rusos", "Tabla",
                 "Bicicleta", "Tijeras", "Bridges", "Wall Sit",
                "Abdominales bicicleta","Sit ups", "full body crunch", "knee tuck",
                "bicycle crunches", "levantamiento de piernas", "scissors",
                "Giros rusos"
        };


    //Objeto random

    
    public System.Random r = new System.Random();


    public void RandomEjercicio()
    {
        //definiciones
        int indexc1 = r.Next(Cardio.Length);
        int indexc2 = r.Next(Cardio.Length);

        int indexf1 = r.Next(Fuerza.Length);
        int indexf2 = r.Next(Fuerza.Length);

        int indexa1 = r.Next(Abdominales.Length);
        int indexa2 = r.Next(Abdominales.Length);


        //Evitar que se repitan
        while (indexc1 == indexc2)
        {
            indexc2 = r.Next(Cardio.Length);
        }

        while (indexf1 == indexf2)
        {
            indexf2 = r.Next(Fuerza.Length);
        }

        while (indexa1 == indexa2)
        {
            indexa2 = r.Next(Abdominales.Length);
        }


        //Pasar de eso a texto
        string l_cardio1 = Cardio[indexc1].ToString();
        string l_cardio2 = Cardio[indexc2].ToString();
        string l_fuerza1 = Fuerza[indexf1].ToString();
        string l_fuerza2 = Fuerza[indexf2].ToString();
        string l_abdomi1 = Abdominales[indexa1].ToString();
        string l_abdomi2 = Abdominales[indexa2].ToString();


        //Toma el box y le dá esas cositas
        TextCardio1.GetComponent<Text>().text = "" + l_cardio1;
        TextCardio2.GetComponent<Text>().text = "" + l_cardio2;
        TextFuerza1.GetComponent<Text>().text = "" + l_fuerza1;
        TextFuerza2.GetComponent<Text>().text = "" + l_fuerza2;
        TextAbs1.GetComponent<Text>().text = "" + l_abdomi1;
        TextAbs2.GetComponent<Text>().text = "" + l_abdomi2;


    }


    //*Cardio
    public void RandomCardio()
    {
        //definiciones
        int indexc1 = r.Next(Cardio.Length);
        int indexc2 = r.Next(Cardio.Length);

        //Evitar que se repitan
        while (indexc1 == indexc2)
        {
            indexc2 = r.Next(Cardio.Length);
        }

        //Pasar de eso a texto
        string l_cardio1 = Cardio[indexc1].ToString();
        string l_cardio2 = Cardio[indexc2].ToString();

        //Toma el box y le dá esas cositas
        TextCardio1.GetComponent<Text>().text = "" + l_cardio1;
        TextCardio2.GetComponent<Text>().text = "" + l_cardio2;

    }

    public void RandomFuerza()
    {
        //definiciones
        int indexf1 = r.Next(Fuerza.Length);
        int indexf2 = r.Next(Fuerza.Length);

        //Evitar que se repitan
  
        while (indexf1 == indexf2)
        {
            indexf2 = r.Next(Fuerza.Length);
        }

        //Pasar de eso a texto
        string l_fuerza1 = Fuerza[indexf1].ToString();
        string l_fuerza2 = Fuerza[indexf2].ToString();

        //Toma el box y le dá esas cositas
        TextFuerza1.GetComponent<Text>().text = "" + l_fuerza1;
        TextFuerza2.GetComponent<Text>().text = "" + l_fuerza2;

    }


    public void RandomAbdominales()
    {
        //definiciones
        int indexa1 = r.Next(Abdominales.Length);
        int indexa2 = r.Next(Abdominales.Length);
        //Evitar que se repitan
        while (indexa1 == indexa2)
        {
            indexa2 = r.Next(Abdominales.Length);
        }
        //Pasar de eso a texto
        string l_abdomi1 = Abdominales[indexa1].ToString();
        string l_abdomi2 = Abdominales[indexa2].ToString();
        //Toma el box y le dá esas 
        TextAbs1.GetComponent<Text>().text = "" + l_abdomi1;
        TextAbs2.GetComponent<Text>().text = "" + l_abdomi2;


    }

}
