using UnityEngine;
using System.Collections;

public class destruirautos : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	void Update ()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "final dragon")
        {

            Destroy(gameObject);
        }

    }


}
