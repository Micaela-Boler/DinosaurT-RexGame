using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameOver screen;

    bool isDead = false;
    Animator deadAnimator;


    void Start()
    {
       deadAnimator = GetComponent<Animator>();
    }
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            deadAnimator.SetBool("dead", isDead);

            screen.activeScreen();
        }    
    }
}
