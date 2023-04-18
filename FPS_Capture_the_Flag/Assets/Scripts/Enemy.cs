using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //enemy stats
    public int curHp, maxHp, scoreToGive;
    public float moveSpeed, attackRange, yPathOffset;
    private List<Vector3> path;

    //Target to follow
    private GameObject target;
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerController>();

        player = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("UpdatePat", 0.0f, 0.5f);

        curHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        //Look at the target
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x,dir.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * angle;

        //calculate distance between enemy and player
        float dist = Vector3.Distance(transform.position, target.transform.position);
        //If withing attackrange fire at player
        if(dist <= attackRange)
        {
            player.TakeDamage(1);
        }
        //If enemy too far chase after player
        else
        {
            ChaseTarget();
        }

    }

    void UpdatePath()
    {
        //Calculate a path to the target
        UnityEngine.AI.NavMeshPath navMeshPath = new UnityEngine.AI.NavMeshPath();
        NewMesh.CalculatePath(transform.position, target.transform.position, UnityEngine.AI.NavMesh.AllAreas, navMeshPath);

        path = navMeshPath.corners.ToList();
    }

    void ChaseTarget()
    {
        if(path.Count == 0)
            return;

        //move towards closest path
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0,yPathOffset,0), moveSpeed * Time.deltaTime);

        if(transform.position == path[0] + new Vector3(0, yPathOffset, 0))
            path.RemoveAt(0);
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
