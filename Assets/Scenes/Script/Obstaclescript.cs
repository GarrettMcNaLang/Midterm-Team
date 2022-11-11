using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclescript : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy the other object
            Destroy(collision.gameObject);
        }
    }
    private void Update()
       
    {
        transform.position -= new Vector3(3f * Time.deltaTime, 0f, 0f);
       

    }
    
}
