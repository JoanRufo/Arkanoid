using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public float m_Speed;
    private GameManager m_GameManager;
    [HideInInspector] public Vector3 VectorDireccion;
    public GameObject m_Nave;


    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        VectorDireccion = this.transform.up;

	}

    void Update() {
        if (m_Speed > 0)
        {
            if (this.transform.position.x > 2.70f)
            {
               
                if (VectorDireccion.y > 0)
                {
                    VectorDireccion = this.transform.up + -this.transform.right;
                }
                   else if (VectorDireccion.y < 0)
                    {
                     VectorDireccion = -this.transform.up + -this.transform.right;
                    }
          
            }
            else if (this.transform.position.x < -6.50f)
            {
                
                if (VectorDireccion.y > 0)
                {
                    VectorDireccion = this.transform.up + this.transform.right;
                }
                else if (VectorDireccion.y < 0)
                {
                    VectorDireccion = -this.transform.up + this.transform.right;
                }

            }

            else if (this.transform.position.y > 2.975f)
            {
               
                if (VectorDireccion.x > 0)
                {
                    VectorDireccion = -this.transform.up + this.transform.right;
                }
                else if (VectorDireccion.x < 0)
                {
                    VectorDireccion = -this.transform.up + -this.transform.right;
                }
                else if (VectorDireccion.x >= 0)
                {
                    VectorDireccion = -this.transform.up;
                }
            }
             if (IntersectBounds(GetComponent<SpriteRenderer>(), m_Nave.GetComponent<SpriteRenderer>())==true)
            {
                
                
                
                   
             if(this.transform.position.x > m_Nave.GetComponent<SpriteRenderer>().bounds.min.x && this.transform.position.x < m_Nave.GetComponent<SpriteRenderer>().bounds.min.x + 1)
                    {
                        VectorDireccion = this.transform.up + -this.transform.right;
                    }
               else if (this.transform.position.x < m_Nave.GetComponent<SpriteRenderer>().bounds.max.x && this.transform.position.x > m_Nave.GetComponent<SpriteRenderer>().bounds.max.x - 2)
                {
                    VectorDireccion = this.transform.up + this.transform.right;
                }
                
               else 
                {
                    VectorDireccion = this.transform.up;
                }
            }
           
        }



        this.transform.position +=  VectorDireccion * Time.deltaTime * m_Speed;
        

        
        
    
    }
    public bool IntersectBounds(SpriteRenderer l_Ball, SpriteRenderer l_Nave)
    {
        return l_Ball.bounds.max.y > l_Nave.bounds.min.y
            && l_Ball.bounds.min.y < l_Nave.bounds.max.y
            && l_Ball.bounds.max.x > l_Nave.bounds.min.x
            && l_Ball.bounds.min.x < l_Nave.bounds.max.x;

    }
}
