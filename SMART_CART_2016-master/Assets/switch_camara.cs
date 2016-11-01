using UnityEngine;
using System.Collections;

public class switch_camara : MonoBehaviour
{
    public Camera[] cameras;
    int i = 0;
    private int currentCameraIndex, total = 0;

    // Use this for initialization
    void Start()
    {
        currentCameraIndex = 0;
        for (i=1; i<cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false); total++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);

            currentCameraIndex++;
            if (currentCameraIndex < cameras.Length)
            {
                cameras[currentCameraIndex].gameObject.SetActive(true);
            }
            else
            {
                cameras[currentCameraIndex-1].gameObject.SetActive(false);
                currentCameraIndex = 0;
                cameras[currentCameraIndex].gameObject.SetActive(true);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);

            currentCameraIndex--;
            if (currentCameraIndex < 0)
            {
                cameras[currentCameraIndex+1].gameObject.SetActive(false);
                currentCameraIndex = total;
                cameras[currentCameraIndex].gameObject.SetActive(true);
            }

            else
            {
                cameras[currentCameraIndex].gameObject.SetActive(true);
            }
            
        }
    }
}
