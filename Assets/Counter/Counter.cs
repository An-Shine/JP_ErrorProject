using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Counter : MonoBehaviour
{
    public GameObject[] Spheres;
    public Text CounterText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
        //공 중에 10개만 무작위로 선택, 
        for(int i = 0; i < 10; i++)
        {
            int idx = Random.Range(0, Spheres.Length);
            Spheres[idx].transform.position = new Vector3(Random.Range(-1.0f, 1.0f), 12, Random.Range(-1.0f, 1.0f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }
}
