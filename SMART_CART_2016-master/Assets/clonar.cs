using UnityEngine;
using System.Collections;

public class clonar : MonoBehaviour {

    public GameObject carro;
    GameObject nuevo;
    float posicion = 0.0f;
    int i = 0;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if (Random.Range(1, 101) % 100 == 0 && i <= 1000)
        {
            nuevo = GameObject.Instantiate(carro);
            nuevo.transform.position = this.transform.localPosition;
            i++;
        }
    }
}
