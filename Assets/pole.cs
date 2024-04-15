using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pole : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pole"))
        {
            particle.SetActive(true);
            GameObject.FindGameObjectWithTag("pole").GetComponent<Renderer>().enabled = true;
            //MeshRenderer render = cylinder.GetComponent<MeshRenderer>();


        }
    }


}