using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    AudioSource jumpAudio;
    Animator jumpAnimator;

    [Header("Movement ---")]
    Rigidbody2D _playerRB; 
    public float jumpForce = 5f;
    bool isMoving = true;


    void Start()
    {
       _playerRB = GetComponent<Rigidbody2D>();  
        jumpAudio = GetComponent<AudioSource>();

        jumpAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        jumpAnimator.SetBool("jump", isMoving);

        if (Input.GetKeyDown(KeyCode.Space) && isMoving) 
        {
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  //addForce le aplica fuerza /ForceMode2D aplica/identifica el tipo de fuerza
            isMoving = false;

            jumpAudio.Play();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isMoving = true;
    }
}
