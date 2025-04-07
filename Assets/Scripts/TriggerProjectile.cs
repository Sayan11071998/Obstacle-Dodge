using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private List<GameObject> projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (var projectile in projectiles)
            {
                if (projectile != null)
                    projectile.SetActive(true);
            }
        }
    }
}