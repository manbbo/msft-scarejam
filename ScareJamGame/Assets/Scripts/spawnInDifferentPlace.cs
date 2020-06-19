using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnInDifferentPlace : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int randomNumber = Random.Range(0, 5);

        switch (randomNumber)
        {
            case 0:
                this.transform.position = new Vector3(-14.37f, 1.145f - 0.13f, 10.95f);
                break;
            case 1:
                this.transform.position = new Vector3(-3.79f, 3.067f - 0.13f, -13.43f);
                break;
            case 2:
                this.transform.position = new Vector3(8.15f, 0.764f - 0.13f, 9.798f);
                break;
            case 3:
                this.transform.position = new Vector3(1.07f, -0.29f - 0.13f, 13.43f);
                break;
            case 4:
                this.transform.position = new Vector3(-14.837f, -0.335f - 0.13f, 10.95f);
                break;
            default:
                this.transform.position = new Vector3(6.82f, -0.33f - 0.13f, -13.93f);
                break;
        }

        Debug.Log("Glass " + randomNumber);
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
