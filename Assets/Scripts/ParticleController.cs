using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _exHale; 
    [SerializeField] private ParticleSystem _inHale;
    [SerializeField] private ParticleSystem _darkExHale;

    private const float Delay = 5f;

    private int _inHalesCount = 0;

    private void Start()
    {
        Inhale();
    }

    private void Exhale()
    {
        _exHale.Play();
        Invoke(nameof(Inhale), Delay);
    }

    private void Inhale()
    {
        _inHale.Play();
        _inHalesCount++;

        if (_inHalesCount < 5)
            Invoke(nameof(Exhale), Delay);
        else
            Invoke(nameof(DarkExHale), Delay);
    }

    private void DarkExHale()
    {
        _inHalesCount = 0;
        _darkExHale.Play();
        Invoke(nameof(Inhale), Delay);
    }
}
