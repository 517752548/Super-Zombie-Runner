using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public void ManipulateTime(float newTime, float duration) {
        if (Time.timeScale == 0) Time.timeScale = 0.1f;
        StartCoroutine(FadeTo(newTime, duration));
    }

    IEnumerator FadeTo(float val, float time) {

        for (float t = 0f; t < 1; t += Time.deltaTime / time) {
            Time.timeScale = Mathf.Lerp(Time.timeScale, val, t);
            if (Mathf.Abs(val - Time.timeScale) < 0.01f) {
                Time.timeScale = val;
                break;
            }
            yield return null;
        }
    }
}
