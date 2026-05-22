using System;
using System.Collections.Generic;
using UnityEngine;



public class ListSorter : MonoBehaviour
{

    [SerializeField] float[] number;

    [SerializeField] private List<float> listOfNumber;
    List<int> listofints;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start");

    }

    private void OnCustomDestroy()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
