using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaTabuleiro : MonoBehaviour
{
    private bool isRotate;
    // Start is called before the first frame update
    void Start()
    {
        isRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            isRotate = !isRotate;
        }

        if (isRotate)
        {
            transform.Rotate(Vector3.up * 0.1f, Space.Self);
        }
        else
        {
            transform.Rotate(Vector3.up * 0, Space.Self);
        }

    }
}
