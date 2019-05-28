using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnife : MonoBehaviour {
	private float timer = 0.0f;
	private bool timeLimit = true;
	private string nextAnimation = "finger five animation";
	private Animation anim;
	public float speed = 50f;
	string level = "level three";

	 void Start()
	{
		//Vector3 temp = new Vector3(0, -5.0f * Time.deltaTime, 0);
		//transform.position += temp;
		anim = this.GetComponent<Animation> ();
	}  
	
	// Update is called once per frame
	void Update () {
		if (timeLimit != true) {
			
			transform.Translate (0, speed * Time.deltaTime, 0);

			if (Input.GetKeyDown ("space")) {
				timeLimit = true;
				print ("space bar pressed");
			}
		
			timer += Time.deltaTime;
			print (timer);

		}
		switch (nextAnimation) {
		case("finger one animation"):
			anim.Play ("MoveKnifeX");
			nextAnimation = "finger two animation";
			break;
		case("finger two animation"):
			anim.Play ("MoveKnifeX2");
			nextAnimation = "finger three animation";
			break;
		case("finger three animation"):
			anim.Play ("MoveKnifeX3");
			nextAnimation = "finger four animation";
			break;
		case("finger four animation"):
			anim.Play ("MoveKnifeX4");
			nextAnimation = "finger five animation";
			break;
		default:
			anim.Play ("MoveKnifeX5");
			nextAnimation = "finger one animation";
			break;
		}


		//anim.Play ("MoveKnifeX");

		//anim.Play ("MoveKnifeX2");
	
/*		switch(level) {
		case "level one":
		 	speed = 10f;
			print("level one");
			break;
		case "level two":
			speed = 20f;
			print("level two");
			break;
		case "level three":
			speed = 30f;
			print("level three");
			break; 
		} */
	//	transform.Translate (0, Time.deltaTime, 0);
	//	transform.Translate (Vector3.down * Time.deltaTime);
	}
}
