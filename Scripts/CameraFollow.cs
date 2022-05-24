using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] GameObject Target;
    [SerializeField] Vector3 distance;

    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position + distance, Time.deltaTime);
    }
}
