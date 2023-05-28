using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _exHale; 
    [SerializeField] private ParticleSystem _inHale;

    private void Start()
    {
        Exhale();
    }

    private void Exhale()
    {
        _exHale.Play();
        Invoke("Inhale", 5);
    }

    private void Inhale()
    {
        _inHale.Play();   
        Invoke("Exhale", 5);
    }
}
