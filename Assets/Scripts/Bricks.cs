using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    private GameManager m_GameManager;
    Vector3 VectorDireccion;
    public GameObject m_Brick;
    public float m_Speed;
    public GameObject m_Bola;
    public int vida_brick = 3;
    
   




    void Start()
    {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();


    }


    void Update()
    {



        if (IntersectBounds(m_Bola.GetComponent<SpriteRenderer>(), GetComponent<SpriteRenderer>()) == true && m_Bola.GetComponent<Bola>().currentCD >= m_Bola.GetComponent<Bola>().CDMax)
        {
            vida_brick--;

            m_Bola.GetComponent<Bola>().currentCD = 0;


            if (m_Bola.transform.position.x < m_Brick.GetComponent<SpriteRenderer>().bounds.min.x)//CHOCA IZQUIERDA
            {
                if (m_Bola.GetComponent<Bola>().VectorDireccion.y > 0)//hacia arriba
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = this.transform.up + -this.transform.right;
                }
                else //hacia abajo
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = -this.transform.up + -this.transform.right;
                }

            }
            else if (m_Bola.transform.position.x > m_Brick.GetComponent<SpriteRenderer>().bounds.max.x)//CHOCA DERECHA
            {
                if (m_Bola.GetComponent<Bola>().VectorDireccion.y > 0) //hacia arriba
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = this.transform.up + this.transform.right;
                }
                else //hacia abajo
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = -this.transform.up + this.transform.right;
                }
            }
            else if (m_Bola.transform.position.y < m_Brick.GetComponent<SpriteRenderer>().bounds.min.y) //CHOCA ABAJO
            {
                if (m_Bola.GetComponent<Bola>().VectorDireccion.x > 0) //hacia la derecha
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = -this.transform.up + this.transform.right;
                }
                else //hacia la izquierda
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = -this.transform.up + -this.transform.right;
                }
            }
            else if (m_Bola.transform.position.y > m_Brick.GetComponent<SpriteRenderer>().bounds.max.y) //CHOCA ARRIBA
            {
                if (m_Bola.GetComponent<Bola>().VectorDireccion.x > 0) //hacia la derecha
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = this.transform.up + this.transform.right;
                }
                else //hacia la izquierda
                {
                    m_Bola.GetComponent<Bola>().VectorDireccion = this.transform.up + -this.transform.right;
                }
            }

            m_GameManager.m_Puntuacion += 10;

            if (vida_brick == 0)
            {
                Destroy(this.gameObject);
                m_GameManager.m_Puntuacion += 100;
                m_GameManager.numero_bricks--;

            }


        }



        this.transform.position += VectorDireccion * Time.deltaTime * m_Speed;
    }



    public bool IntersectBounds(SpriteRenderer l_Ball, SpriteRenderer l_Brick)
    {
        return l_Ball.bounds.max.y > l_Brick.bounds.min.y
            && l_Ball.bounds.min.y < l_Brick.bounds.max.y
            && l_Ball.bounds.max.x > l_Brick.bounds.min.x
            && l_Ball.bounds.min.x < l_Brick.bounds.max.x;

    }

}





