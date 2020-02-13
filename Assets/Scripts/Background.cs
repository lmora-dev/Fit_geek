using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float BgSpeed = 0.10f;
    public Renderer bgRend;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void MoveFondo()
    {
        bgRend.material.mainTextureOffset += new Vector2(BgSpeed * Time.deltaTime, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveFondo();
    }

}
