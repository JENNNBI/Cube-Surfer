using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveForwardSpeed;
    [SerializeField] float leftRightSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * leftRightSpeed * Time.deltaTime;
        this.transform.Translate(horizontal, 0, leftRightSpeed * Time.deltaTime);
    }
}
