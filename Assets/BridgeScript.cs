using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeScript : MonoBehaviour
{
	public GameObject newstage;
	public GameObject gameController;
	private static bool longer = false;
	private static bool roro = false;
	private static int cool = 90;
    private bool transition = false;
	private float distance = 0;
	private float time = 0;
	// Start is called before the first frame update
    public bool checkthedis()
	{
		gameController = GameObject.Find("GameController");
		GameController cs = gameController.GetComponent<GameController>();


		//gameController.Score++;
		//position - original position - length of object
		Debug.Log("Here dis"+time*0.015);
		if ((distance + 2.3-0.5)>0.015*time+0.05){
			cs.gameover = true;
			Destroy(gameObject);
			return false;
			
		}
		if ((distance + 2.3 + 0.5)< 0.015 * time+0.05){
			cs.gameover = true;
			Destroy(gameObject);
			return false;
			
		}
		cs.Score++;
		cs.timetomove = true;
		return true;
	}
	void Start()
    {
		distance = Random.Range(0.0f, 3.0f);
		Vector3 spawnPosition = new Vector3(distance, -6.5F, 0);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(newstage, spawnPosition, spawnRotation);
	}

    // Update is called once per frame
    void Update()
    {
        
		if (transition)//moving to next stage
		{
			transform.Translate(0f, -0.05f, 0f);
			if (transform.position.x < -10)
			{

				Destroy(gameObject);

			}

		}
		else if (roro)//rotate the bridge
		{
			transform.Rotate(0, 0, -1);
			if (transform.eulerAngles.z <= 270)
			{
				roro = false;
				transition = checkthedis();
			}
		}
		else if (Input.anyKey&&cool<0)// check when to stop
		{
			if (longer) 
				roro = true;
			longer = !longer;
			cool = 30;
		}
		else if (longer) {// if the bridge is longer
			Vector3 scale = new Vector3(0,0.03F, 0);
			transform.localScale += scale;
			time++;
		}
		cool--;


		
		
        
	}
}
