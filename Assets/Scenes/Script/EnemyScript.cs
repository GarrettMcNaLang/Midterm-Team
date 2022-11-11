using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
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
        transform.position -= new Vector3(5f*Time.deltaTime, 0f, 0f);
    }
}
