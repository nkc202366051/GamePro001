using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
        using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{

    void Update()
    {
        {

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("taitoru");
            }
        }
    }

}

