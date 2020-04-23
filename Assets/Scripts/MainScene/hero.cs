using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    float horizontal;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Application.platform == RuntimePlatform.Android) {
            horizontal = Input.acceleration.x;
        } else {
            horizontal = Input.GetAxis ("Horizontal");
        }
        rb.velocity = new Vector2 (Input.GetAxis("Horizontal") * 10f, rb.velocity.y);
    }


void OnCollisionEnter2D(Collision2D other){
    if (other.gameObject.tag == "Platform")
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(transform.up * 20, ForceMode2D.Impulse);
    }

}
}