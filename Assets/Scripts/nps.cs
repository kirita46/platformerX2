using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nps : MonoBehaviour, ITouchable
{
    [SerializeField] private float leftRadius = 5f;

    [SerializeField] private float rightRadius = 5f;

    [SerializeField] private float speed;

    private Health.Health _health;

    private Vector2 pos;

    private SpriteRenderer spr;
    Rigidbody2D rb;

    private bool IsRight = false;

    // Start is called before the first frame update
    void Start()
    {
        _health = FindObjectOfType<Health.Health>();
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        pos = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRight)
        {
            rb.velocity = Vector2.right * speed;
            spr.flipX = false;
            if (transform.position.x - rightRadius > pos.x)
            {
                IsRight = false;
            }
        }
        else
        {
            rb.velocity = Vector2.left * speed;
            spr.flipX = true;
            if (transform.position.x + leftRadius < pos.x)
            {
                IsRight = true;
            }
        }
    }

    public void OnTouch(Player player)
    {
        Destroy(gameObject);
        var isDied = !_health.DecrementHealth();
        if (isDied)
            SceneManager.LoadScene("wanted");
    }
}