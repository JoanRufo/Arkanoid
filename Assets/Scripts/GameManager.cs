using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public GameObject m_bola;
    public GameObject m_Nave;
    public Transform SpawnBola;
    public Text m_textPuntuacion;
    public Text m_textVidas;
    public bool playing = true;
    [HideInInspector] public int m_Puntuacion;
    [HideInInspector] public int m_Vidas = 3;
    public GameObject m_GameOverPanel;
    public GameObject m_MenuPrincipal;
    public GameObject m_Victoria;
    public int numero_bricks;
    public GameObject currentBola;
    public GameObject spawnBola;



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
                currentBola.GetComponent<Bola>().m_Speed = 0;
                currentBola.transform.position = spawnBola.transform.position;
                currentBola.transform.SetParent(m_Nave.transform);



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

