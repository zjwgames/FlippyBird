using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpScale = 10;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isDead)
        {
            rb.AddForce(jumpScale * Vector2.up);
            //Debug.Log(Input.mousePosition);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Death by " + collision.collider.name);
        isDead = true;
    }
}
