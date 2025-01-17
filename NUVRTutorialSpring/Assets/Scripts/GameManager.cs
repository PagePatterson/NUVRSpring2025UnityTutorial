using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cheeseCounterText;
    private int cheeseCounter = 0;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void CollectedCheese()
    {
        cheeseCounter++;
        cheeseCounterText.text = $"counter:{cheeseCounter}";
    }
}
