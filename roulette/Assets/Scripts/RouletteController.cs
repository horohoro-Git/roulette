using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed;
    void Start()
    {
        
    }

    void Update()
    {


        //1ȭ���� ������ ����
        bool isButtonDown = Input.GetMouseButtonDown(0);
        if (isButtonDown)
        {
            //   Debug.Log("AAa");
            rotSpeed = Random.Range(10f, 20f);
        }
        bool isButtonDown2 = Input.GetMouseButtonDown(1);
        if (isButtonDown2)
        {
            //   Debug.Log("AAa");
            rotSpeed = Random.Range(-10f, -20f);
        }



        //2 ȸ��
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed = rotSpeed * 0.96f;
    }
}
