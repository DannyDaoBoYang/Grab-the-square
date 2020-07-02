using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comeout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		

	}

    // Update is called once per frame
    void Update()
    {
		needmoveup();
	}
    void needmoveup()
	{
		if (transform.position.y <= -3.6)
		{
			transform.Translate(0f, 0.1f, 0f);
		}
	}
}
