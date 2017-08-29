using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public Rigidbody2D bomb;
    public ScoreManager scoreManager;
    public BlockDeActivate deActivate;

    private void Awake()
    {
        deActivate = GetComponent<BlockDeActivate>();
    }

    private void Start()
    {
        bomb = GetComponent<Rigidbody2D>();
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        
    }
    
    private void OnCollisionEnter2D(Collision2D bomb)
    {
        if (bomb.gameObject.tag == "Bomb")
        {
            Destroy(bomb.gameObject, 0.1f);
            scoreManager.score++;

            //deActivate.DeActivateBlock();
        }
        
    }
   
}