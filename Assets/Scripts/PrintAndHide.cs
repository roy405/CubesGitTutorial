using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;  // Start with 3
    private int randBlue;


    void Start()
    {
        randBlue = Random.Range(150, 251);

    }

    // Update is called once per frame
    void Update()
    {
        i++;  
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == randBlue)
        {
            rend.enabled = false;
        }
    }
}
