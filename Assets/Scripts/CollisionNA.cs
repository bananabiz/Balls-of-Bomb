﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionNA : MonoBehaviour
{
    public Rigidbody2D bomb;
    public ScoreManager scoreManager;
    public BlockDeActivate deActivate;
    public AudioSource sound;
    public BlockActivateNA buttonNA;

    private void Awake()
    {
        deActivate = GetComponent<BlockDeActivate>();
        sound = GetComponent<AudioSource>();

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
            buttonNA.clicked = false;
            Cursor.visible = true;
            sound.Play();
            Destroy(bomb.gameObject, 0.05f);

            //deActivate.DeActivateBlockNA();
            scoreManager.score++;

        }

    }

}