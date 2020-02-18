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


        if (Input.GetAxis("Vertical") > -4 && this.transform.position.y < 15.605f)
        {
            this.transform.position +=  this.transform.up * Time.deltaTime * m_Speed;
        }

        
        
            
        

    }
}
