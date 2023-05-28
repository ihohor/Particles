using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _exHale; 
    [SerializeField] private ParticleSystem _inHale;

    private const float _delay = 5f;

    private void Start()
    {
        Exhale();
    }

    private void Exhale()
    {
        _exHale.Play();
        Invoke(nameof(Inhale), _delay);
    }

    private void Inhale()
    {
        _inHale.Play();   
        Invoke(nameof(Exhale), _delay);
    }
}
