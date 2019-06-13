using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnife : MonoBehaviour {
	private float timer = 0.0f;
	private bool timeLimit = false;
	private string nextAnimation = "finger five animation";
	private Animator anim;
	public float speed = 50f;
	string level = "level three";


	 void Start()
	{

	anim = GetComponent<Animator> ();
	}  
	
	// Update is called once per frame
	void Update () {

		
		if (timeLimit != true) {
			Vector3 goingUp = new Vector3 (0, speed * Time.deltaTime, 0);
			transform.position += goingUp;


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



	}
}
