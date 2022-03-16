using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float jumpHeight = 7f;
    bool isGrounded;

    Rigidbody2D playerRb;

    private PlayerJumps playerJumps = new PlayerJumps();

    // Start is called before the first frame update
    void Start ()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(horizontalInput, 0) * 5f * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                playerRb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            foreach (ContactPoint2D contactPoint in collision.contacts)
            {
                Debug.Log($"Contact Point: {contactPoint.normal.y}");
                Debug.Log($"Number of Jumps: {playerJumps.Jumps}");
                if (contactPoint.normal.y >= .9f)
                {
                    isGrounded = true;
                }
            }
        }
    }

    private void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
