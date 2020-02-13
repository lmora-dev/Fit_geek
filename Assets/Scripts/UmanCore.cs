using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UmanCore : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform mainMenu, oblicuoMen, VMenu, SixMenu, CompletMenu;

    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void Menu_Oblicuos()
    {
        mainMenu.DOAnchorPos(new Vector2(-1504, 0), 0.25f);
        oblicuoMen.DOAnchorPos(new Vector2(0, 0), 0.25f);
       
    }

    public void Menu_V()
    {
        mainMenu.DOAnchorPos(new Vector2(1487, 0), 0.25f);
        VMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void Menu_Sixpack()
    {
        mainMenu.DOAnchorPos(new Vector2(-3070, 0), 0.25f);
        SixMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void Menu_Complet()
    {
        mainMenu.DOAnchorPos(new Vector2(3004, 0), 0.25f);
        CompletMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void CloseToMainMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        oblicuoMen.DOAnchorPos(new Vector2(-1504, 0), 0.25f);
        SixMenu.DOAnchorPos(new Vector2(-3070, 0), 0.25f);
        VMenu.DOAnchorPos(new Vector2(1487, 0), 0.25f);
        CompletMenu.DOAnchorPos(new Vector2(3004, 0), 0.25f);
    }
}
