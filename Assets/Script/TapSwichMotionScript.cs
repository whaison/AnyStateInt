using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class TapSwichMotionScript : MonoBehaviour,IPointerClickHandler {


	Animator animator;

	string buttonName;
	// Use this for initialization
	void Start () {
		buttonName = gameObject.name;
		Debug.Log ("buttonName="+buttonName);
		Debug.Log ("シーン名　Application.loadedLevelName= "+Application.loadedLevelName);
	
		if (Application.loadedLevelName == "AnyStateInt") {
			try {
				animator = GameObject.Find ("FMSkeleton").GetComponent<Animator> ();
			} catch (System.NullReferenceException e) {
				Debug.Log ("e=" + e);
			}
		} else if (Application.loadedLevelName == "HasExitTime") {
			try {
				animator = GameObject.Find ("FMSkeleton_HasExitTime").GetComponent<Animator> ();
			} catch (System.NullReferenceException e) {
				Debug.Log ("e=" + e);
			}
		} else if (Application.loadedLevelName == "AnyStateIntFix") {
			try {
				animator = GameObject.Find ("FMSkeleton_Fix").GetComponent<Animator> ();
			} catch (System.NullReferenceException e) {
				Debug.Log ("e=" + e);
			}
		}
		

	}


	public void OnPointerClick (PointerEventData eventData)
	{
		switch (buttonName)
		{

		case "Attack":
			//animator.SetInteger ("State", -1);
			animator.SetInteger ("State", 100);
			//animator.CrossFade("AttackA",0.2f);
			//animator.SetInteger ("State", 0);
			//animator.CrossFade("AttackA",3.0f,0);
			//animator.CrossFadeInFixedTime("AttackA",0.2f);

			break;
		case "Skill":
			animator.SetInteger ("State", 200);
			//animator.CrossFade("Skill1A",0.2f);
			//animator.CrossFadeInFixedTime("Skill1A",0.2f);

			break;
		default:
			break;
		}
	}

		
}
