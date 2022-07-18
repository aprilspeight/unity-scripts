using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Loads a scene when the R key is pressed
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("SceneOne");
        }

        // Switch between two scenes when 1 or 2 is pressed
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("SceneOne");
        }
        else if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("SceneTwo");
        }
    }
}
