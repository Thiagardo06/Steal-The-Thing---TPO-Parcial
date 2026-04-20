using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public Transform[] patrolPoints;
    public Transform player;

    public float catchDistance = 1.5f;
    public float idleTime = 5f;
    public float idleChance = 40f;

    int currentPoint = 0;
    int lapsCompleted = 0;

    float idleCounter;

    NavMeshAgent agent;
    LineOfSight lineOfSight;

    enum State
    {
        Patrol,
        Idle,
        Chase
    }

    State currentState;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        lineOfSight = GetComponent<LineOfSight>();

        currentState = State.Patrol;
        agent.SetDestination(patrolPoints[currentPoint].position);
    }

    void Update()
    {
        
        if (lineOfSight.IsInRange(transform, player) &&
            lineOfSight.IsInAngle(transform, player) &&
            lineOfSight.HasLineOfSight(transform, player))
        {
            currentState = State.Chase;
        }
        else
        {
            if (currentState == State.Chase)
                currentState = State.Patrol;
        }


        switch (currentState)
        {
            case State.Patrol:
                Patrol();
                break;

            case State.Idle:
                Idle();
                break;

            case State.Chase:
                Chase();
                break;
        }


        float distToPlayer = Vector3.Distance(transform.position, player.position);

        if (distToPlayer < catchDistance)
        {
            FindObjectOfType<GameManager>().LoseGame();
        }
    }

    void Patrol()
    {
        if (agent.remainingDistance < 0.5f && !agent.pathPending)
        {
            currentPoint++;

            if (currentPoint >= patrolPoints.Length)
            {
                currentPoint = 0;
                lapsCompleted++;
            }

            if (lapsCompleted >= 1)
            {
                float chance = Random.Range(0f, 100f);

                if (chance <= idleChance)
                {
                    currentState = State.Idle;
                    idleCounter = idleTime;
                    agent.ResetPath();
                    return;
                }
            }

            agent.SetDestination(patrolPoints[currentPoint].position);
        }
    }

    void Idle()
    {
        idleCounter -= Time.deltaTime;

        if (idleCounter <= 0f)
        {
            currentState = State.Patrol;
            agent.SetDestination(patrolPoints[currentPoint].position);
        }
    }

    void Chase()
    {
        agent.SetDestination(player.position);
    }
}