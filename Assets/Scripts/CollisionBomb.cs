using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionBomb : MonoBehaviour
{
    public Rigidbody2D bomb;
    public Text scoreText;
    private int s;

    private void Start()
    {
        bomb = GetComponent<Rigidbody2D>();
        s = 0;
    }

    private void OnCollisionEnter2D(Collision2D block)
    {
        if (block.gameObject.tag == "Block")
        {
            Destroy(bomb.gameObject, 0.2f);

            s++;
            scoreText.text = "You have saved " + s.ToString() + " countries!";

            if (s == 10)
            {
                scoreText.text = "YOU WIN!!!";
                Application.Quit();
            }
        }

    }

}