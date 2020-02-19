using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public float m_Speed;
    private GameManager m_GameManager;


    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
		
	}

    void Update() {


        
        
            this.transform.position +=  this.transform.up * Time.deltaTime * m_Speed;
        

        
        
            
        

    }
}
