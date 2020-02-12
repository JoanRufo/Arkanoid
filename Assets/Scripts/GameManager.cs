using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject m_bola;
    public Transform SpawnBola;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void CrearBola(GameObject l_bola)
    {
        Instantiate(l_bola, SpawnBola.position, l_bola.transform.rotation);


    }


}
