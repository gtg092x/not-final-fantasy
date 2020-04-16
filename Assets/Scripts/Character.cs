using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float Speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateAnimator();
    }

    void UpdateAnimator() {
        var rb = GetComponent<Rigidbody2D>();
        GetComponent<Animator>().SetFloat("SpeedX", rb.velocity.x);
        GetComponent<Animator>().SetFloat("SpeedY", rb.velocity.y);
    }

    void UpdateMovement() {
        float speed = this.Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = speed * 3;
        }
        var Offset = new Vector2(0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Offset = Offset + Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Offset = Offset + Vector2.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Offset = Offset + Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Offset = Offset + Vector2.down;
        }
        GetComponent<Rigidbody2D>().AddRelativeForce(Offset * speed);
       
    }
}
