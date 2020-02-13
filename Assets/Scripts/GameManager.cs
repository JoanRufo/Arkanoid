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
    public bool playing = false;
    float currentCD_Vidas;
    public float CDMax_Vidas;
    [HideInInspector] public int m_Puntuacion;
    [HideInInspector] public int m_Vidas = 5;

    void Start() {

    }

    void Update()
    {
        if (playing == true)
        {
            if (currentCD_Vidas < CDMax_Vidas)
            {
                currentCD_Vidas += Time.deltaTime;


                m_textPuntuacion.text = "Puntuación:" + m_Puntuacion;
                m_textVidas.text = "Vidas:" + m_Vidas;
            }
            if (currentCD_Vidas >= CDMax_Vidas)
            {
                currentCD_Vidas = 0;
            }
        }
    }

        public void CrearBola(GameObject l_bola)
        {
            Instantiate(l_bola, SpawnBola.position, l_bola.transform.rotation);


        }
    }

