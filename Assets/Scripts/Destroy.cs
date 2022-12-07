using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Bullet")
        {
            Destroy(Wall);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
