using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f; // The upper value of the ground till where the animals are visible
    private float lowerBound = -10.0f; // The lower value of the ground till where the animals are visible

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the animals exceed the topbound value of the ground the animals will get destroyed
        if(transform.position.z > topBound)
        {
            Destroy(gameObject); //Command to destroy the gameobject (animals)
        }

        // If the animals exceed the lowerbound value of the ground Game Over message will be displayed and the animals will get destroyed
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over"); //Command to Display on the console
            Destroy(gameObject); //Command to destroy the gameobject (animals)
        }
    }
}
