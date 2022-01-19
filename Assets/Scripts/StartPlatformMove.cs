using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatformMove : MonoBehaviour
{
    public GameObject Menu;
    private float speed = 5;

    // Update is called once per frame
    void Update()
    {
        if(Menu.GetComponent<MenuManagement>().gameIsStarted)
        {
            transform.Translate( Time.deltaTime * speed * Vector3.left);

        if(transform.position.x < -13.0f)
            Destroy(this.gameObject);
        }
    }
}
