using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float cameraHeight;

    [SerializeField]
    private float clampMaxX;
    
    [SerializeField]
    private float clampMinX;

    [SerializeField]
    private float clampMaxY;

    [SerializeField]
    private float clampMinY;
    

    // Start is called before the first frame update
    void Start() {
        cameraHeight = -cameraHeight;
    }

    // Called after the Update function, meaning that the player will move first then the camera will follow
    // This is from the 2d top-down RPG
    void LateUpdate() {
        float targetPositionX = Mathf.Clamp(target.transform.position.x, clampMinX, clampMaxX);
        float targetPositionY = Mathf.Clamp(target.transform.position.y, clampMinY, clampMaxY);

        transform.position = new Vector3(targetPositionX, targetPositionY, cameraHeight);
    }
}
