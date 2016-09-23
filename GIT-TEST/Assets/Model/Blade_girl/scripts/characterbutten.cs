using UnityEngine;
using System.Collections;

public class characterbutten : MonoBehaviour
{


	public GameObject frog;
	
	
	
	private Rect FpsRect ;
	private string frpString;
	
	private GameObject instanceObj;
	
	float minimum = 2.0f;
	float maximum = 50.0f;
	float touchNum = 0f;
	string touchDirection ="forward"; 
	private GameObject blade_girl;
	
	// Use this for initialization
	void Start () {
		
		//frog.animation["dragon_03_ani01"].blendMode=AnimationBlendMode.Blend;
		//frog.animation["dragon_03_ani02"].blendMode=AnimationBlendMode.Blend;
		//Debug.Log(frog.GetComponent("dragon_03_ani01"));
		
		//Instantiate(gameObjArray[0], gameObjArray[0].transform.position, gameObjArray[0].transform.rotation);
	}
	
 void OnGUI() {
	  if (GUI.Button(new Rect(20, 20, 70, 40),"Idle")){
		 frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Idle");
            BoardCast();

	  }
	    if (GUI.Button(new Rect(90, 20, 70, 40),"Walk")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Walk");
            BoardCast();

	  }
		  if (GUI.Button(new Rect(160, 20, 70, 40),"L_Walk")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("L_Walk");
            BoardCast();

	  }
		  if (GUI.Button(new Rect(230, 20, 70, 40),"R_Walk")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("R_Walk");
            BoardCast();

	  }
		  if (GUI.Button(new Rect(300, 20, 70, 40),"B_Walk")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("B_Walk");
            BoardCast();

	  }
	     if (GUI.Button(new Rect(370, 20, 70, 40),"Talk")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Talk");
            BoardCast();

	  } 
		if (GUI.Button(new Rect(440, 20, 70, 40),"Run")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Run00");
            BoardCast();

	  }  
		if (GUI.Button(new Rect(510, 20, 70, 40),"L_Run")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("L_Run00");
            BoardCast();
            
	  }  
		if (GUI.Button(new Rect(580, 20, 70, 40),"R_Run")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("R_Run00");
            BoardCast();

	  }  
		if (GUI.Button(new Rect(650, 20, 70, 40),"B_Run")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("B_Run00");
            BoardCast();

	 }  
			if (GUI.Button(new Rect(720, 20, 70, 40),"Jump")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Jump_NoBlade");
            BoardCast();

	  } 
		if (GUI.Button(new Rect(20, 65, 70, 40),"Draw Blade")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Once;
		  	frog.GetComponent<Animation>().CrossFade("DrawBlade");
            BoardCast();

	  } 
		if (GUI.Button(new Rect(90, 65, 70, 40),"AtkStandy")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("AttackStandy");
            BoardCast();

	  } 
		if (GUI.Button(new Rect(160, 65, 70, 40),"Attack00")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Attack00");
            BoardCast();

	  } 
		if (GUI.Button(new Rect(230, 65, 70, 40),"Attack01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Attack");
            BoardCast();

			
		}	
		if (GUI.Button(new Rect(300, 65, 70, 40),"Block")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Block");
            BoardCast();

	  } 
			if (GUI.Button(new Rect(370, 65, 70, 40),"Attack02")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Attack01");
            BoardCast();

	  } 
			if (GUI.Button(new Rect(440, 65, 70, 40),"Combo")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("ComboAttack");
            BoardCast();

	  }
			if (GUI.Button(new Rect(510, 65, 70, 40),"Skill")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Skill");
            BoardCast();

	  }
			if (GUI.Button(new Rect(580, 65, 70, 40),"M_Avoid")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("M_Avoid");
            BoardCast();

	  }
			if (GUI.Button(new Rect(650, 65, 70, 40),"L_Avoid")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("L_Avoid");
            BoardCast();

	  }
			if (GUI.Button(new Rect(720, 65, 70, 40),"R_Avoid")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("R_Avoid");
            BoardCast();

	  }
			if (GUI.Button(new Rect(20, 110, 70, 40),"Buff")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Buff");
            BoardCast();

	  }
		if (GUI.Button(new Rect(90, 110, 70, 40),"Run01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Run");
            BoardCast();

	  }
		if (GUI.Button(new Rect(160, 110, 70, 40),"L_Run01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("L_Run");
            BoardCast();

	  }
		if (GUI.Button(new Rect(230, 110, 70, 40),"R_Run01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("R_Run");
            BoardCast();

	  }
		if (GUI.Button(new Rect(300, 110, 70, 40),"B_Run01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("B_Run");
            BoardCast();

	  }
		
		if (GUI.Button(new Rect(370, 110, 70, 40),"Jump01")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("jump");
            BoardCast();

	  }
		if (GUI.Button(new Rect(440, 110, 70, 40),"PickUp")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Pickup");
            BoardCast();

	  }
		
			if (GUI.Button(new Rect(510, 110, 70, 40),"Damage")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Damage");
            BoardCast();

	  }
			if (GUI.Button(new Rect(580, 110, 70, 40),"Death")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Death");
            BoardCast();

	  }
		if (GUI.Button(new Rect(650, 110, 120, 40),"GangnamStyle")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("GanamStyle");
            BoardCast();

	  }
				if (GUI.Button(new Rect(620, 470, 120, 40),"Ver 2.1")){
		  frog.GetComponent<Animation>().wrapMode= WrapMode.Loop;
		  	frog.GetComponent<Animation>().CrossFade("Idle");
                    BoardCast();
	  }
 }


    void BoardCast() {
        Messager.Broadcast("AnimationPlayClick");
    }
	
	// Update is called once per frame
	void Update () {
		
		//if(Input.GetMouseButtonDown(0)){
		
			//touchNum++;
			//touchDirection="forward";
		 // transform.position = new Vector3(0, 0,Mathf.Lerp(minimum, maximum, Time.time));
			//Debug.Log("touchNum=="+touchNum);
		//}
		/*
		if(touchDirection=="forward"){
			if(Input.touchCount>){
				touchDirection="back";
			}
		}
	*/
		 
		//transform.position = Vector3(Mathf.Lerp(minimum, maximum, Time.time), 0, 0);
	if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
		//frog.transform.Rotate(Vector3.up * Time.deltaTime*30);
	}
	
}
