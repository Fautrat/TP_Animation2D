using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    private float speed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Time.deltaTime * speed * Vector3.left);

        if(transform.position.x < -13.0f)
            Destroy(this.gameObject);
    }
}
