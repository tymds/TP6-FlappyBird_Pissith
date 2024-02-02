using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Mover : MonoBehaviour
    
{
    public GameObject m_pire;
    public float speed = 10.0f;

    void Update()
    {
        m_pire.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
