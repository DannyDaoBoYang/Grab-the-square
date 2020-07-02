using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
	
	public GameObject Player;
	public GameObject Cube;
	public GameObject Bridge;
	public int Score = 0;
	public bool timetomove = false;
	public bool moveon = false;
	public bool gameover = false;
	public Text scoretext;
	public Text GameOverText;
	// Start is called before the first frame update

	void Start()
    {
		Vector3 spawnPosition3 = new Vector3(-2.5F, -3.5F, 0);
		Quaternion spawnRotation3 = Quaternion.identity;
		Instantiate(Cube, spawnPosition3, spawnRotation3);

		Vector3 spawnPosition2 = new Vector3(-2.55F, -1.74F, 0);
		Quaternion spawnRotation2 = Quaternion.identity;
		Instantiate(Player, spawnPosition2, spawnRotation2);

		buildnext();
	}

    // Update is called once per frame
    void Update()
    {
		scoretext.text = "Score: " + Score;
		if (gameover)
		{
			scoretext.text = "";
            GameOverText.text= "Game Over \n Score: " + Score+"\n (Click anywhere to replay)";
			if (Input.anyKey)
			{
				Score = 0;
				timetomove = false;
				moveon = false;
				gameover = false;
				GameOverText.text = "";
				buildnext();
                
			}
		}

		if (timetomove)
		{
			moveon = true;
		}
		if (!timetomove && moveon)
		{
			buildnext();
			moveon = false;
		}
		//if clicked twice, check if the bridge is properly built
		
		//controllerScript cs = Bridge.GetComponent<BridgeScript>();
		//bool thisObjectMove = cs.transition;

        
	}
    public void buildnext()
	{
		Vector3 spawnPosition4 = new Vector3(-2.3F, -2.06F, 0);
		Quaternion spawnRotation4 = Quaternion.identity;
		Instantiate(Bridge, spawnPosition4, spawnRotation4);
	}
}
