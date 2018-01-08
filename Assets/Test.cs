using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] arraa = { 564, 349, 984, 516, 208 };
        for (int b = 0; b < arraa.Length; b++)
        {
            Debug.Log(arraa[b]);
        }
        for (int a = arraa.Length - 1; a >= 0; a--)
        {
            Debug.Log(arraa[a]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
