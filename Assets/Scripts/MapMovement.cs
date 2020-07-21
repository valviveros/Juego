using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public float speed;
    private Rigidbody2D myRigidbody;
    MapView mapView;
    private WhereAmI WhereAmI;
    
    // Start is called before the first frame update
    void Start()
    {
        mapView = GameObject.FindObjectOfType<MapView>();
        WhereAmI = GetComponent<WhereAmI>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mapView.enterMap)
        {
            speed = 10;
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
            myRigidbody.velocity = movement * speed;
            myRigidbody.position = new Vector3
            (
                Mathf.Clamp(myRigidbody.position.x, WhereAmI.minPosition.x, WhereAmI.maxPosition.x),
                Mathf.Clamp(myRigidbody.position.y, WhereAmI.minPosition.y, WhereAmI.maxPosition.y),
                5f
            );
        }
        else
        {
            if (transform.position != target.position)
            {
                Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
                targetPosition.x = Mathf.Clamp(targetPosition.x, WhereAmI.minPosition.x, WhereAmI.maxPosition.x);
                targetPosition.y = Mathf.Clamp(targetPosition.y, WhereAmI.minPosition.y, WhereAmI.maxPosition.y);
                transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
            }
        }
    }
}
