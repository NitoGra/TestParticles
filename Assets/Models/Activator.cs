using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
	[SerializeField] private List<ParticleSystem> _particles;

	private void OnCollisionEnter(Collision collision)
	{
		foreach (var particle in _particles)
			particle.Play();
	}
}