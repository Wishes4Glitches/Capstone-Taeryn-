using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public PlayerWeapon weapon;

    [SerializeField]
    private Camera camera;

    [SerializeField]
    private LayerMask mask;

    void Start()
    {
        if (camera == null)
        {
            Debug.LogError("No Camera Referenced");
            this.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, weapon.range, mask))
        {
            Debug.Log("we hit " + hit.collider.name);
        }
    }
}
