using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject m_prefab;

    void Start()
    {
        StartCoroutine(PreFabSpawn());
    }

    IEnumerator PreFabSpawn()
    {   
        while (true)
        {
            int i = 6;
            Instantiate(m_prefab, new Vector3(i * (Random.Range(8f, 8f)), (Random.Range(-2.0f, 5.0f)), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }                                                                                                               
}
