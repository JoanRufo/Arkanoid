using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public GameObject m_bola;
    public Transform SpawnBola;
    public Text m_textPuntuacion;
    public Text m_textVidas;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void CrearBola(GameObject l_bola)
    {
        Instantiate(l_bola, SpawnBola.position, l_bola.transform.rotation);


    }


}
