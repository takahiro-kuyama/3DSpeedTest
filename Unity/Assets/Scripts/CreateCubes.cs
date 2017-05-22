using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateCubes : MonoBehaviour {
    public int cubeNum = 1000;
    public bool moveCube = false;

	// Use this for initialization
	void Start () {
        System.Random rand = new System.Random();
        for (int i=0; i < cubeNum; i++) {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3((float)(rand.NextDouble() * 10 - 5), (float)(rand.NextDouble() * 10 - 5), (float)(rand.NextDouble() * 10 - 5));
            cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            cube.transform.parent = this.transform;
            if (moveCube) {
                cube.AddComponent<MovingCube>();
            }
        }
    }
}
