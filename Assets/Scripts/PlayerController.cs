using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    private Animator anim;
    
    [SerializeField]
    private float movementSpeed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(xInput, yInput).normalized * movementSpeed * Time.deltaTime;

        float xVelo = rb.velocity.x;
        float yVelo = rb.velocity.y;

        anim.SetFloat("MoveX", xVelo);
        anim.SetFloat("MoveY", yVelo);

        if (Mathf.Abs(xInput) > 0 || Mathf.Abs(yInput) > 0) {
            anim.SetFloat("LastMoveX", xInput);
            anim.SetFloat("LastMoveY", yInput);
        }
    }
}
