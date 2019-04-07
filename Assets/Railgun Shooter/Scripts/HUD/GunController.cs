using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool TrackMouse;
    public int Damage;
    public Camera Camera;

    public LayerMask ShootingLayers;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Camera=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(!TrackMouse)return;
        transform.position = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
        
            Shoot();
        }
    }


    private void Shoot()
    {
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
       
        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, ShootingLayers))
        {
            DamageHandeler damageHandeler = hit.transform.GetComponent<DamageHandeler>();
            damageHandeler?.DealDamage(Damage);
            Debug.Log(Damage +" Damage Dealt to "+ hit.transform.name);
             
        }
    }
}
