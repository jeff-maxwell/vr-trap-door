using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    private int countdown = 5;
    private int counter = 0;
    Animation animation;

    void Start()
    {
        animation = GetComponent<Animation>();
    }
    
    void Update()
    {
        if (counter > countdown * 60)
        {
            animation.wrapMode = WrapMode.Once;
            gameObject.GetComponent<Animation>().Play();
        }   
        else
        {
            counter++;
        }
         
    }
}
