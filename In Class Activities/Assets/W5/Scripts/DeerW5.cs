using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] Rigidbody db;
    [SerializeField] private Transform mushroom;
    [SerializeField] NavMeshAgent meshnav;

    private void Start()
    {
        meshnav = GetComponent<NavMeshAgent>();
        db = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        meshnav.SetDestination(mushroom.position);
    }
}


// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...