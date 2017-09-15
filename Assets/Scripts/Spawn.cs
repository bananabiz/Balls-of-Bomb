using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {

    public GameObject bomb; //stoplayer;
    public GameObject prefabBomb;
    public Transform spawnpoint;
    public int[] x;

    private int i;
    private Rigidbody2D rigid;
    //private Countries countries;
    
    // Use this for initialization
    void Start ()
    {
        //countries = GetComponent<Countries>();
        //InvokeRepeating("SpawnObject", 0.5f, 3);
    }

    void SpawnObject()
    {
        //stoplayer.GetComponent<Collider2D>().enabled = true;
        i = Random.Range(0, 6);
        prefabBomb = Instantiate(bomb, new Vector2(x[i], 3.5f), spawnpoint.rotation);
        rigid = prefabBomb.GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            rigid.gravityScale = 2;
        }
        return;
    }
}