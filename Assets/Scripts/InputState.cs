using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputState : MonoBehaviour {

    public bool actionButton;
    public float absVelocityX = 0f;
    public float absVelocityY = 0f;
    public bool standing;
    public float standingThreshold = 1;

    private Rigidbody2D body2d;

    private void Awake() {
        body2d = GetComponent<Rigidbody2D>();
    }
    
	// Update is called once per frame
	void Update () {
        actionButton = Input.anyKeyDown;	
	}

    private void FixedUpdate() {
        absVelocityX = System.Math.Abs(body2d.velocity.x);
        absVelocityY = System.Math.Abs(body2d.velocity.y);
        standing = (absVelocityY <= standingThreshold);
    }
}
