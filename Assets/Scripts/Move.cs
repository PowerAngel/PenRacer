using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject raceCar;
    private Vector2 mousePosition;
    private float lookAtPoint;
    private float rotationNumber = 0;
    public float speed = 10;
    private bool hasClicked = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //raceCar.transform.Translate(Vector3.forward * Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lookAtPoint = Input.mousePosition.z;
            mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
            hasClicked = true;
        }

        if(hasClicked)
        {
            rotationNumber = rotationNumber + 0.1f;
            //raceCar.transform.rotation = new Quaternion(0, 0, rotationNumber, rotationNumber);
            //raceCar.transform.LookAt(new Vector3(0,0,lookAtPoint));
            float raceSpeed = speed * Time.deltaTime;
            raceCar.transform.position = Vector3.MoveTowards(raceCar.transform.position, mousePosition, raceSpeed);
            //raceCar.transform.Translate(Vector3.right * Time.deltaTime);
        }

    }
}
