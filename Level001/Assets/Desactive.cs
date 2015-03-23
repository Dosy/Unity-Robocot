using UnityEngine;
public class Desactive : MonoBehaviour {
	
	private Animator _animator;
	
	void Start()
	{
		_animator = GetComponent<Animator>();
	}
	
	void OnTriggerEnter(Collider collider)
	{
		_animator.SetBool("PlayerDetected", true);
	}
	
	//void OnTriggerExit(Collider collider)
	//{
		//_animator.SetBool("PlayerDetected", false);
	//}
}