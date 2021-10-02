using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is called from MonoBehaviour everytime there is a collision
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destroy the gameObject that is attached with the DetectCollision script
        // Destroy(other.gameObject); // Destroy the other gameObject that was hit
    }
}
