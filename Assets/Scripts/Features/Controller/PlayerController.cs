using Core;
using Features.Entities;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Player _player;

    [SerializeField] private BaseController player1;
    [SerializeField] private BaseController player2;

    private BaseController currentPlayer;

    private void Awake()
    {
        // �ڵ� Ž��
        if (player1 == null || player2 == null)
        {
            BaseController[] players = FindObjectsOfType<BaseController>();

            if (players.Length >= 2)
            {
                player1 = players[0];
                player2 = players[1];
            }
        }
    }

    private void Start()
    {
        if (player1 == null || player2 == null)
        {
            return;
        }

        // �ʱ� Ȱ��ȭ ����
        currentPlayer = player1;
        player1.SetActive(true);
        player2.SetActive(false);
    }

    private void Update()
    {
        if (currentPlayer == null) return;

        if (Input.GetKeyDown(KeyCode.Alpha1))
            SwitchPlayer(player1);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            SwitchPlayer(player2);
    }

    void SwitchPlayer(BaseController newPlayer)
    {
        if (newPlayer == null || currentPlayer == null) return;
        if (currentPlayer == newPlayer) return;

        currentPlayer.SetActive(false);
        newPlayer.SetActive(true);
        currentPlayer = newPlayer;
    }
}


