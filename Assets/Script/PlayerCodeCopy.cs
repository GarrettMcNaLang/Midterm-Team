using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCodeCopy : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    
    void Update()
    {

        float InputX = Input.GetAxis("Horizontal");
        float InputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * InputX, speed.y * InputY, 0);
        //(speed * Time.deltaTime);
        

        movement *= Time.deltaTime;

        transform.Translate(movement);

       

    }

}