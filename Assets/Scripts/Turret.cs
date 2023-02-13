using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject currentProjectille;

    public float shootDelay;

    public Transform shootPosition; // пустой объект на дуле пушки

    protected float shootDelayCounter;

    Vector3 pointToShoot;

    void Update()
    {
        //Shoot();
    }

    private void Shoot()
    {
        shootDelayCounter += Time.deltaTime;
        if (shootDelayCounter >= shootDelay)
        {
            var bullet = Instantiate(currentProjectille, shootPosition.position, shootPosition.rotation);
            bullet.GetComponent<BulletMove>().targetPosition = pointToShoot;
            shootDelayCounter = 0;
        }

    }



}