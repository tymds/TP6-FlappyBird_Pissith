using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Killer : MonoBehaviour
{
    public Rigidbody m_pire;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pire")
        {
            Destroy(collision.gameObject);
        }
    }
}
