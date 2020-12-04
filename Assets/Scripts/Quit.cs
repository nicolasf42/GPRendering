using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F42
{
    public class Quit : MonoBehaviour
    {
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}