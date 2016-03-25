using UnityEngine;
using System.Collections;

public class MotionEventHandler : MonoBehaviour {

	Animator animator;
	int StateInt;

	void Start()
	{
		animator = gameObject.GetComponent<Animator> ();
	}
	public void OnMotionStart()
	{
		//FixCode///////////////////////////////////
		animator.SetInteger ("State", -1);
		/////////////////////////////////////////////
		StateInt = animator.GetInteger ("State");
		if (StateInt== 0) {
			
		} else {
			Debug.Log ("OnMotionStart() StateInt="+StateInt);
		}
	}
	public void OnMotionEnd()
	{
		//animator.SetInteger ("State", 0);
		StateInt = animator.GetInteger ("State");
		if (StateInt == 0) {

		} else {
			Debug.Log ("OnMotionEnd() StateInt="+StateInt);
		}

	}



}
