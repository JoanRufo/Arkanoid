using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    private GameManager m_GameManager;
    Vector3 VectorDireccion;
    public GameObject m_Brick;
    public float m_Speed;



    void Start()
    {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();


    }


    void Update()
    {

        
                   
            if (IntersectBounds(GetComponent<SpriteRenderer>(), m_Brick.GetComponent<SpriteRenderer>()) == true) { 
            {




                if (this.transform.position.x > m_Brick.GetComponent<SpriteRenderer>().bounds.min.x && this.transform.position.x < m_Brick.GetComponent<SpriteRenderer>().bounds.min.x + 1)
                {
                    VectorDireccion = this.transform.up + -this.transform.right;
                }
                else if (this.transform.position.x < m_Brick.GetComponent<SpriteRenderer>().bounds.max.x && this.transform.position.x > m_Brick.GetComponent<SpriteRenderer>().bounds.max.x - 2)
                {
                    VectorDireccion = this.transform.up + this.transform.right;
                }

                else
                {
                    VectorDireccion = this.transform.up;
                }
            

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





