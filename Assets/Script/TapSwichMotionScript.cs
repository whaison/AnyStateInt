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
		animator = GameObject.Find ("FMSkeleton").GetComponent<Animator> ();
	}


	public void OnPointerClick (PointerEventData eventData)
	{
		switch (buttonName)
		{

		case "Attack":
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
