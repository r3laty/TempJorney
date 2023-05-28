using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    public void EndOfAnimation() => Destroy(gameObject);
}
