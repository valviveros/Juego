using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapView : MonoBehaviour
{
    PlayerItems playerItems;
    public bool enterMap;
    public GameObject mapBorder;
    public GameObject locationIcon;
    public SpriteRenderer spriteRenderer;
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerItems = GetComponent<PlayerItems>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && !enterMap)
        {
            Debug.Log("MAPA ENTRA");
            enterMap = true;
            mapBorder.SetActive(true);
            locationIcon.SetActive(true);
            spriteRenderer.enabled = false;
        } else if (Input.GetKeyDown(KeyCode.M) && enterMap)
        {
            Debug.Log("MAPA SALE");
            enterMap = false;
            mapBorder.SetActive(false);
            locationIcon.SetActive(false);
            spriteRenderer.enabled = true;
        }
        
    }

}
