using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody m_bird;
    public GameObject m_gameObject;
    public float m_force = 6f;


    void Start()
    {
        m_bird = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_bird.AddForce(Vector3.up * m_force, ForceMode.Impulse);
            m_bird.velocity = new Vector3 (0f, 0f, 0f);
        }
    }
}
