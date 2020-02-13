using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UManager : MonoBehaviour
{
    public RectTransform mainMenu, ejerciciosMenu;
    public GameObject backg1, backg2;


    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
        backg1.SetActive(true);
        backg2.SetActive(false);
    }

    public void EjerciciosButton()
    {
        mainMenu.DOAnchorPos(new Vector2(-1469, 0), 0.25f);
        ejerciciosMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        backg1.SetActive(false);
        backg2.SetActive(true);
    }

    public void CloseEjerciciosButton()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
        ejerciciosMenu.DOAnchorPos(new Vector2(1469, 0), 0.25f);
        backg1.SetActive(true);
        backg2.SetActive(false);

    }

 




}
