using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Menu;
    public GameObject platformPreFabs;

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 400 == 0 && Menu.GetComponent<MenuManagement>().gameIsStarted)
        {
            InstantiatePlatform();
        }
    }

    void InstantiatePlatform()
    {
        GameObject platform = Instantiate(platformPreFabs);
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float posY = Random.Range(-2.0f,2.0f);

        platform.transform.position = new Vector3(posX, posY, posZ);
    }
}
