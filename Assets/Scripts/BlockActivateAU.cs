using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActivateAU : MonoBehaviour
{

    public GameObject buttonAU;
    public GameObject blockAU;

    Color colorStart, colorActivate;
    private bool clicked = false;


    void Awake()
    {
        colorStart = new Color(0.5f, 0.5f, 0.5f, 0);
        colorActivate = new Color(0, 1, 0, 1);

        GameObject.Find("BlockAU").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAU.GetComponent<Collider2D>().enabled = false;

    }

    private void OnMouseDown()
    {
        clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
            blockAU.GetComponent<Collider2D>().enabled = true;
            GameObject.Find("BlockAU").GetComponent<MeshRenderer>().material.color = colorActivate;
        }
    }
}
