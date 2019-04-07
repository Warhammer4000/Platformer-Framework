using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CharacterMoveLogic : MonoBehaviour
{
    private NavMeshAgent NavmeshAgent { get; set; }
    public bool PlayerShouldMove;

    public float LookAtSpeed;
    public Transform CamerTransform;



    public Node TargetNode;
    void Start()
    {
        NavmeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
    }


    void LateUpdate()
    {
        if (TargetNode.PlayerOnNode)
        {
            if (TargetNode.NodeComplete)
            {
                TargetNode = TargetNode.NextNode;
                PlayerShouldMove = true;
            }
        }
        else if(PlayerShouldMove)
        {
            PlayerShouldMove = false;
            StartCoroutine(SmoothRotateCamera(TargetNode.Position));
            Move(TargetNode.Position);
        }
    }

    private void Move(Vector3 nextPosition)
    {
        
        NavmeshAgent.SetDestination(nextPosition);
        
    }


    public void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.layer == 9)
        {
            TargetNode.PlayerOnNode = true;
            if (TargetNode.LookAtTarget != null)
            {
                StartCoroutine(SmoothRotateCamera(TargetNode.LookAtTarget.position));
            }
            else
            {
                TargetNode.NodeStart?.Invoke();
            }
                

        }
    }

    IEnumerator SmoothRotateCamera(Vector3 target)
    {
        Vector3 targetXz=new Vector3(target.x,CamerTransform.transform.position.y,target.z);

        while (CamerTransform.rotation!= Quaternion.LookRotation(targetXz - CamerTransform.position))
        {
            CamerTransform.rotation = Quaternion.RotateTowards(
                CamerTransform.rotation,
                Quaternion.LookRotation(targetXz - CamerTransform.position),
                Time.deltaTime * LookAtSpeed);
            yield return null;
        }
        TargetNode.NodeStart?.Invoke();
        
    }



}
