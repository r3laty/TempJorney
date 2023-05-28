using UnityEngine;

public class BreakingRollingBoulder : MonoBehaviour
{
    private void Destroying()
    {
        Destroy(this.gameObject);
    }
}
