using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject bomb, stoplayer;
    public Transform spawnpoint;
    public int[] x;

    private int i;
    private Rigidbody2D rigid;
    
    // Use this for initialization
    void Start ()
    {

        //InvokeRepeating("SpawnObject", 0.5f, 3);
    }

    void SpawnObject()
    {
        stoplayer.GetComponent<Collider2D>().enabled = true;
        i = Random.Range(0, 6);
        Instantiate(bomb, new Vector2(x[i], 3.5f), spawnpoint.rotation);
        //bomb.GetComponent<Rigidbody2D>().gravityScale = 0;
        //Rigidbody2D Rigid = bomb.GetComponent<Rigidbody2D>();
        //rigid.gravityScale = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
            
            //CancelInvoke("SpawnObject");
            //Instantiate(bomb, spawnpoint.position, spawnpoint.rotation);

        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            stoplayer.GetComponent<Collider2D>().enabled = false;
            //bomb.GetComponent<Rigidbody2D>().gravityScale = 2;
            //rigid.gravityScale = 2;
        }
        return;
    }
}