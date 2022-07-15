using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Assign the prefab in the editor
    public GameObject prefab;

    void Start()
    {
        // Spawns a prefab at the default position 0, 0, 0 with a default rotation 0, 0, 0
        //Instantiate(prefab);

        // Spawns a prefab at a specific position with no rotation
        //Instantiate(prefab, new Vector3(2, 2, -2), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        // Spawns a prefab when a key is pressed
        /*if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab);
        }*/
    }
}
