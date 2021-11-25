using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificaCameras : MonoBehaviour
{
    public Camera[] cameras;
    public int cameraAtual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cameraAtual++;
            if(cameraAtual == cameras.Length)
            {
                cameraAtual = 0;
            }
        }
        for(int i = 0; i < cameras.Length; i++)
        {
            if(i != cameraAtual)
            {
                cameras[i].depth = 0;
            }
        }
        cameras[cameraAtual].depth = 1;
    }
}
