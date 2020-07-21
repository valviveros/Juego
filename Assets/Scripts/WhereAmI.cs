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
            maxPosition.x = 131.2f;
            maxPosition.y = 68.96f;
            minPosition.x = 15.71f;
            minPosition.y = -5.98f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio")
        {
            Debug.Log("Estoy en la Biblio1");
            maxPosition.x = 9.2f;
            maxPosition.y = 4.8f;
            minPosition.x = -0.21f;
            minPosition.y = -9.21f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio2F")
        {
            Debug.Log("Estoy en la Biblio2");
            maxPosition.x = 9.2f;
            maxPosition.y = 4.88f;
            minPosition.x = -0.19f;
            minPosition.y = -11.85f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio3F")
        {
            Debug.Log("Estoy en la Biblio3");
            maxPosition.x = 9.13f;
            maxPosition.y = 4.76f;
            minPosition.x = -0.18f;
            minPosition.y = -3.88f;
        }else if (col.CompareTag("Player") && room.name == "WhereAmICafeteriaP1")
        {
            Debug.Log("Estoy en la Biblio3");
            maxPosition.x = 7.22f;
            maxPosition.y = 24.96f;
            minPosition.x = -16.18f;
            minPosition.y = -2.9f;
        }
    }
}
