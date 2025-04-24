using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Object with this script must have particle system and collider components
[RequireComponent(typeof(ParticleSystem), typeof(Collider))]

public class TriggerParticles : MonoBehaviour
{
    private ParticleSystem particleSystem;

    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float emissionDelay;



    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) //only triggers when an object with a characterController component is attached
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        //first emission
        particleSystem.Emit(firstEmissionAmount);
        yield return new WaitForSeconds(emissionDelay);

        //second emission
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(emissionDelay);

        //third emission
        particleSystem.Emit(thirdEmissionAmount);
        yield return new WaitForSeconds(emissionDelay);
    }


}
