using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActivateAsia : MonoBehaviour {

    public GameObject buttonAsia;
    public GameObject blockAsia;

    Color colorStart, colorActivate;
    private bool clicked = false;


    void Awake()
    {
        colorStart = new Color(0.5f, 0.5f, 0.5f, 0);
        colorActivate = new Color(0, 1, 0, 1);

        GameObject.Find("BlockAsia").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAsia.GetComponent<Collider2D>().enabled = false;

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
            blockAsia.GetComponent<Collider2D>().enabled = true;
            GameObject.Find("BlockAsia").GetComponent<MeshRenderer>().material.color = colorActivate;
        }

    }
}