using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour {
    enum MovingAxis {x,y,z};

    public float movePeriod = 2.0f;
    public float amplitude = 0.2f;

    private Vector3 initialPosition;
    private MovingAxis movingAxis;

	// Use this for initialization
	void Start () {
        movingAxis = (MovingAxis)Random.Range(0, 3);
        initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float moveDegree = amplitude * Mathf.Sin(Time.realtimeSinceStartup / movePeriod * 2 * Mathf.PI);
        switch (movingAxis) {
            case MovingAxis.x:
                transform.position = new Vector3(initialPosition.x + moveDegree, initialPosition.y, initialPosition.z);
                break;
            case MovingAxis.y:
                transform.position = new Vector3(initialPosition.x, initialPosition.y + moveDegree, initialPosition.z);
                break;
            case MovingAxis.z:
                transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z + moveDegree);
                break;
        }
	}
}
