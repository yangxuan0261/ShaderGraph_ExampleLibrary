using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TouchMove : MonoBehaviour {

    public GameObject target;

    void Start() {

    }

    void Update() {
        if (target == null) {
            return;
        }

        if (Input.touchCount == 1) {
            if (Input.touches[0].phase == TouchPhase.Moved) {
                // 手指滑动时，要触发的代码 
                float s01 = Input.GetAxis("Mouse X");
                float s02 = Input.GetAxis("Mouse Y");
                Debug.LogFormat("{0}, {1}", s01, s02);
            }
        }
    }
}