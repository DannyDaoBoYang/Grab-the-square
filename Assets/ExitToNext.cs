using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitToNext : MonoBehaviour //for stage
{


	public bool twice=false;
	
	void Start()
	{
		
		
	}

	// Update is called once per frame
	void Update()
	{
		GameObject gameController = GameObject.Find("GameController");
		GameController cs = gameController.GetComponent<GameController>();
		if (cs.gameover)
		{
			Destroy(gameObject);
		}
	    if (cs.timetomove)//moving to next stage
		{
			transform.Translate(-0.05f, 0f, 0f);

		}
		if (transform.position.x < -4)
		{
			
		    cs.timetomove = false;
			Destroy(gameObject);
			
			
		}
		
	}
}
