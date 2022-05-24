using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;

    int index;
    public Collector collector;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
        
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            collector.DecraseHight();
            this.transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetisColledted()
    {
        return isCollected;
    }

    public void MakeCollected()
    {
        isCollected = true;
    }

    public void ArrangeIndex(int index)
    {
        this.index = index;
    }
}
