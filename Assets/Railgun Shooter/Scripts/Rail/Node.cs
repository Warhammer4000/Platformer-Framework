using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    public Vector3 Position;//Cache pos
    public Transform LookAtTarget;

    public Node NextNode;

    public bool PlayerOnNode;
    public bool NodeComplete;

    public UnityEvent NodeStart;


    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NodeCompleted()
    {
        NodeComplete = true;
    }
  



}
