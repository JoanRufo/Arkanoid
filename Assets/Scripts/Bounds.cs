using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour {

    public GameObject m_Nave;

	void Start () {

		
	}
	
	void Update () {

        IntersectBounds(GetComponent<SpriteRenderer>(), m_Nave.GetComponent<SpriteRenderer>());
	}


    public bool IntersectBounds (SpriteRenderer l_Ball, SpriteRenderer l_Nave)
    {
        return l_Ball.bounds.max.y > l_Nave.bounds.min.y
            && l_Ball.bounds.min.y < l_Nave.bounds.max.y
            && l_Ball.bounds.max.x > l_Nave.bounds.min.x
            && l_Ball.bounds.min.x < l_Nave.bounds.max.x;

    }
}
