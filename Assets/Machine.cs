using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public GameObject particle;
    //public GameObject cylinder;
    //public MeshRenderer render;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("equator"))
        {
            particle.SetActive(true);
            GameObject.FindGameObjectWithTag("equator").GetComponent<Renderer>().enabled = true;
            //MeshRenderer render = cylinder.GetComponent<MeshRenderer>();


        }
    }

    private void OnTriggerExit(Collider other)
    {
        particle.SetActive(false);
    }

}
