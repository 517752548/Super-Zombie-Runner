using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour {

    public float offset = 16f;
    public delegate void OnDestroy();
    public event OnDestroy DestroyCallback;

    private bool offscreen;
    private float offscreenX = 0.0f;
    private Rigidbody2D body2d;

    private void Awake() {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        offscreenX = (Screen.width / PixelPerfectCamera.pixelsToUnits) / 2 + offset;
	}
	
	// Update is called once per frame
	void Update () {
        var posX = transform.position.x;
        var dirX = body2d.velocity.x;

        if (dirX < 0 && posX < -offscreenX) offscreen = true;
        else if (dirX > 0 && posX > offscreenX) offscreen = true;
        else offscreen = false;

        if (offscreen) OutOfBounds();
	}

    public void OutOfBounds() {
        offscreen = false;
        GameObjectUtility.Destroy(gameObject);

        if (DestroyCallback != null) DestroyCallback();
    }
}
