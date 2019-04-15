using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour {

    public Vector2 veloicity = Vector2.zero;
    public Rigidbody2D body2D;

    private void Awake() {
        body2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        body2D.velocity = veloicity;
    }
}
