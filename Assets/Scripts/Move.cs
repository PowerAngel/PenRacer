using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject raceCar;
    private Vector3 mousePosition;
    public float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //raceCar.transform.Translate(Vector3.forward * Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);
        }

        float raceSpeed = speed * Time.deltaTime;
        raceCar.transform.position = Vector3.MoveTowards(raceCar.transform.position, mousePosition, raceSpeed);
        //raceCar.transform.Translate(Vector3.right * Time.deltaTime);
	}
}
