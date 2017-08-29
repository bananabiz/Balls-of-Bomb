﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActivatAF : MonoBehaviour {

    public GameObject buttonAF;
    public GameObject blockAF;
    
    Color colorStart, colorActivate;
    private bool clicked = false;

    
    void Awake ()
    {
        colorStart = new Color(0.5f, 0.5f, 0.5f, 0);
        colorActivate = new Color(0, 1, 0, 1);
        
        GameObject.Find("BlockAF").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAF.GetComponent<Collider2D>().enabled = false;
       
    }

    private void OnMouseDown()
    {
        clicked = true;
    } 

    // Update is called once per frame
    void Update ()
    {
        if (clicked)
        {
            blockAF.GetComponent<Collider2D>().enabled = true;
            GameObject.Find("BlockAF").GetComponent<MeshRenderer>().material.color = colorActivate;
        }
        
	}
}