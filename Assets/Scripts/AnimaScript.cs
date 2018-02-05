using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour {

	Animator animator;
	public float velocidade;
	SpriteRenderer spriteRender;

	void Start () {
		//Interface para o componente animator
		animator = GetComponent<Animator> ();	
		spriteRender = GetComponent<SpriteRenderer> ();
	}
		
	void Update () {
		//mover o personagem
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f,0.0f);

		//orientacao do sprite
		if (mover_x > 0.0f) {
			spriteRender.flipX = false;
		} else if(mover_x < 0.0f){
			spriteRender.flipX = true;
		}

		//reproduz a animacao
		animator.SetFloat("pMover", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
	}
}
