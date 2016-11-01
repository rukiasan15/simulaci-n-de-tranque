using UnityEngine;
using System.Collections;

public class muere_xander : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "final xander")
        {

            Destroy(gameObject);
        }

    }
}
