using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    [SerializeField]Transform movePosTransform;
    NavMeshAgent enemy;
    private void Awake() {
        enemy = GetComponent<NavMeshAgent>();
    }
    private void Update() {
        enemy.destination = movePosTransform.position;
    }

}
