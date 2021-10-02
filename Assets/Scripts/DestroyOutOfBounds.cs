using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) // Destroy food that gets overboard
        {
            Destroy(gameObject); // Destroy current gameObject that script is applied to
        }
        else if (transform.position.z < lowerBound) // Destroy animal that gets past the player
        {
            Debug.Log("Game over!");
            Destroy(gameObject); // Destroy current gameObject that script is applied to
        }
    }
}
