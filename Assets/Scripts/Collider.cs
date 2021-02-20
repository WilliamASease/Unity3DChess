using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public string ID;
    void Start() {}
    void Update(){}
    void OnMouseDown() { GameObject.Find("GameMaster").GetComponent<InputHandler>().Act(ID); }
}
