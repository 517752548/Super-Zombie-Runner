using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour {

    private Animator animator;
    private InputState inputState;

    private void Awake() {
        animator = GetComponent<Animator>();
        inputState = GetComponent<InputState>();
    }

	// Update is called once per frame
	void Update () {
        var running = true;
        running = !(inputState.absVelocityX > 0 && inputState.absVelocityY < inputState.standingThreshold);
        animator.SetBool("Running", running);
	}
}
