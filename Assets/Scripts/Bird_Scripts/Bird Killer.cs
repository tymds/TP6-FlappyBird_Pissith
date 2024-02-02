using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Killer : MonoBehaviour
{
    public Rigidbody m_bird;

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(m_bird.gameObject);
        }   

    }    
}
