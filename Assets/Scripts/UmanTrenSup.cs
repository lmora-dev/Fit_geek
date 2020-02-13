using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UmanTrenSup : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform mainMenu, PectoralMenu, DorsalMenu, DeltoidesMenu, RomboidesMenu;

    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void Menu_Oblicuos()
    {
        mainMenu.DOAnchorPos(new Vector2(-1504, 0), 0.25f);
        PectoralMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void Menu_V()
    {
        mainMenu.DOAnchorPos(new Vector2(1487, 0), 0.25f);
        DorsalMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void Menu_Sixpack()
    {
        mainMenu.DOAnchorPos(new Vector2(-3070, 0), 0.25f);
        DeltoidesMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void Menu_Complet()
    {
        mainMenu.DOAnchorPos(new Vector2(3004, 0), 0.25f);
        RomboidesMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);

    }

    public void CloseToMainMenu()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        PectoralMenu.DOAnchorPos(new Vector2(-1504, 0), 0.25f);
        DeltoidesMenu.DOAnchorPos(new Vector2(-3070, 0), 0.25f);

        DorsalMenu.DOAnchorPos(new Vector2(1487, 0), 0.25f);
        RomboidesMenu.DOAnchorPos(new Vector2(3004, 0), 0.25f);
    }
}