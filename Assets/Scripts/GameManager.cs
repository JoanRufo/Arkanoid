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
    public bool playing = true;
    [HideInInspector] public int m_Puntuacion;
    [HideInInspector] public int m_Vidas = 5;
    public GameObject m_GameOverPanel;
    public GameObject m_MenuPrincipal;
    public GameObject m_Victoria;
    public int numero_bricks;

    void Start() {

    }

    void Update()
    {
        if (playing == true)
        {
            m_textPuntuacion.text = "Puntos: " + m_Puntuacion;
            m_textVidas.text = "Vidas: " + m_Vidas;

            if (m_Vidas <= 0)
            {
                m_GameOverPanel.SetActive(true);

            }


            if (numero_bricks == 0)
            {
                m_Victoria.SetActive(true);
                
            }

        }


    }

        public void CrearBola(GameObject l_bola)
        {
            Instantiate(l_bola, SpawnBola.position, l_bola.transform.rotation);


        }



        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        public void StartGame()
        {
            playing = true;

            m_MenuPrincipal.SetActive(false);

        }


    public void EndLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

