using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform spawn;
    public Transform[] targets;

    public int[] x, y;
    public float speed = 10f;

    private int i;
    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    void SpawnObject()
    {

        i = Random.Range(0, 6);
        GameObject shoot = Instantiate(bombPrefab, new Vector3(0, 3.5f), spawn.rotation);
        //bombPrefab = Instantiate(bomb, spawn.position, Quaternion.Euler(Vector3(x, y, z)));
        //target = new Vector3(x[i], y[i], 0);
        rigid = shoot.GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            //rigid.gravityScale = 2;

            Vector3 direction = targets[i].position - transform.position;
            direction.Normalize();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            if (rigid != null)
            {
                rigid.AddForce((Vector3)direction * speed, ForceMode2D.Impulse);
            }
        }
    }
}