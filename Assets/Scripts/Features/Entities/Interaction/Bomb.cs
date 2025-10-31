using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Animator animator;
    public GameObject bombPrefab;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("RandomInstantiate");
    }

    bool SpawnBomb()
    {
        GameObject newBomb;
        Transform newTrans;

        newBomb = Instantiate(bombPrefab);

        newTrans = newBomb.transform;
        newTrans.parent = this.transform;
        newTrans.localPosition  = this.transform.localPosition;
        newTrans.localRotation = Quaternion.identity;

        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("WaitBomb");

        if (collision.gameObject.CompareTag("PlayerWater"))
        {
            StartCoroutine("WaitDestroy", collision);
            Debug.Log("터짐");
            Destroy(this.gameObject);
        }
    }

    IEnumerator WaitBomb()
    {
        yield return new WaitForSeconds(3.0f);
        animator.SetBool("isBomb", true);
    }

    IEnumerator WaitDestroy(Collision2D collision)
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(collision.gameObject);
    }

    IEnumerator RandomInstantiate()
    {
        float ran = Random.Range(1, 5);
        yield return new WaitForSeconds(ran);
        SpawnBomb();
    }
}
