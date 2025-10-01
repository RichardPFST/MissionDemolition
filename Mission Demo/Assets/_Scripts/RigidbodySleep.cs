using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class RigidbodySleep : MonoBehaviour
{
    private int sleepCountdown = 4;
    private Rigidbody rigid;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();

    }
    

    // Update is called once per frame
    void Update()
    {
        if (sleepCountdown > 0)
        {
            rigid.Sleep();
            sleepCountdown--;
        }
    }
}
