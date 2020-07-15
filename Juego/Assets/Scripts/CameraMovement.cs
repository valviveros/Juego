using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    private WhereAmI WhereAmI;
    // Start is called before the first frame update
    void Start()
    {
        WhereAmI = GetComponent<WhereAmI>();
    }

    void LateUpdate()
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
