using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Colliders : MonoBehaviour
{
    public GameObject colliders;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform table in colliders.transform)
            foreach (Transform row in table.transform)
                foreach (Transform col in row.transform)
                {  
                    col.gameObject.AddComponent<Collider>();
                    col.gameObject.GetComponent<Collider>().ID = table.gameObject.name + row.gameObject.name + col.gameObject.name;
                    col.gameObject.GetComponent<MeshRenderer>().enabled = false;
                }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
