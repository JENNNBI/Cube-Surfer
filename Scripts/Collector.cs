using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mCube;
    int hight;

    void Start()
    {
        mCube = GameObject.Find("MCube");
    }

    // Update is called once per frame
    void Update()
    {
        mCube.transform.position = new Vector3(transform.position.x, hight + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -hight, 0);
    }

    public void DecraseHight()
    {
        hight--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectableCube>().GetisColledted() == false) 
        {
            hight += 1;
            other.gameObject.GetComponent<CollectableCube>().MakeCollected();
            other.gameObject.GetComponent<CollectableCube>().ArrangeIndex(hight);
            other.gameObject.transform.parent = mCube.transform;
        }
    }
}
