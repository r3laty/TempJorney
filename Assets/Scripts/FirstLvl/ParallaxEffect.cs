using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
   [SerializeField, Range(0f, 1f)] private float _parallaxStrength = 0.1f;
    [SerializeField] private Transform followingTarget;
   [SerializeField] private bool _disableVericalParallax;

    private Vector3 targetPreviousPosition;
    private void Start()
    {
        targetPreviousPosition = followingTarget.position;
    }

    private void Update()
    {
        var delta = followingTarget.position - targetPreviousPosition;
        
        if(_disableVericalParallax)
        {
            delta.y = 0;
        }

        targetPreviousPosition = followingTarget.position;
        transform.position += delta * _parallaxStrength;


    }
}
