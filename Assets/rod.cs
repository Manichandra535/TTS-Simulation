using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rod : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rod"))
        {
            particle.SetActive(true);
            GameObject.FindGameObjectWithTag("rod").GetComponent<Renderer>().enabled = true;
            //MeshRenderer render = cylinder.GetComponent<MeshRenderer>();


        }
    }


}