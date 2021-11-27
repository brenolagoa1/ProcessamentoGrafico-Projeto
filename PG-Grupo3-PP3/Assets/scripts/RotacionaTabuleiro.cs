using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionaTabuleiro : MonoBehaviour
{
    private bool isRotate;
    private bool moveRainha;
    private bool moveRei;
    private bool moveTorre;
    public CharacterController[] pecas;
    private int vez;
    // Start is called before the first frame update
    void Start()
    {
        isRotate = false;
        moveRainha = false;
        moveRei = false;
        moveTorre = false;
        vez = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            isRotate = !isRotate;
        }
        if(vez == 0 && Input.GetKeyDown(KeyCode.D))
        {
            moveRainha = true;
        }
        if(vez == 1 && Input.GetKeyDown(KeyCode.R))
        {
            moveRei = true;
        }
        if(vez == 2 && Input.GetKeyDown(KeyCode.T))
        {
            moveTorre = true;
        }

        if (isRotate)
        {
            transform.Rotate(Vector3.up * 0.1f, Space.Self);
            movePeace();

        }
        else
        {
            transform.Rotate(Vector3.up * 0, Space.Self);
            movePeace();
        }

    }

    private void movePeace()
    {
        if (vez == 0 && moveRainha)
        {
            if (pecas[vez].transform.localPosition.x < 0.77 && pecas[vez].transform.localPosition.z < 4.38)
            {
                pecas[vez].transform.Translate(1, 0, 1, Space.Self);
            }
            else
            {
                vez = 1;
            }
        }
        else if (vez == 1 && moveRei)
        {
            if (pecas[vez].transform.localPosition.x > 3.1)
            {
                pecas[vez].transform.Translate(-1, 0, 0, Space.Self);
            }
            else
            {
                vez = 2;
            }
        }
        else if (vez == 2 && moveTorre)
        {
            if (pecas[vez].transform.localPosition.z < -1.88)
            {
                pecas[vez].transform.Translate(0, 0, 1, Space.Self);
            }
            
        }
        if(vez == 3 && isRotate)
        {
            if (pecas[vez].transform.localPosition.x > 0.61)
            {
                pecas[vez].transform.Translate(-1, 0, 0, Space.Self);
            }
            else
            {
                vez = 0;
            }
        }
    }
}
