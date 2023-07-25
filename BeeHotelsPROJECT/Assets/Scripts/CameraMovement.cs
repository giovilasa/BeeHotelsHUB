using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed; // Camera speed
    public float zoomSpeed; // Camera Zoom speed

    public Vector3 defaultPosition = new Vector3(-251.9f, 18.8f, 21.4f); // default position camera
    public Vector3 minBounds = new Vector3(-10f, -5f, -10f); // Minimum camera movement limits
    public Vector3 maxBounds = new Vector3(10f, 5f, 10f); // Maximum camera movement limits

    private bool isMovingCamera = false;
    private Vector3 lastMousePosition;

    public GameObject[] blockMovementObjects; // Objects that block camera movement


    // Start is called before the first frame update
    void Start()
    {
        transform.position = defaultPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if any blockMovementObjects are active
        bool shouldBlockMovement = false;
        foreach (GameObject obj in blockMovementObjects)
        {
            if (obj.activeSelf)
            {
                shouldBlockMovement = true;
                break;
            }
        }

        // Camera movement on X and Z axes
        if (Input.GetMouseButtonDown(1) && !shouldBlockMovement)
        {
            isMovingCamera = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isMovingCamera = false;
        }

        if (isMovingCamera && !shouldBlockMovement)
        {
            Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
            Vector3 movement = new Vector3(mouseDelta.x, 0f, mouseDelta.y) * movementSpeed * Time.deltaTime;
            Vector3 newPosition = transform.position + movement;
            newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
            newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);
            newPosition.z = Mathf.Clamp(newPosition.z, minBounds.z, maxBounds.z);
            transform.position = newPosition;

            lastMousePosition = Input.mousePosition;
        }

        // Camera movement along the Y axis
        if (!shouldBlockMovement)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            Vector3 scrollMovement = Vector3.up * scroll * zoomSpeed * Time.deltaTime;
            Vector3 newYPosition = transform.position + scrollMovement;
            newYPosition.y = Mathf.Clamp(newYPosition.y, minBounds.y, maxBounds.y);
            transform.position = newYPosition;
        }
    }
}

