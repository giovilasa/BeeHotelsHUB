using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float movementSpeed; // Camera speed
    public float zoomSpeed; // Camera Zoom speed

    public Vector3 defaultPosition = new Vector3(-251.9f, 18.8f, 21.4f); // default position camera
    public Vector2 minBoundsXY = new Vector2(-300f, 0f);
    public Vector2 maxBoundsXY = new Vector2(0f, 30f);
    public Vector2 minMaxBoundsZ = new Vector2(-27f, 21.4f);

    private bool isMovingCamera = false;
    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = defaultPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isMovingCamera = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isMovingCamera = false;
        }

        if (isMovingCamera)
        {
            Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
            Vector3 movement = new Vector3(mouseDelta.x, mouseDelta.y, 0f) * movementSpeed * Time.deltaTime;
            Vector3 newPosition = transform.position + movement;
            newPosition.x = Mathf.Clamp(newPosition.x, minBoundsXY.x, maxBoundsXY.x);
            newPosition.y = Mathf.Clamp(newPosition.y, minBoundsXY.y, maxBoundsXY.y);
            newPosition.z = Mathf.Clamp(newPosition.z, minMaxBoundsZ.x, minMaxBoundsZ.y);
            transform.position = newPosition;

            lastMousePosition = Input.mousePosition;
        }

        // Camera Zoom
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 zoom = scroll * zoomSpeed * Time.deltaTime * transform.forward;
        transform.Translate(zoom, Space.World);



    }
}

