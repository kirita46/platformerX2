using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    Rigidbody2D rb;
    CircleCollider2D circleCollider2D;
    [SerializeField] LayerMask platformLayarMask;

    [SerializeField, Tooltip("сила прыжка")]
    float jumstr;

    [SerializeField, Tooltip("сила скорости")]
    float Speed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        circleCollider2D = GetComponent<CircleCollider2D>();
    }


    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float Jump = 0;
        transform.Rotate(0, 0, move * Time.deltaTime);

        rb.velocity = new Vector2(move * Speed, rb.velocity.y);
        if (Input.GetKeyDown("space") && IsGrounded()) Jump = jumstr;

        rb.velocity = new Vector2(move * Speed, rb.velocity.y + Jump);
    }

    private bool IsGrounded()
    {
        float extrHeight = 0.1f;

        RaycastHit2D raycastHit = Physics2D.BoxCast(circleCollider2D.bounds.center,
            circleCollider2D.bounds.size,
            0f,
            Vector2.down,
            extrHeight,
            platformLayarMask);
        return raycastHit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TryGetComponent(out ITouchable touchable);
        touchable.OnTouch(this);
    }
}