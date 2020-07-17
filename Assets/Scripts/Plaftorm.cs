using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaftorm : MonoBehaviour
{
    public GameObject platformNo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        platformNo.gameObject.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D other) {
        platformNo.gameObject.SetActive(true);
    }
}
