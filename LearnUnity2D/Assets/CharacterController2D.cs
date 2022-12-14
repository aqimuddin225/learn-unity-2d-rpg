using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        motionVector = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate() {
        Move();
    }

    private void Move(){
        rigidbody2d.velocity = motionVector * speed;
    }
}
