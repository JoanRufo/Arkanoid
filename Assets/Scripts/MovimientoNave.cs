using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour {

    public float m_Speed;
    public GameObject m_Nave;
    private GameManager m_GameManager;
    public float currentCD_bola;
    public float CDMax_bola;
    public GameObject m_bola;
    public Transform SpawnBola;
    public GameObject currentBola;







    void Start () {

        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();



    }
	

	private void Update () {

        if(Input.GetAxis("Horizontal")>0 && this.transform.position.x<1.95f)
        {
            this.transform.position += this.transform.right * Time.deltaTime * m_Speed;
            

        }

        else if (Input.GetAxis("Horizontal") < 0 && this.transform.position.x >-5.70f)  
            {


            this.transform.position += -this.transform.right * Time.deltaTime * m_Speed;

        }




        if (Input.GetKey(KeyCode.Space) && currentBola.GetComponent<Bola>().m_Speed == 0)
        {
            currentBola.GetComponent<Bola>().m_Speed = 5;
          
            currentBola.transform.SetParent(null);
        }





    }



    public void CrearBola(GameObject l_bola)
    {
        Instantiate(l_bola, SpawnBola.position, Quaternion.identity);

    }
}
