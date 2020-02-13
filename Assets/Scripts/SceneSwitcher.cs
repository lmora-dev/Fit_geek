using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    public void GoToPrinciapalScene()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
      

    public void GotoTabataScene()
    {
        SceneManager.LoadScene("Tabata", LoadSceneMode.Single);
    }

    public void GotoCore()
    {
        SceneManager.LoadScene("Core", LoadSceneMode.Single);
    }
}
