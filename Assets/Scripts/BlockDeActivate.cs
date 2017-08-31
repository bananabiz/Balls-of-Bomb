using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeActivate : MonoBehaviour {

    public GameObject blockAU, blockAsia, blockEU, blockAF, blockNA, blockSA;
    Color colorStart, colorActivate, colorBlockAU, colorBlockAsia, colorBlockEU, colorBlockAF, colorBlockNA, colorBlockSA;

    void Awake()
    {
        colorStart = new Color(0.5f, 0.5f, 0.5f, 0.1f);
        colorActivate = new Color(1, 0.9f, 0.02f, 1);
        colorBlockAU = GameObject.Find("BlockAU").GetComponent<MeshRenderer>().material.color;
        colorBlockAsia = GameObject.Find("BlockAsia").GetComponent<MeshRenderer>().material.color;
        colorBlockEU = GameObject.Find("BlockEU").GetComponent<MeshRenderer>().material.color;
        colorBlockAF = GameObject.Find("BlockAF").GetComponent<MeshRenderer>().material.color;
        colorBlockNA = GameObject.Find("BlockNA").GetComponent<MeshRenderer>().material.color;
        colorBlockSA = GameObject.Find("BlockSA").GetComponent<MeshRenderer>().material.color;
        
    }

    public void DeActivateBlock()
    {
        
        if (colorBlockAU == colorActivate)
        { 
            colorBlockAU = colorStart;
            blockAU.GetComponent<Collider2D>().enabled = false;
        }
        else if (colorBlockAsia == colorActivate)
        { 
            colorBlockAsia = colorStart;
            blockAsia.GetComponent<Collider2D>().enabled = false;
        }
        else if (colorBlockEU == colorActivate)
        {
            colorBlockEU = colorStart;
            blockEU.GetComponent<Collider2D>().enabled = false;
        }
        else if (colorBlockAF == colorActivate)
        {
            colorBlockAF = colorStart;
            blockAF.GetComponent<Collider2D>().enabled = false;
        }
        else if (colorBlockNA == colorActivate)
        {
            colorBlockNA = colorStart;
            blockNA.GetComponent<Collider2D>().enabled = false;
        }
        else if (colorBlockSA == colorActivate)
        {
            colorBlockSA = colorStart;
            blockSA.GetComponent<Collider2D>().enabled = false;
        }
    }
}
