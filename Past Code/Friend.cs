using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Friend : MonoBehaviour
{
   public NavMeshAgent friend;
   public Transform Player;

    void Update()
    {
        friend.SetDestination(Player.position);
    }
}
