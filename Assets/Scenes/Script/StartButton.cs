using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public bool Start;
    public GameObject Startmenu;

    private void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 0.1f);
        //if (hit.collider != null)
        {
            Start = false;
            Startmenu.SetActive(true);

            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Start == false && Startmenu ==true)
        {
           // GetComponent<Rigidbody2D>().velocity = new Vector3(0, 3f, 0);
            Start = true;
            Startmenu.SetActive(false);

            Time.timeScale = 1f;   
            
        }
    }


}
