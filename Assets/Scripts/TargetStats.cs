using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStats : MonoBehaviour
{
    public GameObject Wall;

    public float Health;

    void Start()
    {

    }


    void Update()
    {
        Die();
    }
    public void Die()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
            Destroy(Wall);
        }
    }

}
