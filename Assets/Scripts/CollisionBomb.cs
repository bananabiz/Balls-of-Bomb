using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBomb : MonoBehaviour
{
    public Rigidbody2D bomb;
    public ScoreManager2 scoreManager2;

    public BlockDeActivate deActivate;
    public AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
        bomb = GetComponent<Rigidbody2D>();

        deActivate = GetComponent<BlockDeActivate>();
    }

    private void Start()
    {
        
        scoreManager2 = GameObject.Find("Score2").GetComponent<ScoreManager2>();

    }

    private void OnCollisionEnter2D(Collision2D bomb)
    {
        if (bomb.gameObject.tag == "Bomb")
        {
            Cursor.visible = true;

            sound.Play();
            
            Destroy(bomb.gameObject, 0.01f);
            
            scoreManager2.score2++;
            /*
            deActivate.DeActivateBlockAU();
            deActivate.DeActivateBlockAsia();
            deActivate.DeActivateBlockEU();
            deActivate.DeActivateBlockAF();
            deActivate.DeActivateBlockNA();
            deActivate.DeActivateBlockSA();
            */
        }

    }

}