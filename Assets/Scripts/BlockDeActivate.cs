using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDeActivate : MonoBehaviour {

    public GameObject blockAU, blockAsia, blockEU, blockAF, blockNA, blockSA;
    Color colorStart;

    void Start()
    {
        colorStart = new Color(0.5f, 0.5f, 0.5f, 0);
    }

    public void DeActivateBlock()
    {
        GameObject.Find("BlockAU").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAU.GetComponent<Collider2D>().enabled = false;
        GameObject.Find("BlockAsia").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAsia.GetComponent<Collider2D>().enabled = false;
        GameObject.Find("BlockEU").GetComponent<MeshRenderer>().material.color = colorStart;
        blockEU.GetComponent<Collider2D>().enabled = false;
        GameObject.Find("BlockAF").GetComponent<MeshRenderer>().material.color = colorStart;
        blockAF.GetComponent<Collider2D>().enabled = false;
        GameObject.Find("BlockNA").GetComponent<MeshRenderer>().material.color = colorStart;
        blockNA.GetComponent<Collider2D>().enabled = false;
        GameObject.Find("BlockSA").GetComponent<MeshRenderer>().material.color = colorStart;
        blockSA.GetComponent<Collider2D>().enabled = false;

    }
}
