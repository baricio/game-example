using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        GameObject fimDoCaminho = GameObject.Find("FimDoCaminho");
        Vector3 vetorFimDoCaminho = fimDoCaminho.transform.position;
        agente.SetDestination(vetorFimDoCaminho);
	}
	

}
