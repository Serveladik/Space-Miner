﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGeneration : MonoBehaviour
{
    public Transform rockPrefab;
    public int rangeRadius;
    public int rockCount;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < rockCount;i++)
        {
            Instantiate(rockPrefab,Random.insideUnitCircle * rangeRadius,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
