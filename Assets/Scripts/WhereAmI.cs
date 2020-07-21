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
            maxPosition.x = 131.2f;
            maxPosition.y = 68.96f;
            minPosition.x = 15.71f;
            minPosition.y = -5.98f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio")
        {
            maxPosition.x = 9.2f;
            maxPosition.y = 4.8f;
            minPosition.x = -0.21f;
            minPosition.y = -9.21f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio2F")
        {
            maxPosition.x = 9.2f;
            maxPosition.y = 4.88f;
            minPosition.x = -0.19f;
            minPosition.y = -11.85f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIBiblio3F")
        {
            maxPosition.x = 9.13f;
            maxPosition.y = 4.76f;
            minPosition.x = -0.18f;
            minPosition.y = -3.88f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP1")
        {
            maxPosition.x = 6.32f;
            maxPosition.y = -1.03f;
            minPosition.x = -38.3f;
            minPosition.y = -4.03f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP2")
        {
            maxPosition.x = -24.72f;
            maxPosition.y = -12.93f;
            minPosition.x = -38.34f;
            minPosition.y = -15.55f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP3")
        {
            maxPosition.x = -37.72f;
            maxPosition.y = -23.09f;
            minPosition.x = -67.32f;
            minPosition.y = -24.97f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP4")
        {
            maxPosition.x = 5.31f;
            maxPosition.y = -1.06f;
            minPosition.x = -39.29f;
            minPosition.y = -3.96f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP5")
        {
            maxPosition.x = -25.35f;
            maxPosition.y = -12.84f;
            minPosition.x = -39.23f;
            minPosition.y = -15.43f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICedroP6")
        {
            maxPosition.x = -37.68f;
            maxPosition.y = -23.26f;
            minPosition.x = -67.29f;
            minPosition.y = -25.05f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmICafeteriaP1")
        {
            maxPosition.x = 7.3f;
            maxPosition.y = 25f;
            minPosition.x = -16.3f;
            minPosition.y = -5f;
        } else if (col.CompareTag("Player") && room.name == "WhereAmIEnfermeria")
        {
            maxPosition.x = 9.34f;
            maxPosition.y = 4.87f;
            minPosition.x = -0.25f;
            minPosition.y = -10.97f;
        }
    }
}
