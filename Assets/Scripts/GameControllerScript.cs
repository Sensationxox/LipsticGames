using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

    public new Camera camera;

    void Start () {
	
	}

	void Update () {
        if (camera.GetComponent<CameraResoliutionScript>().fight)
        {
            camera.GetComponent<CameraResoliutionScript>().fight = false;
            camera.GetComponent<CameraResoliutionScript>().speed = 0f;
            //initiate fight: spawn enemies & etc....
            StartCoroutine(Wait()); //this is fight ... write if (fight.End == true) { camera speed = 100f}
        }
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5); //this is not after 10 seconds, but after fight
        camera.GetComponent<CameraResoliutionScript>().speed = 100f;
    }
}
