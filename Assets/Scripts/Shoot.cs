using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bomb;
    public Transform spawn;
    public Transform[] targets;
    //public Vector3 target;
    public int[] x, y;
    public float speed;

    private int i;
    private Rigidbody2D rigid;
    
    void Start()
    {
        //rigid = GetComponent<Rigidbody2D>();
       
    }

    void SpawnObject()
    {
        
        i = Random.Range(0, 6);
        GameObject shoot = Instantiate(bomb, new Vector3(0, 3.5f), spawn.rotation);

        //target = new Vector3(x[i], y[i], 0);
        Vector3 direction = targets[i].position - transform.position;
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        rigid = shoot.GetComponent<Rigidbody2D>();

        transform.position += (Vector3)direction * speed;  // * Time.deltaTime
        //rigid.direction = direction;
        //rigid.AddForce(direction * speed);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();

        }
        /*
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Vector3 direction = target - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation;
            //rigid.rotation = rotation;
            transform.position += (Vector3)target * speed;

        }*/
        return;
    }
}