using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

   
    private ParticleSystem pSystem;
    [SerializeField]
    private GameManager scoreScript;

	// Use this for initialization
	void Start () {
       
        pSystem = GetComponentInChildren<ParticleSystem>();
    }
	
	

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            scoreScript.IncreaseScore();
            //Particle effect
            pSystem.Play();

           
        }

    }
}
