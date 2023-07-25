using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollidersOnWindowFocus : MonoBehaviour
{
    public GameObject windowObject; // Reference to the window object
    public Collider[] collidersToDisable; // Array containing the Collider components to disable

    private void OnEnable()
    {
        // When the window is activated, it disables colliders
        DisableColliders();
    }

    private void OnDisable()
    {
        // When the window is deactivated, it re-enables the colliders
        EnableColliders();
    }

    private void DisableColliders()
    {
        // Disable colliders
        foreach (Collider collider in collidersToDisable)
        {
            collider.enabled = false;
        }
    }

    private void EnableColliders()
    {
        // Enable colliders
        foreach (Collider collider in collidersToDisable)
        {
            collider.enabled = true;
        }
    }
}
