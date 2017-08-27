using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockActivate : MonoBehaviour {

    //public GameObject BlockAU, BlockAsia, BlockEU, BlockAF, BlockNA, BlockSA;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Collider2D>().enabled = false;
        /*
        BlockAU.GetComponent<Collider2D>().enabled = false;
        BlockAsia.GetComponent<Collider2D>().enabled = false;
        BlockEU.GetComponent<Collider2D>().enabled = false;
        BlockAF.GetComponent<Collider2D>().enabled = false;
        BlockNA.GetComponent<Collider2D>().enabled = false;
        BlockSA.GetComponent<Collider2D>().enabled = false;
        */
    }

    // Update is called once per frame
    void Update () {
		
	}
}
