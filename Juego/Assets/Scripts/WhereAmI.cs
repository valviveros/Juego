using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereAmI : MonoBehaviour
{
    public GameObject room;
    static public Vector2 maxPosition;
    static public Vector2 minPosition;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && room.name == "WhereAmI1")
        {
            Debug.Log("Estoy en la Room1");
            maxPosition.x = 2.28f;
            maxPosition.y = 10f;
            minPosition.x = -10.31f;
            minPosition.y = -1.93f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmI2")
        {
            Debug.Log("Estoy en la Room2");
            maxPosition.x = 2.28f;
            maxPosition.y = 39.96f;
            minPosition.x = -10.31f;
            minPosition.y = 20f;
        }else if (col.CompareTag("Player") && room.name == "WhereAmI3")
        {
            Debug.Log("Estoy en la Room3");
            maxPosition.x = 37.31f;
            maxPosition.y = 7.94f;
            minPosition.x = 2.28f;
            minPosition.y = -1.93f;
        }
    }
}
